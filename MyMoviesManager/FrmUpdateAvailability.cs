using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyMoviesManager.Models;

namespace MyMoviesManager
{
    public partial class FrmUpdateAvailability : Form
    {
        private AvailabilityManager availabilityManager;

        public FrmUpdateAvailability(AvailabilityManager manager, Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;
            availabilityManager = FrmMain.AvailabilityFormInitializer.InitializeAvailabilityManager();

            // Populate the ListBox with availabilities
            listAvailabilityUpdate.DataSource = availabilityManager.Availabilities;
            listAvailabilityUpdate.DisplayMember = "Availability";
        }

        private void BtnAvailabilityUpdate_Click(object sender, EventArgs e)
        {
            if (listAvailabilityUpdate.SelectedItem != null)
            {
                string newName = TxtAvailabilityUpdate.Text;
                Movies selectedAvailability = (Movies)listAvailabilityUpdate.SelectedItem;

                // Update the availability name
                availabilityManager.UpdateAvailabilityName(selectedAvailability, newName);

                // Refresh the ListBox to reflect the updated availability names
                listAvailabilityUpdate.DataSource = null;
                listAvailabilityUpdate.DataSource = availabilityManager.Availabilities;
                listAvailabilityUpdate.DisplayMember = "Availability";
            }
        }

        private void listAvailabilityUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
