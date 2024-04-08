namespace MyMoviesManager
{
    partial class FrmUpdateAvailability
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
            listAvailabilityUpdate = new ListBox();
            BtnAvailabilityUpdate = new Button();
            TxtAvailabilityUpdate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listAvailabilityUpdate
            // 
            listAvailabilityUpdate.FormattingEnabled = true;
            listAvailabilityUpdate.ItemHeight = 20;
            listAvailabilityUpdate.Location = new Point(193, 185);
            listAvailabilityUpdate.Name = "listAvailabilityUpdate";
            listAvailabilityUpdate.Size = new Size(247, 164);
            listAvailabilityUpdate.TabIndex = 0;
            listAvailabilityUpdate.SelectedIndexChanged += listAvailabilityUpdate_SelectedIndexChanged;
            // 
            // BtnAvailabilityUpdate
            // 
            BtnAvailabilityUpdate.Location = new Point(403, 397);
            BtnAvailabilityUpdate.Name = "BtnAvailabilityUpdate";
            BtnAvailabilityUpdate.Size = new Size(144, 39);
            BtnAvailabilityUpdate.TabIndex = 1;
            BtnAvailabilityUpdate.Text = "Μετανομασια";
            BtnAvailabilityUpdate.UseVisualStyleBackColor = true;
            BtnAvailabilityUpdate.Click += BtnAvailabilityUpdate_Click;
            // 
            // TxtAvailabilityUpdate
            // 
            TxtAvailabilityUpdate.Location = new Point(559, 299);
            TxtAvailabilityUpdate.Name = "TxtAvailabilityUpdate";
            TxtAvailabilityUpdate.Size = new Size(231, 27);
            TxtAvailabilityUpdate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 134);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 3;
            label1.Text = "Επιλεξτε Μεσων Διαθεσιμοτητας";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 251);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 4;
            label2.Text = "Εισαγετε νεα ονομασια ";
            // 
            // FrmUpdateAvailability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 619);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtAvailabilityUpdate);
            Controls.Add(BtnAvailabilityUpdate);
            Controls.Add(listAvailabilityUpdate);
            Name = "FrmUpdateAvailability";
            Text = "Μετανομασια Μεσων Διαθεσημοτητας";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listAvailabilityUpdate;
        private Button BtnAvailabilityUpdate;
        private TextBox TxtAvailabilityUpdate;
        private Label label1;
        private Label label2;
    }
}