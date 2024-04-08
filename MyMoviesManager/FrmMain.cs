using MyMoviesManager.Models;

namespace MyMoviesManager
{
    public partial class FrmMain : Form
    {
        private FrmAddCategory frmAddCategory;
        private FrmAddMovie frmAddMovie;
        private CategoryManager categoryManager;
        private FrmRenameCategorie frmRenameCategorie;
        private AvailabilityManager availabilityManager;
        private FrmAddAvailability frmAddAvailability;
        public FrmMain()
        {
            InitializeComponent();
            categoryManager = FormInitializer.InitializeCategoryManager(); // Initialize categoryManager using FormInitializer
            frmRenameCategorie = new FrmRenameCategorie(Color.Brown);
            availabilityManager = AvailabilityFormInitializer.InitializeAvailabilityManager();

        }

        public static class AvailabilityFormInitializer
        {
            public static AvailabilityManager InitializeAvailabilityManager()
            {
                AvailabilityManager availabilityManager = AvailabilityManager.GetInstance();


                return availabilityManager;
            }
        }



        public static class FormInitializer
        {
            public static CategoryManager InitializeCategoryManager()
            {
                CategoryManager categoryManager = CategoryManager.GetInstance();


                return categoryManager;

            }
        }



        public void FrmMain_Load(object sender, EventArgs e)
        {
            frmAddCategory = new FrmAddCategory(Color.Brown, frmAddMovie);
            frmAddMovie = new FrmAddMovie(Color.Gold, frmAddCategory, new Movies());
            frmRenameCategorie = new FrmRenameCategorie(Color.Brown);
            frmAddAvailability = new FrmAddAvailability(Color.Ivory, frmAddMovie);
            frmRenameCategorie.CategoryRenamed += RefreshCategoryComboBoxes;

        }
        public void RefreshCategoryComboBoxes()
        {
            // Update category names in FrmRenameCategorie using the listbox
            FrmRenameCategorie renameCategoryForm = FrmRenameCategorie.Instance;

            if (renameCategoryForm != null)
            {
                renameCategoryForm.UpdateCategoryListBox(categoryManager.Categories);
            }
        }



        private void MnBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnBtnMovieProjection_Click(object sender, EventArgs e)
        {
            FrmMovieProjection frmMovieProjection = new FrmMovieProjection(Color.Olive);
            frmMovieProjection.MdiParent = this;
            frmMovieProjection.Show();
        }

        private void MnBtnAddMovie_Click(object sender, EventArgs e)
        {
            FrmAddMovie frmAddMovie = new FrmAddMovie(Color.Gold, frmAddCategory, new Movies()); // Pass an instance of Movies
            frmAddMovie.MdiParent = this;
            frmAddMovie.Show();
        }



        private void MnBtnMovieUpdate_Click(object sender, EventArgs e)
        {
            FrmMovieUpdateMain frmMovieUpdate = new FrmMovieUpdateMain(Color.Blue);
            frmMovieUpdate.MdiParent = this;
            frmMovieUpdate.Show();
        }

        private void MnBtnMovieDelete_Click(object sender, EventArgs e)
        {
            FrmMovieDelete frmMovieDelete = new FrmMovieDelete(Color.Black);
            frmMovieDelete.MdiParent = this;
            frmMovieDelete.Show();
        }


        private void MnBtnRecomendedMovie_Click(object sender, EventArgs e)
        {
            FrmRecomendedMovie frmRecomendedMovie = new FrmRecomendedMovie(Color.Salmon);
            frmRecomendedMovie.MdiParent = this;
            frmRecomendedMovie.Show();
        }


        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            // Create an instance of FrmAddCategory and pass the initialized frmAddMovie
            FrmAddCategory frmAddCategory = new FrmAddCategory(Color.Thistle, frmAddMovie);
            frmAddCategory.MdiParent = this;
            frmAddCategory.Show();
        }

        private void MnBtnRenameCategory_Click(object sender, EventArgs e)
        {
            FrmRenameCategorie frmRenameCategorie = new FrmRenameCategorie(Color.Brown);
            frmRenameCategorie.CategoryRenamed += RefreshCategoryComboBoxes;
            frmRenameCategorie.MdiParent = this;
            frmRenameCategorie.Show();
        }

        private void MnBtnDeleteCategory_Click(object sender, EventArgs e)
        {
            FrmDeleteCategory frmDeleteCategory = new FrmDeleteCategory(Color.MediumSeaGreen);
            frmDeleteCategory.MdiParent = this;
            frmDeleteCategory.Show();
        }

        private void MnBtnAddAvailabilty_Click(object sender, EventArgs e)
        {
            FrmAddAvailability frmAddAvailabilty = new FrmAddAvailability(Color.Ivory, frmAddMovie);
            frmAddAvailabilty.MdiParent = this;
            frmAddAvailabilty.Show();
        }

        private void MnbtnAvailabilityUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateAvailability frmUpdateAvailability = new FrmUpdateAvailability(availabilityManager, Color.LightGoldenrodYellow);
            frmUpdateAvailability.MdiParent = this;
            frmUpdateAvailability.Show();
        }

        private void MnBtnDeleteAvailability_Click(object sender, EventArgs e)
        {
            FrmDeleteAvailability frmDeleteAvailability = new FrmDeleteAvailability(Color.OrangeRed);
            frmDeleteAvailability.MdiParent = this;
            frmDeleteAvailability.Show();

        }
    }
}