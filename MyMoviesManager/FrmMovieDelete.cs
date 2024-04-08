using System;
using System.Windows.Forms;
using MyMoviesManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MyMoviesManager
{
    public partial class FrmMovieDelete : Form
    {
        private readonly MyMoviesDbContext dbContext;

        public FrmMovieDelete(Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;
            dbContext = new MyMoviesDbContext(); // Αρχικοποίηση του DbContext
            DtGrMovieDelete.CellFormatting += DtGrMovieDelete_CellFormatting;

        }

        // Δημιουργία μεθόδου για φόρτωση και εμφάνιση του DataGridView
        private void LoadMovies()
        {
            var movies = dbContext.Movies.Include(m => m.Actors).ToList();
            DtGrMovieDelete.DataSource = movies;
            // Απενεργοποιήστε την αυτόματη δημιουργία στηλών
            DtGrMovieDelete.AutoGenerateColumns = false;
            // Μεταφράστε τα πεδία του DataGridView
            DtGrMovieDelete.Columns["Title"].HeaderText = "Τίτλος";
            DtGrMovieDelete.Columns["ReleaseDate"].HeaderText = "Ημερομηνία Κυκλοφορίας";
            DtGrMovieDelete.Columns["Category"].HeaderText = "Κατηγορία";
            DtGrMovieDelete.Columns["Availability"].HeaderText = "Διαθεσιμότητα";
            DtGrMovieDelete.Columns["ImdbRating"].HeaderText = "IMDB Βαθμολογία";
            DtGrMovieDelete.Columns["Watched"].HeaderText = "Την Έχω Δεί";
            DtGrMovieDelete.Columns["Watched"].DefaultCellStyle.NullValue = "Όχι";
            DtGrMovieDelete.Columns["Watched"].DefaultCellStyle.DataSourceNullValue = "Όχι";
            DtGrMovieDelete.Columns["Watched"].DefaultCellStyle.Format = "Ναι";
            DtGrMovieDelete.Columns["WatchedDate"].HeaderText = "Ημερομηνία Προβολής";

            // Προσθέστε τους ηθοποιούς στο πεδίο τους
            DtGrMovieDelete.Columns["Actors"].HeaderText = "Ηθοποιοί";
            DtGrMovieDelete.Columns["Actors"].DefaultCellStyle.Format = "g"; // Εμφάνιση ηθοποιών ως λίστα

            // Κρύψτε τα πεδία MovieId και ImagePath
            DtGrMovieDelete.Columns["MovieId"].Visible = false;
            DtGrMovieDelete.Columns["ImagePath"].Visible = false;

            


        }

        private void DtGrMovieDelete_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DtGrMovieDelete.Columns["Watched"].Index && e.Value is bool)
            {
                bool watched = (bool)e.Value;
                e.Value = watched ? "Ναι" : "Όχι";
                e.FormattingApplied = true;
            }

            if (e.ColumnIndex == DtGrMovieDelete.Columns["Actors"].Index)
            {
                var movie = DtGrMovieDelete.Rows[e.RowIndex].DataBoundItem as Movies;
                if (movie != null && movie.Actors.Any())
                {
                    var actorNames = movie.Actors.Select(actor => actor.ActorName);
                    e.Value = string.Join(", ", actorNames);
                    e.FormattingApplied = true;
                }

            }
        }

        private void FrmMovieDelete_Load(object sender, EventArgs e)
        {
            LoadMovies(); // Φόρτωση και εμφάνιση των ταινιών κατά τη φόρτωση της φόρμας
        }

        // Χειρισμός διπλού κλικ στο DataGridView
        private void DtGrMovieDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Λήψη της επιλεγμένης ταινίας
                var selectedMovie = DtGrMovieDelete.Rows[e.RowIndex].DataBoundItem as Movies;

                if (selectedMovie != null)
                {
                    // Εμφάνιση διαλόγου επιβεβαίωσης πριν τη διαγραφή
                    var result = MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε αυτήν την ταινία;", "Επιβεβαίωση Διαγραφής", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Διαγραφή της ταινίας από τη βάση δεδομένων
                        dbContext.Movies.Remove(selectedMovie);
                        dbContext.SaveChanges();

                        // Επαναφόρτωση του DataGridView μετά τη διαγραφή
                        LoadMovies();
                    }
                }
            }
        }
    }
}
