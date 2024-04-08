using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MyMoviesManager.Models;

namespace MyMoviesManager
{
    public partial class FrmMovieUpdateMain : Form
    {
        private readonly MyMoviesDbContext dbContext;

        public FrmMovieUpdateMain(Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;

            dbContext = new MyMoviesDbContext();
        }

        private void FrmMovieUpdateMain_Load(object sender, EventArgs e)
        {
            var movies = dbContext.Movies.Include(m => m.Actors).ToList();

            dataGridViewUpdate.DataSource = movies;
            dataGridViewUpdate.AutoGenerateColumns = false;

            // Μετάφραση των πεδίων του DataGridView στα ελληνικά

            dataGridViewUpdate.Columns["Title"].HeaderText = "Τίτλος";
            dataGridViewUpdate.Columns["ReleaseDate"].HeaderText = "Ημερομηνία Κυκλοφορίας";
            dataGridViewUpdate.Columns["Category"].HeaderText = "Κατηγορία";
            dataGridViewUpdate.Columns["Availability"].HeaderText = "Διαθεσιμότητα";
            dataGridViewUpdate.Columns["IMDBRating"].HeaderText = "IMDB Βαθμολογία";
            dataGridViewUpdate.Columns["WatchedDate"].HeaderText = "Ημερομηνία Προβολής";
            dataGridViewUpdate.Columns["Watched"].HeaderText = "Την Έχω Δεί";
            dataGridViewUpdate.Columns["WatchedDate"].HeaderText = "Ημερομηνία Προβολής";
            dataGridViewUpdate.Columns["Actors"].HeaderText = "ΗΘοποιοί";

            dataGridViewUpdate.Columns.Remove(dataGridViewUpdate.Columns["MovieId"]);
            dataGridViewUpdate.Columns.Remove(dataGridViewUpdate.Columns["ImagePath"]);
            //Make sure to set the DataPropertyName of the Category column to "Category"
            dataGridViewUpdate.Columns["Category"].DataPropertyName = "Category";

            // Handle cell formatting and row double-click similar to previous code...

            dataGridViewUpdate.CellFormatting += dataGridViewUpdate_CellFormatting;
            dataGridViewUpdate.CellContentClick += dataGridViewUpdate_CellContentClick;
        }

        private void dataGridViewUpdate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUpdate.Columns["Watched"].Index && e.Value is bool)
            {
                bool watched = (bool)e.Value;
                e.Value = watched ? "Ναι" : "Όχι";
                e.FormattingApplied = true;
            }


            if (e.ColumnIndex == dataGridViewUpdate.Columns["Actors"].Index)
            {
                var movie = dataGridViewUpdate.Rows[e.RowIndex].DataBoundItem as Movies;
                if (movie != null && movie.Actors.Any())
                {
                    var actorNames = movie.Actors.Select(actor => actor.ActorName);
                    e.Value = string.Join(", ", actorNames);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridViewUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedMovie = dataGridViewUpdate.Rows[e.RowIndex].DataBoundItem as Movies;

                if (selectedMovie != null)
                {
                    using (var movieUpdateChildForm = new MovieUpdateChild(selectedMovie, dbContext))
                    {
                        movieUpdateChildForm.ShowDialog();
                    }
                }
            }
        }

        private void dataGridViewUpdate_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
