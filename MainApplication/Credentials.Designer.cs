namespace MainApplication
{
    partial class Credentials
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCredentials = new Label();
            lblUserIcon = new Label();
            SuspendLayout();
            // 
            // lblCredentials
            // 
            lblCredentials.AutoSize = true;
            lblCredentials.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCredentials.Location = new Point(65, 12);
            lblCredentials.Name = "lblCredentials";
            lblCredentials.Size = new Size(91, 19);
            lblCredentials.TabIndex = 2;
            lblCredentials.Text = "Ime i prezime";
            // 
            // lblUserIcon
            // 
            lblUserIcon.BorderStyle = BorderStyle.Fixed3D;
            lblUserIcon.Image = Properties.Resources.user_icon;
            lblUserIcon.Location = new Point(3, 0);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(57, 41);
            lblUserIcon.TabIndex = 8;
            // 
            // Credentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUserIcon);
            Controls.Add(lblCredentials);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Credentials";
            Size = new Size(214, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCredentials;
        private Label lblUserIcon;

    }
}
