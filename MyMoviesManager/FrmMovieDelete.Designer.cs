namespace MyMoviesManager
{
    partial class FrmMovieDelete
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
            DtGrMovieDelete = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DtGrMovieDelete).BeginInit();
            SuspendLayout();
            // 
            // DtGrMovieDelete
            // 
            DtGrMovieDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGrMovieDelete.Dock = DockStyle.Fill;
            DtGrMovieDelete.Location = new Point(0, 0);
            DtGrMovieDelete.Name = "DtGrMovieDelete";
            DtGrMovieDelete.ReadOnly = true;
            DtGrMovieDelete.RowHeadersWidth = 51;
            DtGrMovieDelete.RowTemplate.Height = 29;
            DtGrMovieDelete.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtGrMovieDelete.Size = new Size(800, 430);
            DtGrMovieDelete.TabIndex = 2;
            DtGrMovieDelete.CellClick += DtGrMovieDelete_CellDoubleClick;
            // 
            // FrmMovieDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(DtGrMovieDelete);
            Name = "FrmMovieDelete";
            Text = "Διαγραφη Ταινίων (διπλο κλικ για διαγραφη) ";
            Load += FrmMovieDelete_Load;
            ((System.ComponentModel.ISupportInitialize)DtGrMovieDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DtGrMovieDelete;
    }
}