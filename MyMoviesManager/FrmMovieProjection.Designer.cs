namespace MyMoviesManager
{
    partial class FrmMovieProjection
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
            LblTotalMovies = new Label();
            LblMovieCount = new Label();
            dataGridViewMovies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // LblTotalMovies
            // 
            LblTotalMovies.AutoSize = true;
            LblTotalMovies.Location = new Point(12, 421);
            LblTotalMovies.Name = "LblTotalMovies";
            LblTotalMovies.Size = new Size(0, 20);
            LblTotalMovies.TabIndex = 1;
            // 
            // LblMovieCount
            // 
            LblMovieCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblMovieCount.AutoSize = true;
            LblMovieCount.Location = new Point(12, 736);
            LblMovieCount.Name = "LblMovieCount";
            LblMovieCount.Size = new Size(114, 20);
            LblMovieCount.TabIndex = 2;
            LblMovieCount.Text = "Συνολο ταινιων";
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Dock = DockStyle.Top;
            dataGridViewMovies.Location = new Point(0, 0);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.ReadOnly = true;
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.RowTemplate.Height = 29;
            dataGridViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMovies.Size = new Size(1817, 733);
            dataGridViewMovies.TabIndex = 3;
            dataGridViewMovies.CellContentDoubleClick += dataGridViewMovies_CellDoubleClick;
            // 
            // FrmMovieProjection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1817, 765);
            Controls.Add(dataGridViewMovies);
            Controls.Add(LblMovieCount);
            Controls.Add(LblTotalMovies);
            Name = "FrmMovieProjection";
            Text = "Προβολη Ταινιων (καντε διπλο κλικ ανα ταίνια για Λεπτομερειες)";
            Load += FrmMovieProjection_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTotalMovies;
        private Label LblMovieCount;
        private DataGridView dataGridViewMovies;
    }
}