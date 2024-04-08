namespace MyMoviesManager
{
    partial class FrmMovieUpdateMain
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
            dataGridViewUpdate = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdate).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUpdate
            // 
            dataGridViewUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUpdate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdate.Dock = DockStyle.Fill;
            dataGridViewUpdate.Location = new Point(0, 0);
            dataGridViewUpdate.Name = "dataGridViewUpdate";
            dataGridViewUpdate.ReadOnly = true;
            dataGridViewUpdate.RowHeadersWidth = 51;
            dataGridViewUpdate.RowTemplate.Height = 29;
            dataGridViewUpdate.Size = new Size(800, 450);
            dataGridViewUpdate.TabIndex = 0;
            // 
            // FrmMovieUpdateMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewUpdate);
            Name = "FrmMovieUpdateMain";
            Text = "Επιλέξτε ταινια για επεξεργασια (διπλο κλικ)";
            Load += FrmMovieUpdateMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUpdate;
    }
}