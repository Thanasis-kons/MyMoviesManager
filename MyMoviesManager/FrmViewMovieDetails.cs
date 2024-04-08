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
using System.Net.Http;
using System.Threading.Tasks;

namespace MyMoviesManager
{
    public partial class FrmViewMovieDetails : Form
    {
        public FrmViewMovieDetails()
        {
            InitializeComponent();

        }
        // Create a method to populate the fields with movie data
        public void PopulateMovieDetails(Movies movie)
        {
            TxtTitleMovieView.Text = movie.Title;
            TxtReleaseDateView.Text = movie.ReleaseDate?.ToShortDateString();
            TxtCategoryView.Text = movie.Category;
            TxtIMdbRateView.Text = movie.Imdbrating?.ToString();

            // Set the watched status
            TxtBoxSeenMovieView.Text = movie.Watched == true ? movie.WatchedDate?.ToShortDateString() : "Όχι";

            // Set the availability
            // Replace listViewAvailabilityView with the actual name of your ListView control
            listViewAvailabilityView.Items.Clear();
            string[] availabilityItems = movie.Availability.Split(';');
            listViewAvailabilityView.Items.AddRange(availabilityItems.Select(availability => new ListViewItem(availability)).ToArray());

            // Populate actors in the ListView
            listViewActors.Items.Clear();
            listViewActors.Items.AddRange(movie.Actors.Select(actor => new ListViewItem(actor.ActorName)).ToArray());

            // Check if the ImagePath is not null or empty before setting the image
            if (!string.IsNullOrEmpty(movie.ImagePath))
            {
                PictureBoxMovieView.Image = Image.FromFile(movie.ImagePath);
            }
            else
            {
                PictureBoxMovieView.Image = null; // Set the image to null if ImagePath is empty or null
            }
        }



        private void TxtTitleMovieView_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtReleaseDateView_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCategoryView_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewActors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxSeenMovieView_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewAvailabilityView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxMovieView_Click(object sender, EventArgs e)
        {

        }

        private void TxtIMdbRateView_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewMovieReview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}