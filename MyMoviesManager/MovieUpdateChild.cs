using MyMoviesManager.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using static MyMoviesManager.FrmMain;

namespace MyMoviesManager
{
    
    public partial class MovieUpdateChild : Form
    {   
        private MyMoviesDbContext dbContext;
        private Movies movie;
        private CategoryManager categoryManager;
        private AvailabilityManager availabilityManager;

        public MovieUpdateChild(Movies selectedMovie, MyMoviesDbContext context)
        {
            InitializeComponent();
            dbContext = context; // Pass the provided context to use
            categoryManager = CategoryManager.GetInstance();

            CmbMovieCategoriesUpdate.DataSource = categoryManager.Categories;
            CmbMovieCategoriesUpdate.DisplayMember = "Category";

            availabilityManager = AvailabilityManager.GetInstance();

            AvailabilityListBoxUpdate.DataSource = availabilityManager.Availabilities;
            AvailabilityListBoxUpdate.DisplayMember = "Availability";

            movie = selectedMovie; // Store the selected movie
        }
        private async Task<double?> GetImdbRatingAsync(string title)
        {
            using (HttpClient client = new HttpClient())
            {
                // Ορίζουμε το API key για το OMDb API
                string apiKey = "965a08ca";

                // Κάνουμε αίτηση στο OMDb API για να ανακτήσουμε τα στοιχεία της ταινίας
                HttpResponseMessage response = await client.GetAsync($"http://www.omdbapi.com/?apikey={apiKey}&t={title}");

                if (response.IsSuccessStatusCode)
                {
                    // Αν η αίτηση είναι επιτυχής, διαβάζουμε την απάντηση ως JSON
                    string json = await response.Content.ReadAsStringAsync();
                    JObject movieData = JObject.Parse(json);

                    if (movieData["imdbRating"] != null)

                        // Παίρνουμε το IMDB rating από την απάντηση
                        if (double.TryParse(movieData["imdbRating"].ToString(), out double imdbRating))
                        {
                            return imdbRating;
                        }
                }
            }

            return null;
        }

        public void PopulateMovieDetails()
        {
            if (movie != null)
            {
                TxtTitleUpdate.Text = movie.Title;
                MovieRealeseDatepickerUpdate.Value = movie.ReleaseDate ?? DateTime.Now;

                // Set the selected category in the ComboBox
                CmbMovieCategoriesUpdate.SelectedItem = categoryManager.Categories.FirstOrDefault(c => c.Category == movie.Category);

                // Populate the actors in the ListBox
                ListBoxActors.Items.Clear();
                ListBoxActors.Items.AddRange(movie.Actors.Select(actor => actor.ActorName).ToArray());

                // Load the image into PboxMovieCreationUpdate
                if (!string.IsNullOrEmpty(movie.ImagePath))
                {
                    try
                    {
                        if (IsImageFileSupported(movie.ImagePath))
                        {
                            PboxMovieCreationUpdate.Image = Image.FromFile(movie.ImagePath);
                        }
                        else
                        {
                            PboxMovieCreationUpdate.Image = null;
                            MessageBox.Show("Μη υποστηριζόμενη μορφή εικόνας. Επιλέξτε μια έγκυρη μορφή εικόνας.", "Μη Έγκυρη Μορφή Εικόνας", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        PboxMovieCreationUpdate.Image = null;
                        MessageBox.Show($"Σφάλμα κατά τη φόρτωση της εικόνας: {ex.Message}", "Σφάλμα Φόρτωσης Εικόνας", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PboxMovieCreationUpdate.Image = null;
                }

                // Set the Watched status and date
                if (movie.Watched == true)
                {
                    RbutttonSeenMovieUpdate.Checked = true;
                    SawDatePickerUpdate.Value = movie.WatchedDate ?? DateTime.Now;
                }
                else
                {
                    RButtonNotSeenUpdate.Checked = true;
                }

                TxtImdbRattingUpdate.Text = movie.Imdbrating?.ToString();
            }
        }

        private bool IsImageFileSupported(string imagePath)
        {
            // Define a list of supported image file extensions
            List<string> supportedExtensions = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

            // Check if the file extension is in the list of supported extensions
            string fileExtension = Path.GetExtension(imagePath).ToLower();
            return supportedExtensions.Contains(fileExtension);
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            // Check if the Category field is empty
            if (CmbMovieCategoriesUpdate.SelectedItem == null)
            {
                MessageBox.Show("Το πεδίο 'Κατηγορία' είναι υποχρεωτικό.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the Title field is empty
            if (string.IsNullOrEmpty(TxtTitleUpdate.Text))
            {
                MessageBox.Show("Το πεδίο 'Τίτλος' είναι υποχρεωτικό.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if no availability is selected
            if (AvailabilityListBoxUpdate.SelectedItems.Count == 0)
            {
                MessageBox.Show("Πρέπει να επιλέξετε τουλάχιστον μία διαθέσιμη κατάσταση.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (movie != null)
            {
                // Update movie properties
                movie.Title = TxtTitleUpdate.Text;
                movie.ReleaseDate = MovieRealeseDatepickerUpdate.Value;

                // Get the selected category from the ComboBox
                Movies selectedCategory = (Movies)CmbMovieCategoriesUpdate.SelectedItem;
                movie.Category = selectedCategory.Category;

                // Update actors list
                movie.Actors.Clear();
                foreach (var actorName in ListBoxActors.Items)
                {
                    Actors actor = new Actors
                    {
                        ActorName = actorName.ToString(),
                        Movie = movie
                    };
                    movie.Actors.Add(actor);
                }

                // Update other properties (e.g., IMDb rating)
                if (!string.IsNullOrEmpty(TxtImdbRattingUpdate.Text))
                {
                    if (double.TryParse(TxtImdbRattingUpdate.Text, out double imdbRating))
                    {
                        movie.Imdbrating = imdbRating;
                    }
                    else
                    {
                        MessageBox.Show("Μη έγκυρη τιμή IMDb. Εισαγάγετε ένα έγκυρο αριθμητικό IMDb rating.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    movie.Imdbrating = null;
                }

                // Update availability
                var selectedAvailabilities = AvailabilityListBoxUpdate.SelectedItems;
                movie.Availability = string.Join(", ", selectedAvailabilities.Cast<Movies>().Select(m => m.Availability));

                // Update watched status and date
                if (RbutttonSeenMovieUpdate.Checked)
                {
                    movie.Watched = true;
                    movie.WatchedDate = SawDatePickerUpdate.Value;
                }
                else
                {
                    movie.Watched = false;
                    movie.WatchedDate = null;
                }

                // Save changes to the database
                dbContext.SaveChanges();

                // Close the form
                this.Close();
            }
        }




        private async void TxtTitleUpdate_TextChanged(object sender, EventArgs e)
        {
            // When the user changes the title, try to retrieve the IMDb rating from the OMDb API
            string title = TxtTitleUpdate.Text;
            if (!string.IsNullOrWhiteSpace(title))
            {
                try
                {
                    double? imdbRating = await GetImdbRatingAsync(title);
                    if (imdbRating.HasValue)
                    {
                        TxtImdbRattingUpdate.Text = imdbRating.Value.ToString();
                    }
                    else
                    {
                        TxtImdbRattingUpdate.Text = string.Empty; // Set it to empty string if no rating is available
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., show an error message
                    MessageBox.Show($"Error fetching IMDb rating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtImdbRattingUpdate.Text = string.Empty; // Set it to empty string in case of an error
                }
            }
            else
            {
                TxtImdbRattingUpdate.Text = string.Empty; // Set it to empty string if the title is empty
            }
        }





        private void MovieRealeseDatepickerUpdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbMovieCategoriesUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtActorsupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxActors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnActorsAdd_Click(object sender, EventArgs e)
        {
            // Get the actor name from the TextBox
            string actorName = TxtActorsupdate.Text.Trim();
            // Add the actor to the ListBox
            ListBoxActors.Items.Add(actorName);
            TxtActorsupdate.Text = string.Empty; // Clear the TextBox
        }

        private void BtnRemoveActors_Click(object sender, EventArgs e)
        {
            // Remove the selected actors from the ListBox
            foreach (var actor in ListBoxActors.SelectedItems.Cast<string>().ToList())
            {
                ListBoxActors.Items.Remove(actor);
            }
        }

        private void AvailabilityListBoxUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SawDatePickerUpdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RbutttonSeenMovieUpdate_CheckedChanged(object sender, EventArgs e)
        {
            // Εάν ο χρήστης έχει δει την ταινία, ενεργοποιούμε τα πεδία για την ημερομηνία που την είδε
            if (RbutttonSeenMovieUpdate.Checked)
            {
                LblSawDateUpdate.Visible = true;
                SawDatePickerUpdate.Visible = true;
            }
            else
            {
                LblSawDateUpdate.Visible = false;
                SawDatePickerUpdate.Visible = false;
            }
        }
    

        private void RButtonNotSeenUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtImdbRattingUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void PboxMovieCreationUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Αρχεία Εικόνων | *.jpg; *.png; *.bmp; *.jpeg; *.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;
                if (IsImageFileSupported(imagePath))
                {
                    // Εμφάνιση της επιλεγμένης εικόνας στο PictureBox
                    PboxMovieCreationUpdate.Image = Image.FromFile(imagePath);

                    // Αποθήκευση του διαδρόμου της εικόνας στη βάση δεδομένων
                    if (movie != null)
                    {
                        movie.ImagePath = imagePath;
                        dbContext.SaveChanges();
                    }
                }
                else
                {
                    PboxMovieCreationUpdate.Image = null;
                    MessageBox.Show("Μη υποστηριζόμενη μορφή εικόνας. Επιλέξτε μια έγκυρη μορφή εικόνας (π.χ., .jpg, .png, .bmp, .jpeg, .gif).", "Μη Έγκυρη Μορφή Εικόνας", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MovieUpdateChild_Load(object sender, EventArgs e)
        {
            PopulateMovieDetails(); // Call the method to populate the fields when the form loads
        }
    }
}
