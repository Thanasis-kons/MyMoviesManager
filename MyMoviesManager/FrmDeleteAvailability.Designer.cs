namespace MyMoviesManager
{
    partial class FrmDeleteAvailability
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
            ListAvailabilityDelete = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ListAvailabilityDelete
            // 
            ListAvailabilityDelete.FormattingEnabled = true;
            ListAvailabilityDelete.ItemHeight = 20;
            ListAvailabilityDelete.Location = new Point(510, 331);
            ListAvailabilityDelete.Name = "ListAvailabilityDelete";
            ListAvailabilityDelete.Size = new Size(395, 204);
            ListAvailabilityDelete.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 253);
            label1.Name = "label1";
            label1.Size = new Size(376, 20);
            label1.TabIndex = 2;
            label1.Text = "Καντε διπλο κλικ για διαγραφη μέσου διαθεσημοτιτας";
            // 
            // FrmDeleteAvailability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 703);
            Controls.Add(label1);
            Controls.Add(ListAvailabilityDelete);
            Name = "FrmDeleteAvailability";
            Text = "Διαγραφή μέσου διαθεσιμότητας";
            WindowState = FormWindowState.Maximized;
            Load += FrmDeleteAvailability_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListAvailabilityDelete;
        private Label label1;
    }
}