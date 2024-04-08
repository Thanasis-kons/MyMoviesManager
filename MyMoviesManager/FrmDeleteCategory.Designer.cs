namespace MyMoviesManager
{
    partial class FrmDeleteCategory
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
            LstBoxDeleteCategory = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LstBoxDeleteCategory
            // 
            LstBoxDeleteCategory.FormattingEnabled = true;
            LstBoxDeleteCategory.ItemHeight = 20;
            LstBoxDeleteCategory.Location = new Point(375, 213);
            LstBoxDeleteCategory.Name = "LstBoxDeleteCategory";
            LstBoxDeleteCategory.Size = new Size(288, 204);
            LstBoxDeleteCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 149);
            label1.Name = "label1";
            label1.Size = new Size(301, 20);
            label1.TabIndex = 1;
            label1.Text = "Καντε διπλο κλικ για διαγραφη κατηγοριας";
            // 
            // FrmDeleteCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 606);
            Controls.Add(label1);
            Controls.Add(LstBoxDeleteCategory);
            Name = "FrmDeleteCategory";
            Text = "FrmDeleteCategory";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstBoxDeleteCategory;
        private Label label1;
    }
}