using MyMoviesManager.Models;
using System;
using System.Windows.Forms;
using static MyMoviesManager.FrmMain;

namespace MyMoviesManager
{
    public partial class FrmRenameCategorie : Form
    {
        public CategoryManager categoryManager;
        public event Action CategoryRenamed;
        public static FrmRenameCategorie Instance { get; } = new FrmRenameCategorie(Color.Brown);

        public FrmRenameCategorie(Color TheColor)
        {
            InitializeComponent();
            this.BackColor = TheColor;
            categoryManager = FrmMain.FormInitializer.InitializeCategoryManager();

            LstBoxRenameCategorie.DataSource = categoryManager.Categories;
            LstBoxRenameCategorie.DisplayMember = "Category";
            LstBoxRenameCategorie.SelectedIndexChanged += LstBoxRenameCategorie_SelectedIndexChanged;
        }

        private void RenameCategory()
        {
            if (LstBoxRenameCategorie.SelectedItem is Movies selectedCategory)
            {
                string newCategoryName = TxtCategoryRename.Text.Trim();

                if (string.IsNullOrEmpty(newCategoryName))
                {
                    MessageBox.Show("Το όνομα της νέας κατηγορίας δεν μπορεί να είναι κενό.");
                    return;
                }

                if (newCategoryName.Equals(selectedCategory.Category))
                {
                    MessageBox.Show("Το νέο όνομα πρέπει να διαφέρει από το τρέχον όνομα.");
                    return;
                }

                categoryManager.UpdateCategoryName(selectedCategory, newCategoryName);

                // Ενημερώστε ότι μια κατηγορία έχει μετονομαστεί
                CategoryRenamed?.Invoke();

                TxtCategoryRename.Clear();
            }
        }

        public void UpdateCategoryListBox(List<Movies> categories)
        {
            LstBoxRenameCategorie.DataSource = null; // Καθαρίστε την πηγή δεδομένων
            LstBoxRenameCategorie.DataSource = categories;
            LstBoxRenameCategorie.DisplayMember = "Category";
        }

        public void LstBoxRenameCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCategoryListBox(categoryManager.Categories);
        }

        public void BtnCategorieRename_Click(object sender, EventArgs e)
        {
            RenameCategory();
            UpdateCategoryListBox(categoryManager.Categories);
        }
    }
}
