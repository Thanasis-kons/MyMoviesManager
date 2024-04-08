namespace MyMoviesManager
{
    partial class FrmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCategory));
            label1 = new Label();
            BtnAddCategories = new Button();
            TxtAddCategorie = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // BtnAddCategories
            // 
            resources.ApplyResources(BtnAddCategories, "BtnAddCategories");
            BtnAddCategories.Name = "BtnAddCategories";
            BtnAddCategories.UseVisualStyleBackColor = true;
            BtnAddCategories.Click += BtnAddCategories_Click;
            // 
            // TxtAddCategorie
            // 
            resources.ApplyResources(TxtAddCategorie, "TxtAddCategorie");
            TxtAddCategorie.Name = "TxtAddCategorie";
           
            // 
            // FrmAddCategory
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TxtAddCategorie);
            Controls.Add(BtnAddCategories);
            Controls.Add(label1);
            Name = "FrmAddCategory";
            WindowState = FormWindowState.Maximized;
            Load += FrmAddCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAddCategories;
        private TextBox TxtAddCategorie;
    }
}