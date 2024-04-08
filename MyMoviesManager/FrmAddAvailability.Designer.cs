namespace MyMoviesManager
{
    partial class FrmAddAvailability
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
            TxtAddAvailability = new TextBox();
            BtnAddAvailability = new Button();
            SuspendLayout();
            // 
            // TxtAddAvailability
            // 
            TxtAddAvailability.Location = new Point(301, 199);
            TxtAddAvailability.Name = "TxtAddAvailability";
            TxtAddAvailability.Size = new Size(166, 27);
            TxtAddAvailability.TabIndex = 0;
            // 
            // BtnAddAvailability
            // 
            BtnAddAvailability.Location = new Point(340, 261);
            BtnAddAvailability.Name = "BtnAddAvailability";
            BtnAddAvailability.Size = new Size(94, 46);
            BtnAddAvailability.TabIndex = 1;
            BtnAddAvailability.Text = "Προσθεστε";
            BtnAddAvailability.UseVisualStyleBackColor = true;
            BtnAddAvailability.Click += BtnAddAvailability_Click;
            // 
            // FrmAddAvailability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAddAvailability);
            Controls.Add(TxtAddAvailability);
            Name = "FrmAddAvailability";
            Text = "Προσθηκη μεσου διαθεσιμοτητας";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAddAvailability;
        private Button BtnAddAvailability;
    }
}