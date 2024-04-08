namespace MyMoviesManager
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MnBtnMovies = new ToolStripMenuItem();
            MnBtnAddMovie = new ToolStripMenuItem();
            MnBtnMovieProjection = new ToolStripMenuItem();
            MnBtnMovieUpdate = new ToolStripMenuItem();
            MnBtnMovieDelete = new ToolStripMenuItem();
            MnBtnRecomendedMovie = new ToolStripMenuItem();
            MnBtnExit = new ToolStripMenuItem();
            BtnCategoryHandler = new ToolStripMenuItem();
            BtnAddCategory = new ToolStripMenuItem();
            MnBtnRenameCategory = new ToolStripMenuItem();
            MnBtnDeleteCategory = new ToolStripMenuItem();
            MnBtnAvailability = new ToolStripMenuItem();
            MnBtnAddAvailabilty = new ToolStripMenuItem();
            MnbtnAvailabilityUpdate = new ToolStripMenuItem();
            MnBtnDeleteAvailability = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnBtnMovies, MnBtnRecomendedMovie, BtnCategoryHandler, MnBtnAvailability, MnBtnExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnBtnMovies
            // 
            MnBtnMovies.DropDownItems.AddRange(new ToolStripItem[] { MnBtnAddMovie, MnBtnMovieProjection, MnBtnMovieUpdate, MnBtnMovieDelete });
            MnBtnMovies.Name = "MnBtnMovies";
            MnBtnMovies.Size = new Size(70, 24);
            MnBtnMovies.Text = "Ταινιες";
            // 
            // MnBtnAddMovie
            // 
            MnBtnAddMovie.Name = "MnBtnAddMovie";
            MnBtnAddMovie.Size = new Size(224, 26);
            MnBtnAddMovie.Text = "Προσθήκη";
            MnBtnAddMovie.Click += MnBtnAddMovie_Click;
            // 
            // MnBtnMovieProjection
            // 
            MnBtnMovieProjection.Name = "MnBtnMovieProjection";
            MnBtnMovieProjection.Size = new Size(224, 26);
            MnBtnMovieProjection.Text = "Προβολή";
            MnBtnMovieProjection.Click += MnBtnMovieProjection_Click;
            // 
            // MnBtnMovieUpdate
            // 
            MnBtnMovieUpdate.Name = "MnBtnMovieUpdate";
            MnBtnMovieUpdate.Size = new Size(224, 26);
            MnBtnMovieUpdate.Text = "Επεξεργασία";
            MnBtnMovieUpdate.Click += MnBtnMovieUpdate_Click;
            // 
            // MnBtnMovieDelete
            // 
            MnBtnMovieDelete.Name = "MnBtnMovieDelete";
            MnBtnMovieDelete.Size = new Size(224, 26);
            MnBtnMovieDelete.Text = "Διαγραφή";
            MnBtnMovieDelete.Click += MnBtnMovieDelete_Click;
            // 
            // MnBtnRecomendedMovie
            // 
            MnBtnRecomendedMovie.Name = "MnBtnRecomendedMovie";
            MnBtnRecomendedMovie.Size = new Size(139, 24);
            MnBtnRecomendedMovie.Text = "Προταση Ταινιας";
            MnBtnRecomendedMovie.Click += MnBtnRecomendedMovie_Click;
            // 
            // MnBtnExit
            // 
            MnBtnExit.Name = "MnBtnExit";
            MnBtnExit.Size = new Size(73, 24);
            MnBtnExit.Text = "Έξοδος";
            MnBtnExit.Click += MnBtnExit_Click;
            // 
            // BtnCategoryHandler
            // 
            BtnCategoryHandler.DropDownItems.AddRange(new ToolStripItem[] { BtnAddCategory, MnBtnRenameCategory, MnBtnDeleteCategory });
            BtnCategoryHandler.Name = "BtnCategoryHandler";
            BtnCategoryHandler.Size = new Size(184, 24);
            BtnCategoryHandler.Text = "Διαχειριση Κατηγοριων";
            // 
            // BtnAddCategory
            // 
            BtnAddCategory.Name = "BtnAddCategory";
            BtnAddCategory.Size = new Size(268, 26);
            BtnAddCategory.Text = "Προσθηκη Κατηγορίας";
            BtnAddCategory.Click += BtnAddCategory_Click;
            // 
            // MnBtnRenameCategory
            // 
            MnBtnRenameCategory.Name = "MnBtnRenameCategory";
            MnBtnRenameCategory.Size = new Size(268, 26);
            MnBtnRenameCategory.Text = "Μετανομασια κατηγορίας";
            MnBtnRenameCategory.Click += MnBtnRenameCategory_Click;
            // 
            // MnBtnDeleteCategory
            // 
            MnBtnDeleteCategory.Name = "MnBtnDeleteCategory";
            MnBtnDeleteCategory.Size = new Size(268, 26);
            MnBtnDeleteCategory.Text = "Διαγραφη Κατηγοριας";
            MnBtnDeleteCategory.Click += MnBtnDeleteCategory_Click;
            // 
            // MnBtnAvailability
            // 
            MnBtnAvailability.DropDownItems.AddRange(new ToolStripItem[] { MnBtnAddAvailabilty, MnbtnAvailabilityUpdate, MnBtnDeleteAvailability });
            MnBtnAvailability.Name = "MnBtnAvailability";
            MnBtnAvailability.Size = new Size(222, 24);
            MnBtnAvailability.Text = "Διαχειριση Μέσων Προβολής";
            // 
            // MnBtnAddAvailabilty
            // 
            MnBtnAddAvailabilty.Name = "MnBtnAddAvailabilty";
            MnBtnAddAvailabilty.Size = new Size(178, 26);
            MnBtnAddAvailabilty.Text = "Προσθήκη";
            MnBtnAddAvailabilty.Click += MnBtnAddAvailabilty_Click;
            // 
            // MnbtnAvailabilityUpdate
            // 
            MnbtnAvailabilityUpdate.Name = "MnbtnAvailabilityUpdate";
            MnbtnAvailabilityUpdate.Size = new Size(178, 26);
            MnbtnAvailabilityUpdate.Text = "Επεξεργασια";
            MnbtnAvailabilityUpdate.Click += MnbtnAvailabilityUpdate_Click;
            // 
            // MnBtnDeleteAvailability
            // 
            MnBtnDeleteAvailability.Name = "MnBtnDeleteAvailability";
            MnBtnDeleteAvailability.Size = new Size(178, 26);
            MnBtnDeleteAvailability.Text = "Διαγραφη";
            MnBtnDeleteAvailability.Click += MnBtnDeleteAvailability_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Βιβλιοθήκη ταινιών";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MnBtnMovies;
        private ToolStripMenuItem MnBtnMovieProjection;
        private ToolStripMenuItem MnBtnAddMovie;
        private ToolStripMenuItem MnBtnMovieUpdate;
        private ToolStripMenuItem MnBtnMovieDelete;
        private ToolStripMenuItem MnBtnExit;
        private ToolStripMenuItem MnBtnRecomendedMovie;
        private ToolStripMenuItem BtnCategoryHandler;
        private ToolStripMenuItem BtnAddCategory;
        private ToolStripMenuItem MnBtnRenameCategory;
        private ToolStripMenuItem MnBtnDeleteCategory;
        private ToolStripMenuItem MnBtnAvailability;
        private ToolStripMenuItem MnBtnAddAvailabilty;
        private ToolStripMenuItem MnbtnAvailabilityUpdate;
        private ToolStripMenuItem MnBtnDeleteAvailability;
    }
}