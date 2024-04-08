namespace MyMoviesManager
{
    partial class FrmRecomendedMovie
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
            TxtIMdbRateRecommended = new TextBox();
            label7 = new Label();
            PictureBoxMovieRecommended = new PictureBox();
            label6 = new Label();
            ListViewAvailabilityRecommended = new ListView();
            label5 = new Label();
            label4 = new Label();
            TxtCategoryRecommended = new TextBox();
            label3 = new Label();
            listViewActorsRecommended = new ListView();
            label2 = new Label();
            TxtRecomendedRealeaseDate = new TextBox();
            Label1 = new Label();
            TxtTitleRecomendedMovie = new TextBox();
            TxtBoxSeenMovieRecommended = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMovieRecommended).BeginInit();
            SuspendLayout();
            // 
            // TxtIMdbRateRecommended
            // 
            TxtIMdbRateRecommended.Location = new Point(470, 174);
            TxtIMdbRateRecommended.Name = "TxtIMdbRateRecommended";
            TxtIMdbRateRecommended.ReadOnly = true;
            TxtIMdbRateRecommended.Size = new Size(205, 27);
            TxtIMdbRateRecommended.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(501, 140);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 27;
            label7.Text = "IMDB Βαθμολογία";
            // 
            // PictureBoxMovieRecommended
            // 
            PictureBoxMovieRecommended.Enabled = false;
            PictureBoxMovieRecommended.Location = new Point(691, 355);
            PictureBoxMovieRecommended.Name = "PictureBoxMovieRecommended";
            PictureBoxMovieRecommended.Size = new Size(344, 268);
            PictureBoxMovieRecommended.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxMovieRecommended.TabIndex = 26;
            PictureBoxMovieRecommended.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 584);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 25;
            label6.Text = "Την έχω δει";
            // 
            // ListViewAvailabilityRecommended
            // 
            ListViewAvailabilityRecommended.Enabled = false;
            ListViewAvailabilityRecommended.Location = new Point(704, 140);
            ListViewAvailabilityRecommended.Name = "ListViewAvailabilityRecommended";
            ListViewAvailabilityRecommended.Size = new Size(304, 167);
            ListViewAvailabilityRecommended.TabIndex = 24;
            ListViewAvailabilityRecommended.UseCompatibleStateImageBehavior = false;
            ListViewAvailabilityRecommended.View = View.List;
            ListViewAvailabilityRecommended.SelectedIndexChanged += ListViewAvailabilityRecommended_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(824, 94);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 23;
            label5.Text = "Διαθέσιμη σε";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 238);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 22;
            label4.Text = "Κατηγορία ";
            // 
            // TxtCategoryRecommended
            // 
            TxtCategoryRecommended.Location = new Point(153, 280);
            TxtCategoryRecommended.Name = "TxtCategoryRecommended";
            TxtCategoryRecommended.ReadOnly = true;
            TxtCategoryRecommended.Size = new Size(205, 27);
            TxtCategoryRecommended.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 345);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 20;
            label3.Text = "Πρωταγωνιστές ";
            // 
            // listViewActorsRecommended
            // 
            listViewActorsRecommended.Enabled = false;
            listViewActorsRecommended.Location = new Point(84, 392);
            listViewActorsRecommended.Name = "listViewActorsRecommended";
            listViewActorsRecommended.Size = new Size(322, 172);
            listViewActorsRecommended.TabIndex = 19;
            listViewActorsRecommended.UseCompatibleStateImageBehavior = false;
            listViewActorsRecommended.View = View.List;
            listViewActorsRecommended.SelectedIndexChanged += listViewActorsRecommended_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 140);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 18;
            label2.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // TxtRecomendedRealeaseDate
            // 
            TxtRecomendedRealeaseDate.Location = new Point(153, 174);
            TxtRecomendedRealeaseDate.Name = "TxtRecomendedRealeaseDate";
            TxtRecomendedRealeaseDate.ReadOnly = true;
            TxtRecomendedRealeaseDate.Size = new Size(205, 27);
            TxtRecomendedRealeaseDate.TabIndex = 17;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(220, 57);
            Label1.Name = "Label1";
            Label1.Size = new Size(51, 20);
            Label1.TabIndex = 16;
            Label1.Text = "Τίτλος";
            // 
            // TxtTitleRecomendedMovie
            // 
            TxtTitleRecomendedMovie.Location = new Point(153, 91);
            TxtTitleRecomendedMovie.Name = "TxtTitleRecomendedMovie";
            TxtTitleRecomendedMovie.ReadOnly = true;
            TxtTitleRecomendedMovie.Size = new Size(205, 27);
            TxtTitleRecomendedMovie.TabIndex = 15;
            // 
            // TxtBoxSeenMovieRecommended
            // 
            TxtBoxSeenMovieRecommended.Location = new Point(142, 631);
            TxtBoxSeenMovieRecommended.Name = "TxtBoxSeenMovieRecommended";
            TxtBoxSeenMovieRecommended.ReadOnly = true;
            TxtBoxSeenMovieRecommended.Size = new Size(197, 27);
            TxtBoxSeenMovieRecommended.TabIndex = 29;
            // 
            // FrmRecomendedMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 708);
            Controls.Add(TxtBoxSeenMovieRecommended);
            Controls.Add(TxtIMdbRateRecommended);
            Controls.Add(label7);
            Controls.Add(PictureBoxMovieRecommended);
            Controls.Add(label6);
            Controls.Add(ListViewAvailabilityRecommended);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtCategoryRecommended);
            Controls.Add(label3);
            Controls.Add(listViewActorsRecommended);
            Controls.Add(label2);
            Controls.Add(TxtRecomendedRealeaseDate);
            Controls.Add(Label1);
            Controls.Add(TxtTitleRecomendedMovie);
            Name = "FrmRecomendedMovie";
            Text = "Πρότεινόμενη Ταινια";
            ((System.ComponentModel.ISupportInitialize)PictureBoxMovieRecommended).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIMdbRateRecommended;
        private Label label7;
        private PictureBox PictureBoxMovieRecommended;
        private Label label6;
        private ListView ListViewAvailabilityRecommended;
        private Label label5;
        private Label label4;
        private TextBox TxtCategoryRecommended;
        private Label label3;
        private ListView listViewActorsRecommended;
        private Label label2;
        private TextBox TxtRecomendedRealeaseDate;
        private Label Label1;
        private TextBox TxtTitleRecomendedMovie;
        private TextBox TxtBoxSeenMovieRecommended;
    }
}