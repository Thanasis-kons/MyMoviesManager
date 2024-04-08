namespace MyMoviesManager
{
    partial class MovieUpdateChild
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
            PboxMovieCreationUpdate = new PictureBox();
            AvailabilityListBoxUpdate = new ListBox();
            label6 = new Label();
            CmbMovieCategoriesUpdate = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            TxtActorsupdate = new TextBox();
            label3 = new Label();
            MovieRealeseDatepickerUpdate = new DateTimePicker();
            label2 = new Label();
            TxtTitleUpdate = new TextBox();
            label1 = new Label();
            BtnUpdateMovie = new Button();
            SawDatePickerUpdate = new DateTimePicker();
            LblSawDateUpdate = new Label();
            RbutttonSeenMovieUpdate = new RadioButton();
            RButtonNotSeenUpdate = new RadioButton();
            TxtImdbRattingUpdate = new TextBox();
            label7 = new Label();
            ListBoxActors = new ListBox();
            BtnActorsAdd = new Button();
            BtnRemoveActors = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)PboxMovieCreationUpdate).BeginInit();
            SuspendLayout();
            // 
            // PboxMovieCreationUpdate
            // 
            PboxMovieCreationUpdate.BackColor = Color.FromArgb(128, 64, 64);
            PboxMovieCreationUpdate.Location = new Point(809, 319);
            PboxMovieCreationUpdate.Name = "PboxMovieCreationUpdate";
            PboxMovieCreationUpdate.Size = new Size(300, 300);
            PboxMovieCreationUpdate.SizeMode = PictureBoxSizeMode.AutoSize;
            PboxMovieCreationUpdate.TabIndex = 27;
            PboxMovieCreationUpdate.TabStop = false;
            PboxMovieCreationUpdate.Click += PboxMovieCreationUpdate_Click;
            // 
            // AvailabilityListBoxUpdate
            // 
            AvailabilityListBoxUpdate.FormattingEnabled = true;
            AvailabilityListBoxUpdate.ItemHeight = 20;
            AvailabilityListBoxUpdate.Location = new Point(487, 134);
            AvailabilityListBoxUpdate.Name = "AvailabilityListBoxUpdate";
            AvailabilityListBoxUpdate.SelectionMode = SelectionMode.MultiSimple;
            AvailabilityListBoxUpdate.Size = new Size(206, 104);
            AvailabilityListBoxUpdate.TabIndex = 26;
            AvailabilityListBoxUpdate.SelectedIndexChanged += AvailabilityListBoxUpdate_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 82);
            label6.Name = "label6";
            label6.Size = new Size(335, 20);
            label6.TabIndex = 25;
            label6.Text = "Διαθεσιμη Σε (δυνατότητα πολλαπλής επιλογής)";
            // 
            // CmbMovieCategoriesUpdate
            // 
            CmbMovieCategoriesUpdate.FormattingEnabled = true;
            CmbMovieCategoriesUpdate.Location = new Point(61, 266);
            CmbMovieCategoriesUpdate.Name = "CmbMovieCategoriesUpdate";
            CmbMovieCategoriesUpdate.Size = new Size(151, 28);
            CmbMovieCategoriesUpdate.TabIndex = 24;
            CmbMovieCategoriesUpdate.SelectedIndexChanged += CmbMovieCategoriesUpdate_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 216);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 23;
            label5.Text = "Επιλέξτε Κατηγορία";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 284);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 22;
            // 
            // TxtActorsupdate
            // 
            TxtActorsupdate.Location = new Point(29, 408);
            TxtActorsupdate.Name = "TxtActorsupdate";
            TxtActorsupdate.Size = new Size(321, 27);
            TxtActorsupdate.TabIndex = 21;
            TxtActorsupdate.TextChanged += TxtActorsupdate_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 367);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 20;
            label3.Text = "Πρωταγωνιστές (Προσθεστε)";
            // 
            // MovieRealeseDatepickerUpdate
            // 
            MovieRealeseDatepickerUpdate.Format = DateTimePickerFormat.Short;
            MovieRealeseDatepickerUpdate.Location = new Point(24, 166);
            MovieRealeseDatepickerUpdate.Name = "MovieRealeseDatepickerUpdate";
            MovieRealeseDatepickerUpdate.ShowUpDown = true;
            MovieRealeseDatepickerUpdate.Size = new Size(269, 27);
            MovieRealeseDatepickerUpdate.TabIndex = 19;
            MovieRealeseDatepickerUpdate.Value = new DateTime(2023, 10, 8, 0, 0, 0, 0);
            MovieRealeseDatepickerUpdate.ValueChanged += MovieRealeseDatepickerUpdate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 134);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 18;
            label2.Text = "Ημερομηνια κυκλοφοριας";
            // 
            // TxtTitleUpdate
            // 
            TxtTitleUpdate.Location = new Point(24, 93);
            TxtTitleUpdate.Name = "TxtTitleUpdate";
            TxtTitleUpdate.Size = new Size(269, 27);
            TxtTitleUpdate.TabIndex = 17;
            TxtTitleUpdate.TextChanged += TxtTitleUpdate_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 70);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 16;
            label1.Text = "Τίτλος";
            // 
            // BtnUpdateMovie
            // 
            BtnUpdateMovie.Location = new Point(1049, 203);
            BtnUpdateMovie.Name = "BtnUpdateMovie";
            BtnUpdateMovie.Size = new Size(106, 46);
            BtnUpdateMovie.TabIndex = 34;
            BtnUpdateMovie.Text = "Αποθηκευση ";
            BtnUpdateMovie.UseVisualStyleBackColor = true;
            BtnUpdateMovie.Click += BtnUpdateMovie_Click;
            // 
            // SawDatePickerUpdate
            // 
            SawDatePickerUpdate.Format = DateTimePickerFormat.Short;
            SawDatePickerUpdate.Location = new Point(731, 222);
            SawDatePickerUpdate.Name = "SawDatePickerUpdate";
            SawDatePickerUpdate.Size = new Size(250, 27);
            SawDatePickerUpdate.TabIndex = 39;
            SawDatePickerUpdate.ValueChanged += SawDatePickerUpdate_ValueChanged;
            // 
            // LblSawDateUpdate
            // 
            LblSawDateUpdate.AutoSize = true;
            LblSawDateUpdate.Location = new Point(748, 184);
            LblSawDateUpdate.Name = "LblSawDateUpdate";
            LblSawDateUpdate.Size = new Size(184, 20);
            LblSawDateUpdate.TabIndex = 32;
            LblSawDateUpdate.Text = "Ημερομηνια που την ειδα";
            // 
            // RbutttonSeenMovieUpdate
            // 
            RbutttonSeenMovieUpdate.AutoSize = true;
            RbutttonSeenMovieUpdate.Checked = true;
            RbutttonSeenMovieUpdate.Location = new Point(768, 96);
            RbutttonSeenMovieUpdate.Name = "RbutttonSeenMovieUpdate";
            RbutttonSeenMovieUpdate.Size = new Size(109, 24);
            RbutttonSeenMovieUpdate.TabIndex = 31;
            RbutttonSeenMovieUpdate.TabStop = true;
            RbutttonSeenMovieUpdate.Text = "την εχω δει";
            RbutttonSeenMovieUpdate.UseVisualStyleBackColor = true;
            RbutttonSeenMovieUpdate.CheckedChanged += RbutttonSeenMovieUpdate_CheckedChanged;
            // 
            // RButtonNotSeenUpdate
            // 
            RButtonNotSeenUpdate.AutoSize = true;
            RButtonNotSeenUpdate.Location = new Point(768, 148);
            RButtonNotSeenUpdate.Name = "RButtonNotSeenUpdate";
            RButtonNotSeenUpdate.Size = new Size(137, 24);
            RButtonNotSeenUpdate.TabIndex = 30;
            RButtonNotSeenUpdate.Text = "δεν την έχω δεί";
            RButtonNotSeenUpdate.UseVisualStyleBackColor = true;
            RButtonNotSeenUpdate.CheckedChanged += RButtonNotSeenUpdate_CheckedChanged;
            // 
            // TxtImdbRattingUpdate
            // 
            TxtImdbRattingUpdate.Location = new Point(1030, 123);
            TxtImdbRattingUpdate.Name = "TxtImdbRattingUpdate";
            TxtImdbRattingUpdate.Size = new Size(125, 27);
            TxtImdbRattingUpdate.TabIndex = 29;
            TxtImdbRattingUpdate.TextChanged += TxtImdbRattingUpdate_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1023, 100);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 28;
            label7.Text = "Βαθμολογία IMDB";
            // 
            // ListBoxActors
            // 
            ListBoxActors.FormattingEnabled = true;
            ListBoxActors.ItemHeight = 20;
            ListBoxActors.Location = new Point(45, 458);
            ListBoxActors.Name = "ListBoxActors";
            ListBoxActors.Size = new Size(277, 104);
            ListBoxActors.TabIndex = 35;
            ListBoxActors.SelectedIndexChanged += ListBoxActors_SelectedIndexChanged;
            // 
            // BtnActorsAdd
            // 
            BtnActorsAdd.BackColor = Color.Yellow;
            BtnActorsAdd.Location = new Point(45, 580);
            BtnActorsAdd.Name = "BtnActorsAdd";
            BtnActorsAdd.Size = new Size(226, 29);
            BtnActorsAdd.TabIndex = 36;
            BtnActorsAdd.Text = "Προσθεστε Πρωταγωνιστες";
            BtnActorsAdd.UseVisualStyleBackColor = false;
            BtnActorsAdd.Click += BtnActorsAdd_Click;
            // 
            // BtnRemoveActors
            // 
            BtnRemoveActors.BackColor = Color.Red;
            BtnRemoveActors.Location = new Point(462, 580);
            BtnRemoveActors.Name = "BtnRemoveActors";
            BtnRemoveActors.Size = new Size(231, 29);
            BtnRemoveActors.TabIndex = 37;
            BtnRemoveActors.Text = "Αφαιρεστε Πρωταγωνιστες";
            BtnRemoveActors.UseVisualStyleBackColor = false;
            BtnRemoveActors.Click += BtnRemoveActors_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 530);
            label8.Name = "label8";
            label8.Size = new Size(372, 20);
            label8.TabIndex = 38;
            label8.Text = "Επιλεξτε πρωταγωνιστες απο την λιστα για Αφαιρεση";
            // 
            // MovieUpdateChild
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 631);
            Controls.Add(label8);
            Controls.Add(BtnRemoveActors);
            Controls.Add(BtnActorsAdd);
            Controls.Add(ListBoxActors);
            Controls.Add(BtnUpdateMovie);
            Controls.Add(SawDatePickerUpdate);
            Controls.Add(LblSawDateUpdate);
            Controls.Add(RbutttonSeenMovieUpdate);
            Controls.Add(RButtonNotSeenUpdate);
            Controls.Add(TxtImdbRattingUpdate);
            Controls.Add(label7);
            Controls.Add(PboxMovieCreationUpdate);
            Controls.Add(AvailabilityListBoxUpdate);
            Controls.Add(label6);
            Controls.Add(CmbMovieCategoriesUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtActorsupdate);
            Controls.Add(label3);
            Controls.Add(MovieRealeseDatepickerUpdate);
            Controls.Add(label2);
            Controls.Add(TxtTitleUpdate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MovieUpdateChild";
            Text = "Επεξεργασια ταινιας";
            Load += MovieUpdateChild_Load;
            ((System.ComponentModel.ISupportInitialize)PboxMovieCreationUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PboxMovieCreationUpdate;
        private ListBox AvailabilityListBoxUpdate;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TxtActorsupdate;
        private Label label3;
        private DateTimePicker MovieRealeseDatepickerUpdate;
        private Label label2;
        private TextBox TxtTitleUpdate;
        private Label label1;
        private Button BtnUpdateMovie;
        private DateTimePicker SawDatePickerUpdate;
        private Label LblSawDateUpdate;
        private RadioButton RbutttonSeenMovieUpdate;
        private RadioButton RButtonNotSeenUpdate;
        private TextBox TxtImdbRattingUpdate;
        private Label label7;
        public ComboBox CmbMovieCategoriesUpdate;
        private ListBox ListBoxActors;
        private Button BtnActorsAdd;
        private Button BtnRemoveActors;
        private Label label8;
    }
}