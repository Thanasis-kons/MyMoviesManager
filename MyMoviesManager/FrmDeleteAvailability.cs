using System;
using System.Windows.Forms;
using MyMoviesManager.Models;

namespace MyMoviesManager
{
    public partial class FrmDeleteAvailability : Form
    {
        private AvailabilityManager availabilityManager;

        public FrmDeleteAvailability(Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;
            availabilityManager = AvailabilityManager.GetInstance();

            RefreshAvailabilityListBox();

            ListAvailabilityDelete.DoubleClick += ListAvailabilityDelete_DoubleClick;
        }

        private void ListAvailabilityDelete_DoubleClick(object sender, EventArgs e)
        {
            if (ListAvailabilityDelete.SelectedItem is Movies selectedAvailability)
            {
                DialogResult result = MessageBox.Show(
                    $"Είστε σίγουροι ότι θέλετε να διαγράψετε τη διαθεσιμότητα '{selectedAvailability.Availability}'؟",
                    "Επιβεβαίωση Διαγραφής",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    availabilityManager.DeleteAvailability(selectedAvailability);
                    RefreshAvailabilityListBox();
                }
            }
        }

        private void RefreshAvailabilityListBox()
        {
            ListAvailabilityDelete.DataSource = null; // Καθαρίστε την πηγή δεδομένων
            ListAvailabilityDelete.DataSource = availabilityManager.Availabilities;
            ListAvailabilityDelete.DisplayMember = "Availability";
        }

        private void FrmDeleteAvailability_Load(object sender, EventArgs e)
        {

        }
    }
}
