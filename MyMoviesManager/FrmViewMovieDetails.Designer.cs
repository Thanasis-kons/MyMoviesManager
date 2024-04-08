namespace MyMoviesManager
{
    partial class FrmViewMovieDetails
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
            TxtTitleMovieView = new TextBox();
            Label1 = new Label();
            TxtReleaseDateView = new TextBox();
            label2 = new Label();
            listViewActors = new ListView();
            label3 = new Label();
            TxtCategoryView = new TextBox();
            label4 = new Label();
            label5 = new Label();
            listViewAvailabilityView = new ListView();
            TxtBoxSeenMovieView = new TextBox();
            label6 = new Label();
            PictureBoxMovieView = new PictureBox();
            label7 = new Label();
            TxtIMdbRateView = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMovieView).BeginInit();
            SuspendLayout();
            // 
            // TxtTitleMovieView
            // 
            TxtTitleMovieView.Location = new Point(791, 147);
            TxtTitleMovieView.Name = "TxtTitleMovieView";
            TxtTitleMovieView.ReadOnly = true;
            TxtTitleMovieView.Size = new Size(205, 27);
            TxtTitleMovieView.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(842, 97);
            Label1.Name = "Label1";
            Label1.Size = new Size(51, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Τίτλος";
            // 
            // TxtReleaseDateView
            // 
            TxtReleaseDateView.Location = new Point(571, 320);
            TxtReleaseDateView.Name = "TxtReleaseDateView";
            TxtReleaseDateView.ReadOnly = true;
            TxtReleaseDateView.Size = new Size(205, 27);
            TxtReleaseDateView.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 280);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 3;
            label2.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // listViewActors
            // 
            listViewActors.Enabled = false;
            listViewActors.Location = new Point(281, 423);
            listViewActors.Name = "listViewActors";
            listViewActors.Size = new Size(322, 172);
            listViewActors.TabIndex = 4;
            listViewActors.UseCompatibleStateImageBehavior = false;
            listViewActors.View = View.List;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 385);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Πρωταγωνιστές ";
            // 
            // TxtCategoryView
            // 
            TxtCategoryView.Location = new Point(599, 236);
            TxtCategoryView.Name = "TxtCategoryView";
            TxtCategoryView.ReadOnly = true;
            TxtCategoryView.Size = new Size(205, 27);
            TxtCategoryView.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 213);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 7;
            label4.Text = "Κατηγορία ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(736, 376);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 8;
            label5.Text = "Διαθέσιμη σε";
            // 
            // listViewAvailabilityView
            // 
            listViewAvailabilityView.Enabled = false;
            listViewAvailabilityView.Location = new Point(664, 428);
            listViewAvailabilityView.Name = "listViewAvailabilityView";
            listViewAvailabilityView.Size = new Size(304, 167);
            listViewAvailabilityView.TabIndex = 9;
            listViewAvailabilityView.UseCompatibleStateImageBehavior = false;
            listViewAvailabilityView.View = View.List;
            // 
            // TxtBoxSeenMovieView
            // 
            TxtBoxSeenMovieView.Location = new Point(1070, 248);
            TxtBoxSeenMovieView.Name = "TxtBoxSeenMovieView";
            TxtBoxSeenMovieView.ReadOnly = true;
            TxtBoxSeenMovieView.Size = new Size(197, 27);
            TxtBoxSeenMovieView.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1116, 213);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 11;
            label6.Text = "Την έχω δει";
            // 
            // PictureBoxMovieView
            // 
            PictureBoxMovieView.Enabled = false;
            PictureBoxMovieView.Location = new Point(1009, 481);
            PictureBoxMovieView.Name = "PictureBoxMovieView";
            PictureBoxMovieView.Size = new Size(344, 268);
            PictureBoxMovieView.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxMovieView.TabIndex = 12;
            PictureBoxMovieView.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1092, 323);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 13;
            label7.Text = "IMDB Βαθμολογία";
            // 
            // TxtIMdbRateView
            // 
            TxtIMdbRateView.Location = new Point(1062, 373);
            TxtIMdbRateView.Name = "TxtIMdbRateView";
            TxtIMdbRateView.ReadOnly = true;
            TxtIMdbRateView.Size = new Size(205, 27);
            TxtIMdbRateView.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(599, 614);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 16;
            label8.Text = "Περιληψη";
            // 
            // FrmViewMovieDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 770);
            Controls.Add(label8);
            Controls.Add(TxtIMdbRateView);
            Controls.Add(label7);
            Controls.Add(PictureBoxMovieView);
            Controls.Add(label6);
            Controls.Add(TxtBoxSeenMovieView);
            Controls.Add(listViewAvailabilityView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtCategoryView);
            Controls.Add(label3);
            Controls.Add(listViewActors);
            Controls.Add(label2);
            Controls.Add(TxtReleaseDateView);
            Controls.Add(Label1);
            Controls.Add(TxtTitleMovieView);
            Name = "FrmViewMovieDetails";
            Text = "Παρουσιαση ταινιας";
            ((System.ComponentModel.ISupportInitialize)PictureBoxMovieView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTitleMovieView;
        private Label Label1;
        private TextBox TxtReleaseDateView;
        private Label label2;
        private ListView listViewActors;
        private Label label3;
        private TextBox TxtCategoryView;
        private Label label4;
        private Label label5;
        private ListView listViewAvailabilityView;
        private TextBox TxtBoxSeenMovieView;
        private Label label6;
        private PictureBox PictureBoxMovieView;
        private Label label7;
        private TextBox TxtIMdbRateView;
        private Label label8;
    }
}