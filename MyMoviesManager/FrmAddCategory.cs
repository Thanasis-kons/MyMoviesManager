using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using MyMoviesManager.Models;

namespace MyMoviesManager;
public partial class FrmAddCategory : Form
{
    private FrmAddMovie frmAddMovie;

    public FrmAddCategory(Color TheColor, FrmAddMovie addMovieForm)
    {
        InitializeComponent();
        this.BackColor = TheColor;
        frmAddMovie = addMovieForm;
    }

    private void BtnAddCategories_Click(object sender, EventArgs e)
    {
        string categoryToAdd = TxtAddCategorie.Text;

        // Check if the category already exists
        if (frmAddMovie != null)
        {
            if (frmAddMovie.CategoryExists(categoryToAdd))
            {
                MessageBox.Show("Η κατηγορία υπάρχει ήδη στη λίστα.");
            }
            else
            {
                // Call the method in FrmAddMovie to add the category
                frmAddMovie.AddCategoryToCategoriesSetter(categoryToAdd);

                // Add the category to the CategoryManager
                CategoryManager.GetInstance().AddCategory(new Movies { Category = categoryToAdd });

            }
        }

        // Clear the TxtAddCategorie textbox
        TxtAddCategorie.Clear();

        
    }

    

    private void FrmAddCategory_Load(object sender, EventArgs e)
    {
        
    }
}

   