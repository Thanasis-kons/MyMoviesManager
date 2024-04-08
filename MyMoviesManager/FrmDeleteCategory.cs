using System;
using System.Windows.Forms;
using System.Drawing;
using MyMoviesManager.Models;

namespace MyMoviesManager
{
    public partial class FrmDeleteCategory : Form
    {
        private CategoryManager categoryManager;

        public FrmDeleteCategory(Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;
            categoryManager = CategoryManager.GetInstance();

            RefreshCategoryListBox(); 

            LstBoxDeleteCategory.DoubleClick += LstBoxDeleteCategory_DoubleClick;
        }

        private void LstBoxDeleteCategory_DoubleClick(object sender, EventArgs e)
        {
            if (LstBoxDeleteCategory.SelectedItem is Movies selectedCategory)
            {
                DialogResult result = MessageBox.Show(
                    $"Είστε σίγουροι ότι θέλετε να διαγράψετε την κατηγορία '{selectedCategory.Category}'؟",
                    "Επιβεβαίωση Διαγραφής",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    categoryManager.DeleteCategory(selectedCategory);
                    RefreshCategoryListBox();
                }
            }
        }

        private void RefreshCategoryListBox()
        {
            LstBoxDeleteCategory.DataSource = null; // Καθαρίστε την πηγή δεδομένων
            LstBoxDeleteCategory.DataSource = categoryManager.Categories;
            LstBoxDeleteCategory.DisplayMember = "Category";
        }
    }
}
