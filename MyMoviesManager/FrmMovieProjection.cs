using Microsoft.EntityFrameworkCore;
using MyMoviesManager.Models;
using System;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace MyMoviesManager
{
    public partial class FrmMovieProjection : Form
    {
        private readonly MyMoviesDbContext dbContext;

        public FrmMovieProjection(Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;

            // Αρχικοποίηση του DbContext για την αλληλεπίδραση με τη βάση δεδομένων
            dbContext = new MyMoviesDbContext();
        }

        private void FrmMovieProjection_Load(object sender, EventArgs e)
        {
            // Φορτώστε τις ταινίες και συμπεριλάβετε τους ηθοποιούς
            var movies = dbContext.Movies.Include(m => m.Actors).ToList();
            var actors = dbContext.Actors.ToList();
            // Εμφανίζουμε τις ταινίες στο DataGridView
            dataGridViewMovies.DataSource = movies;

            // Απενεργοποιήστε την αυτόματη δημιουργία στηλών
            dataGridViewMovies.AutoGenerateColumns = false;

            // Μετάφραση των πεδίων του DataGridView στα ελληνικά

            dataGridViewMovies.Columns["Title"].HeaderText = "Τίτλος";
            dataGridViewMovies.Columns["ReleaseDate"].HeaderText = "Ημερομηνία Κυκλοφορίας";
            dataGridViewMovies.Columns["Category"].HeaderText = "Κατηγορία";
            dataGridViewMovies.Columns["Availability"].HeaderText = "Διαθεσιμότητα";
            dataGridViewMovies.Columns["IMDBRating"].HeaderText = "IMDB Βαθμολογία";
            dataGridViewMovies.Columns["Watched"].HeaderText = "Την Έχω Δεί";
            dataGridViewMovies.Columns["WatchedDate"].HeaderText = "Ημερομηνία Προβολής";
            dataGridViewMovies.Columns["Actors"].HeaderText = "ΗΘοποιοί";

            dataGridViewMovies.Columns.Remove(dataGridViewMovies.Columns["MovieId"]);
            dataGridViewMovies.Columns.Remove(dataGridViewMovies.Columns["ImagePath"]);

            //Make sure to set the DataPropertyName of the Category column to "Category"
            dataGridViewMovies.Columns["Category"].DataPropertyName = "Category";
            // Προσθέστε τον χειριστή για τη μορφοποίηση της στήλης "Την Έχω Δεί"
            dataGridViewMovies.CellFormatting += dataGridViewMovies_CellFormatting;

            // Update the total movie count
            UpdateMovieCount();

        }

        private void UpdateMovieCount()
        {
            int movieCount = dataGridViewMovies.Rows.Count;
            LblMovieCount.Text += movieCount;
        }


        private void dataGridViewMovies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMovies.Columns["Watched"].Index && e.Value is bool)
            {
                bool watched = (bool)e.Value;
                e.Value = watched ? "Ναι" : "Όχι";
                e.FormattingApplied = true;
            }


            if (e.ColumnIndex == dataGridViewMovies.Columns["Actors"].Index)
            {
                var movie = dataGridViewMovies.Rows[e.RowIndex].DataBoundItem as Movies;
                if (movie != null && movie.Actors.Any())
                {
                    var actorNames = movie.Actors.Select(actor => actor.ActorName);
                    e.Value = string.Join(", ", actorNames);
                    e.FormattingApplied = true;
                }
            }
        }



        private void dataGridViewMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewMovies.Rows.Count)
            {
                var selectedMovie = dataGridViewMovies.Rows[e.RowIndex].DataBoundItem as Movies;

                // Make sure you have an instance of FrmViewMovieDetails
                FrmViewMovieDetails frmViewMovieDetails = new FrmViewMovieDetails();

                // Call the method to populate the movie details in FrmViewMovieDetails
                frmViewMovieDetails.PopulateMovieDetails(selectedMovie);

                // Show FrmViewMovieDetails
                frmViewMovieDetails.Show();
            }
        }


    }
}





