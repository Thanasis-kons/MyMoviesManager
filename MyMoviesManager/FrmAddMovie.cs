using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using MyMoviesManager.Models;
using Microsoft.Identity.Client;
using static MyMoviesManager.FrmMain;

namespace MyMoviesManager
{
    public partial class FrmAddMovie : Form
    {
        private Movies movies;
        private readonly MyMoviesDbContext dbContext;
        private CategoryManager categoryManager;
        private AvailabilityManager availabilityManager;
        public FrmAddMovie(Color TheColor, FrmAddCategory frmAddCategory, Movies movies)
        {
            InitializeComponent();
            this.BackColor = TheColor;
            dbContext = new MyMoviesDbContext();
            categoryManager = FormInitializer.InitializeCategoryManager();

            CmbMovieCategories.DataSource = categoryManager.Categories;
            CmbMovieCategories.DisplayMember = "Category";

            availabilityManager = AvailabilityFormInitializer.InitializeAvailabilityManager();

            AvailabilityListBox.DataSource = availabilityManager.Availabilities;
            AvailabilityListBox.DisplayMember = "Availability";


        }

        public void AddCategoryToCategoriesSetter(string category)
        {
            CategoryManager categoryManager = CategoryManager.GetInstance();
            categoryManager.AddCategory(new Movies() { Category = category });

            // Refresh the ComboBox data source
            CmbMovieCategories.DataSource = categoryManager.Categories;
            CmbMovieCategories.DisplayMember = "Category";
        }

        public bool CategoryExists(string category)
        {
            CategoryManager categoryManager = CategoryManager.GetInstance();
            return categoryManager.Categories.Any(c => c.Category == category);
        }

        public void AddAvailabilityToAvailabilitySetter(string availability)
        {
            AvailabilityManager availabilityManager = AvailabilityManager.GetInstance();
            availabilityManager.AddAvailability(new Movies() { Availability = availability });

            AvailabilityListBox.DataSource = availabilityManager.Availabilities;
            AvailabilityListBox.DisplayMember = "Availability";

        }

        public bool AvailabilityExists(string availability)
        {
            AvailabilityManager availabilityManager = AvailabilityManager.GetInstance();
            return availabilityManager.Availabilities.Any(a => a.Availability == availability);

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

        private void BtnSaveMovie_Click(object sender, EventArgs e)
        {
            // Έλεγχος για το αν η κατηγορία είναι κενή
            if (string.IsNullOrEmpty(CmbMovieCategories.Text))
            {
                MessageBox.Show("Η κατηγορία είναι υποχρεωτική.");
                return;
            }

            // Έλεγχος για το αν ο τίτλος είναι κενός
            if (string.IsNullOrEmpty(TxtTitle.Text))
            {
                MessageBox.Show("Ο τίτλος είναι υποχρεωτικός.");
                return;
            }

            // Check if no availability is selected
            if (AvailabilityListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Πρέπει να επιλέξετε τουλάχιστον μία διαθέσιμη κατάσταση.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Παίρνουμε τα δεδομένα από τα πεδία της φόρμας
            string title = TxtTitle.Text;
            DateTime releaseDate = MovieRealeseDatepicker.Value;
            string actors = TxtActors.Text;

            // Get the selected category from the ComboBox
            Movies selectedCategory = (Movies)CmbMovieCategories.SelectedItem;
            string category = selectedCategory.Category;

            var selectedAvailabilities = AvailabilityListBox.SelectedItems;
            double? imdbRating = string.IsNullOrWhiteSpace(TxtImdbRatting.Text) ? null : ParseImdbRating(TxtImdbRatting.Text);
            string imagePath = PboxMovieCreation.ImageLocation;
            bool watched = RbutttonSeenMovie.Checked;
            DateTime? watchedDate = watched ? SawDatePicker.Value : (DateTime?)null;

            // Check if parsing IMDb rating fails
            if (imdbRating == null)
            {
            }

            // Assign the image path to the Movies entity
            Movies movie = new Movies
            {
                Title = title,
                ReleaseDate = releaseDate,
                Category = category,
                Availability = string.Join(", ", selectedAvailabilities.Cast<Movies>().Select(m => m.Availability)),
                Watched = watched,
                WatchedDate = watchedDate,
                ImagePath = imagePath,
                Imdbrating = imdbRating
            };

            dbContext.Movies.Add(movie);

            // Αποθηκεύουμε τους πρωταγωνιστές της ταινίας, αν υπάρχουν
            if (!string.IsNullOrWhiteSpace(actors))
            {
                string[] actorNames = actors.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string actorName in actorNames)
                {
                    Actors actor = new Actors
                    {
                        ActorName = actorName.Trim(),
                        Movie = movie
                    };
                    dbContext.Actors.Add(actor);
                }
            }

            // Αποθηκεύουμε τις αλλαγές στη βάση δεδομένων
            dbContext.SaveChanges();

            // Καθαρίζουμε τα πεδία της φόρμας για την επόμενη εισαγωγή
            TxtTitle.Clear();
            TxtActors.Clear();
            TxtImdbRatting.Clear();
            PboxMovieCreation.Image = null;
            RbutttonSeenMovie.Checked = false;
            RButtonNotSeen.Checked = false;
        }

        private double? ParseImdbRating(string imdbRatingText)
        {
            double imdbRating;
            if (double.TryParse(imdbRatingText, out imdbRating))
            {
                return imdbRating;
            }
            return null; // Return null if parsing fails
        }


        private void PboxMovieCreation_Click(object sender, EventArgs e)
        {
            // Κώδικας για την επιλογή και αποθήκευση εικόνας της ταινίας
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files | *.jpg; *.png; *.bmp; *.jpeg; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PboxMovieCreation.ImageLocation = dialog.FileName;
            }
        }

        private async void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            // Όταν ο χρήστης αλλάζει τον τίτλο, προσπαθούμε να ανακτήσουμε το IMDB rating από το OMDb API
            string title = TxtTitle.Text;
            if (!string.IsNullOrWhiteSpace(title))
            {
                double? imdbRating = await GetImdbRatingAsync(title);
                if (imdbRating.HasValue)
                {
                    TxtImdbRatting.Text = imdbRating.Value.ToString();
                }
                else
                {
                    TxtImdbRatting.Clear();
                }
            }
            else
            {
                TxtImdbRatting.Clear();
            }
        }

        private void RbutttonSeenMovie_CheckedChanged(object sender, EventArgs e)
        {
            // Εάν ο χρήστης έχει δει την ταινία, ενεργοποιούμε τα πεδία για την ημερομηνία που την είδε
            if (RbutttonSeenMovie.Checked)
            {
                LblSawDate.Visible = true;
                SawDatePicker.Visible = true;
            }
            else
            {
                LblSawDate.Visible = false;
                SawDatePicker.Visible = false;
            }
        }


        private void CmbMovieCategories_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FrmAddMovie_Load(object sender, EventArgs e)
        {

        }

        private void AvailabilityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbMovieCategories_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void TxtImdbRatting_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtActors_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


