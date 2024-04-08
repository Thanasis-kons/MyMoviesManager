namespace MyMoviesManager
{
    partial class FrmRenameCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenameCategorie));
            TxtCategoryRename = new TextBox();
            BtnCategorieRename = new Button();
            label1 = new Label();
            label2 = new Label();
            LstBoxRenameCategorie = new ListBox();
            SuspendLayout();
            // 
            // TxtCategoryRename
            // 
            resources.ApplyResources(TxtCategoryRename, "TxtCategoryRename");
            TxtCategoryRename.Name = "TxtCategoryRename";
            // 
            // BtnCategorieRename
            // 
            resources.ApplyResources(BtnCategorieRename, "BtnCategorieRename");
            BtnCategorieRename.Name = "BtnCategorieRename";
            BtnCategorieRename.UseVisualStyleBackColor = true;
            BtnCategorieRename.Click += BtnCategorieRename_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // LstBoxRenameCategorie
            // 
            LstBoxRenameCategorie.FormattingEnabled = true;
            resources.ApplyResources(LstBoxRenameCategorie, "LstBoxRenameCategorie");
            LstBoxRenameCategorie.Name = "LstBoxRenameCategorie";
            LstBoxRenameCategorie.SelectedIndexChanged += LstBoxRenameCategorie_SelectedIndexChanged;
            // 
            // FrmRenameCategorie
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LstBoxRenameCategorie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCategorieRename);
            Controls.Add(TxtCategoryRename);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRenameCategorie";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtCategoryRename;
        private Button BtnCategorieRename;
        private Label label1;
        private Label label2;
        private ListBox LstBoxRenameCategorie;
    }
}