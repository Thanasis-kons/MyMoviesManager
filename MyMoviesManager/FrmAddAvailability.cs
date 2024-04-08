using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using MyMoviesManager.Models;

namespace MyMoviesManager;
public partial class FrmAddAvailability : Form
{
    private FrmAddMovie frmAddMovie;

    public FrmAddAvailability(Color TheColor, FrmAddMovie addMovieForm)
    {
        InitializeComponent();
        this.BackColor = TheColor;
        frmAddMovie = addMovieForm;
    }


    private void BtnAddAvailability_Click(object sender, EventArgs e)
    {
        string availabilityToAdd = TxtAddAvailability.Text;

        // Check if the availability already exists
        if (frmAddMovie != null)
        {
            if (frmAddMovie.AvailabilityExists(availabilityToAdd))
            {
                MessageBox.Show("Η Διαθεσιμότητα υπάρχει ήδη στη λίστα.");
            }
            else
            {
                // Call the method in FrmAddMovie to add the availability to the AvailabilityManager
                frmAddMovie.AddAvailabilityToAvailabilitySetter(availabilityToAdd);

                // Optionally, clear the AvailabilityTextBox
                TxtAddAvailability.Clear();
            }
        }
    }
}