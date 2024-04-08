using MyMoviesManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoviesManager
{
    public partial class FrmRecomendedMovie : Form
    {
        private List<Movies> unwatchedMovies = new List<Movies>();
        private Random random = new Random();

        public FrmRecomendedMovie(Color TheColor)
        {
            InitializeComponent();
            BackColor = TheColor;
            LoadUnwatchedMovies();
            PopulateRecommendedMovie(); // Call this method to populate the recommended movie.
        }

        // Create a method to load unwatched movies from the database
        private void LoadUnwatchedMovies()
        {
            using (var context = new MyMoviesDbContext())
            {
                unwatchedMovies = context.Movies.Where(movie => movie.Watched == false).ToList();
            }
        }

        // Create a method to shuffle the unwatched movies list
        private void ShuffleUnwatchedMovies()
        {
            int n = unwatchedMovies.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = unwatchedMovies[k];
                unwatchedMovies[k] = unwatchedMovies[n];
                unwatchedMovies[n] = value;
            }
        }
        // Create a method to populate the recommended movie fields
        private void PopulateRecommendedMovie()
        {
            if (unwatchedMovies.Count > 0)
            {
                ShuffleUnwatchedMovies(); // Shuffle the unwatched movies list
                var recommendedMovie = unwatchedMovies[0];

                // Populate the fields with the recommended movie data
                TxtTitleRecomendedMovie.Text = recommendedMovie.Title;
                TxtRecomendedRealeaseDate.Text = recommendedMovie.ReleaseDate?.ToShortDateString();
                TxtCategoryRecommended.Text = recommendedMovie.Category;
                TxtIMdbRateRecommended.Text = recommendedMovie.Imdbrating?.ToString();

                // Set the watched status
                TxtBoxSeenMovieRecommended.Text = recommendedMovie.Watched == true
                    ? recommendedMovie.WatchedDate?.ToShortDateString()
                    : "Όχι";

                // Load the image from ImagePath
                if (!string.IsNullOrEmpty(recommendedMovie.ImagePath))
                {
                    PictureBoxMovieRecommended.Image = Image.FromFile(recommendedMovie.ImagePath);
                }
                else
                {
                    PictureBoxMovieRecommended.Image = null; // Set the image to null if ImagePath is empty or null
                }

                using (var context = new MyMoviesDbContext())
                {
                    // Populate the actors in the listViewActorsRecommended from the Actors table
                    listViewActorsRecommended.Items.Clear();
                    var actorNames = context.Actors
                        .Where(actor => actor.MovieId == recommendedMovie.MovieId)
                        .Select(actor => actor.ActorName)
                        .ToList();

                    listViewActorsRecommended.Items.AddRange(actorNames.Select(actorName => new ListViewItem(actorName)).ToArray());
                }

                // Populate the availability in the ListViewAvailabilityRecommended
                ListViewAvailabilityRecommended.Items.Clear();
                string[] availabilityItems = recommendedMovie.Availability.Split(';');
                ListViewAvailabilityRecommended.Items.AddRange(availabilityItems.Select(availability => new ListViewItem(availability)).ToArray());
            }
            else
            {
                // Handle the case when no unwatched movies are found.
                MessageBox.Show("Εχετε δει ολες της ταινιες της συλλογης σας.");
            }
        }



        private void listViewActorsRecommended_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewAvailabilityRecommended_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Other event handlers and methods as needed.
    }
}
