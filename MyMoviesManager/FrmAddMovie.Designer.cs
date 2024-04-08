namespace MyMoviesManager
{
    partial class FrmAddMovie
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
            label1 = new Label();
            TxtTitle = new TextBox();
            label2 = new Label();
            MovieRealeseDatepicker = new DateTimePicker();
            label3 = new Label();
            TxtActors = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CmbMovieCategories = new ComboBox();
            label6 = new Label();
            AvailabilityListBox = new ListBox();
            label7 = new Label();
            TxtImdbRatting = new TextBox();
            PboxMovieCreation = new PictureBox();
            RButtonNotSeen = new RadioButton();
            RbutttonSeenMovie = new RadioButton();
            LblSawDate = new Label();
            SawDatePicker = new DateTimePicker();
            BtnSaveMovie = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)PboxMovieCreation).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Τίτλος";
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(53, 39);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(269, 27);
            TxtTitle.TabIndex = 1;
            TxtTitle.TextChanged += TxtTitle_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 80);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 2;
            label2.Text = "Ημερομηνια κυκλοφοριας";
            // 
            // MovieRealeseDatepicker
            // 
            MovieRealeseDatepicker.Format = DateTimePickerFormat.Short;
            MovieRealeseDatepicker.Location = new Point(53, 112);
            MovieRealeseDatepicker.Name = "MovieRealeseDatepicker";
            MovieRealeseDatepicker.ShowUpDown = true;
            MovieRealeseDatepicker.Size = new Size(269, 27);
            MovieRealeseDatepicker.TabIndex = 3;
            MovieRealeseDatepicker.Value = new DateTime(2023, 10, 8, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 157);
            label3.Name = "label3";
            label3.Size = new Size(302, 20);
            label3.TabIndex = 4;
            label3.Text = "Πρωταγωνιστές (διαχωρισμένοι με κόμμα)";
            // 
            // TxtActors
            // 
            TxtActors.Location = new Point(53, 189);
            TxtActors.Name = "TxtActors";
            TxtActors.Size = new Size(269, 27);
            TxtActors.TabIndex = 5;
            TxtActors.TextChanged += TxtActors_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 229);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 229);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 7;
            label5.Text = "Επιλέξτε Κατηγορία";
            // 
            // CmbMovieCategories
            // 
            CmbMovieCategories.AccessibleRole = AccessibleRole.None;
            CmbMovieCategories.AutoCompleteCustomSource.AddRange(new string[] { " string categoryToAdd" });
            CmbMovieCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMovieCategories.FormattingEnabled = true;
            CmbMovieCategories.Location = new Point(90, 264);
            CmbMovieCategories.Name = "CmbMovieCategories";
            CmbMovieCategories.Size = new Size(151, 28);
            CmbMovieCategories.TabIndex = 8;
            CmbMovieCategories.SelectedIndexChanged += CmbMovieCategories_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 28);
            label6.Name = "label6";
            label6.Size = new Size(335, 20);
            label6.TabIndex = 9;
            label6.Text = "Διαθεσιμη Σε (δυνατότητα πολλαπλής επιλογής)";
            // 
            // AvailabilityListBox
            // 
            AvailabilityListBox.FormattingEnabled = true;
            AvailabilityListBox.ItemHeight = 20;
            AvailabilityListBox.Location = new Point(508, 80);
            AvailabilityListBox.Name = "AvailabilityListBox";
            AvailabilityListBox.SelectionMode = SelectionMode.MultiSimple;
            AvailabilityListBox.Size = new Size(206, 104);
            AvailabilityListBox.TabIndex = 10;
            AvailabilityListBox.SelectedIndexChanged += AvailabilityListBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(812, 80);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 11;
            label7.Text = "Βαθμολογία IMDB";
            // 
            // TxtImdbRatting
            // 
            TxtImdbRatting.Location = new Point(819, 138);
            TxtImdbRatting.Name = "TxtImdbRatting";
            TxtImdbRatting.Size = new Size(125, 27);
            TxtImdbRatting.TabIndex = 14;
            TxtImdbRatting.TextChanged += TxtImdbRatting_TextChanged;
            // 
            // PboxMovieCreation
            // 
            PboxMovieCreation.BackColor = Color.FromArgb(128, 64, 64);
            PboxMovieCreation.Location = new Point(684, 355);
            PboxMovieCreation.Name = "PboxMovieCreation";
            PboxMovieCreation.Size = new Size(400, 300);
            PboxMovieCreation.SizeMode = PictureBoxSizeMode.AutoSize;
            PboxMovieCreation.TabIndex = 15;
            PboxMovieCreation.TabStop = false;
            PboxMovieCreation.Click += PboxMovieCreation_Click;
            // 
            // RButtonNotSeen
            // 
            RButtonNotSeen.AutoSize = true;
            RButtonNotSeen.Location = new Point(292, 432);
            RButtonNotSeen.Name = "RButtonNotSeen";
            RButtonNotSeen.Size = new Size(137, 24);
            RButtonNotSeen.TabIndex = 16;
            RButtonNotSeen.Text = "δεν την έχω δεί";
            RButtonNotSeen.UseVisualStyleBackColor = true;
            // 
            // RbutttonSeenMovie
            // 
            RbutttonSeenMovie.AutoSize = true;
            RbutttonSeenMovie.Checked = true;
            RbutttonSeenMovie.Location = new Point(292, 379);
            RbutttonSeenMovie.Name = "RbutttonSeenMovie";
            RbutttonSeenMovie.Size = new Size(109, 24);
            RbutttonSeenMovie.TabIndex = 17;
            RbutttonSeenMovie.TabStop = true;
            RbutttonSeenMovie.Text = "την εχω δει";
            RbutttonSeenMovie.UseVisualStyleBackColor = true;
            RbutttonSeenMovie.CheckedChanged += RbutttonSeenMovie_CheckedChanged;
            // 
            // LblSawDate
            // 
            LblSawDate.AutoSize = true;
            LblSawDate.Location = new Point(283, 500);
            LblSawDate.Name = "LblSawDate";
            LblSawDate.Size = new Size(184, 20);
            LblSawDate.TabIndex = 18;
            LblSawDate.Text = "Ημερομηνια που την ειδα";
            // 
            // SawDatePicker
            // 
            SawDatePicker.Format = DateTimePickerFormat.Short;
            SawDatePicker.Location = new Point(259, 533);
            SawDatePicker.Name = "SawDatePicker";
            SawDatePicker.Size = new Size(250, 27);
            SawDatePicker.TabIndex = 19;
            // 
            // BtnSaveMovie
            // 
            BtnSaveMovie.Location = new Point(838, 204);
            BtnSaveMovie.Name = "BtnSaveMovie";
            BtnSaveMovie.Size = new Size(106, 45);
            BtnSaveMovie.TabIndex = 20;
            BtnSaveMovie.Text = "Αποθηκευση ";
            BtnSaveMovie.UseVisualStyleBackColor = true;
            BtnSaveMovie.Click += BtnSaveMovie_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(812, 316);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 21;
            label8.Text = "εισαγετε εικονα";
            // 
            // FrmAddMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 691);
            Controls.Add(label8);
            Controls.Add(BtnSaveMovie);
            Controls.Add(SawDatePicker);
            Controls.Add(LblSawDate);
            Controls.Add(RbutttonSeenMovie);
            Controls.Add(RButtonNotSeen);
            Controls.Add(PboxMovieCreation);
            Controls.Add(TxtImdbRatting);
            Controls.Add(label7);
            Controls.Add(AvailabilityListBox);
            Controls.Add(label6);
            Controls.Add(CmbMovieCategories);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtActors);
            Controls.Add(label3);
            Controls.Add(MovieRealeseDatepicker);
            Controls.Add(label2);
            Controls.Add(TxtTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAddMovie";
            Text = "Προσθήκη Ταινίας";
            Load += FrmAddMovie_Load;
            ((System.ComponentModel.ISupportInitialize)PboxMovieCreation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtTitle;
        private Label label2;
        private DateTimePicker MovieRealeseDatepicker;
        private Label label3;
        private TextBox TxtActors;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox AvailabilityListBox;
        private Label label7;
        private TextBox TxtImdbRatting;
        private PictureBox PboxMovieCreation;
        private RadioButton RButtonNotSeen;
        private RadioButton RbutttonSeenMovie;
        private Label LblSawDate;
        private DateTimePicker SawDatePicker;
        private Button BtnSaveMovie;
        private Label label8;
        public ComboBox CmbMovieCategories;
    }
}