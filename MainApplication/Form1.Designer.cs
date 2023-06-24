using System.Reflection.PortableExecutable;

namespace MainApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblCredentials = new Label();
            lblTitle = new Label();
            lblImage = new Label();
            btnProfile = new Button();
            btnNotifications = new Button();
            btnSubjects = new Button();
            btnLecturers = new Button();
            btnAddNotification = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            lblAccPassword = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblAccEmail = new Label();
            lblAccLastName = new Label();
            lblLastName = new Label();
            lblAccFirstName = new Label();
            lblFirstName = new Label();
            lblPersonIcon = new Label();
            panel2 = new Panel();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ScrollBar;
            pnlHeader.Controls.Add(lblCredentials);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblImage);
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1008, 88);
            pnlHeader.TabIndex = 0;
            // 
            // lblCredentials
            // 
            lblCredentials.AutoSize = true;
            lblCredentials.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCredentials.Location = new Point(825, 31);
            lblCredentials.Name = "lblCredentials";
            lblCredentials.Size = new Size(114, 23);
            lblCredentials.TabIndex = 2;
            lblCredentials.Text = "Ime i prezime";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(125, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(203, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "INFOEDUKA";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(24, 33);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(51, 20);
            lblImage.TabIndex = 0;
            lblImage.Text = "Image";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Orange;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Location = new Point(12, 95);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profil";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += BtnProfile_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Cursor = Cursors.Hand;
            btnNotifications.Location = new Point(112, 95);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(94, 29);
            btnNotifications.TabIndex = 2;
            btnNotifications.Text = "Obavijesti";
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Cursor = Cursors.Hand;
            btnSubjects.Location = new Point(212, 95);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(94, 29);
            btnSubjects.TabIndex = 3;
            btnSubjects.Text = "Kolegiji";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnLecturers
            // 
            btnLecturers.Cursor = Cursors.Hand;
            btnLecturers.Location = new Point(312, 95);
            btnLecturers.Name = "btnLecturers";
            btnLecturers.Size = new Size(94, 29);
            btnLecturers.TabIndex = 4;
            btnLecturers.Text = "Predavači";
            btnLecturers.UseVisualStyleBackColor = true;
            btnLecturers.Click += btnLecturers_Click;
            // 
            // btnAddNotification
            // 
            btnAddNotification.BackColor = Color.Orange;
            btnAddNotification.Cursor = Cursors.Hand;
            btnAddNotification.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNotification.Location = new Point(929, 95);
            btnAddNotification.Name = "btnAddNotification";
            btnAddNotification.Size = new Size(65, 58);
            btnAddNotification.TabIndex = 5;
            btnAddNotification.Text = "+";
            btnAddNotification.UseVisualStyleBackColor = false;
            btnAddNotification.Click += btnAddNotification_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblAccPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAccEmail);
            panel1.Controls.Add(lblAccLastName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblAccFirstName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblPersonIcon);
            panel1.Location = new Point(185, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 340);
            panel1.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Location = new Point(27, 188);
            panel5.Name = "panel5";
            panel5.Size = new Size(607, 10);
            panel5.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Location = new Point(27, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 10);
            panel3.TabIndex = 9;
            // 
            // lblAccPassword
            // 
            lblAccPassword.AutoSize = true;
            lblAccPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccPassword.Location = new Point(458, 238);
            lblAccPassword.Name = "lblAccPassword";
            lblAccPassword.Size = new Size(51, 20);
            lblAccPassword.TabIndex = 8;
            lblAccPassword.Text = "label7";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(471, 201);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Lozinka";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(471, 83);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail";
            // 
            // lblAccEmail
            // 
            lblAccEmail.AutoSize = true;
            lblAccEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccEmail.Location = new Point(458, 120);
            lblAccEmail.Name = "lblAccEmail";
            lblAccEmail.Size = new Size(51, 20);
            lblAccEmail.TabIndex = 5;
            lblAccEmail.Text = "label6";
            // 
            // lblAccLastName
            // 
            lblAccLastName.AutoSize = true;
            lblAccLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccLastName.Location = new Point(135, 238);
            lblAccLastName.Name = "lblAccLastName";
            lblAccLastName.Size = new Size(51, 20);
            lblAccLastName.TabIndex = 4;
            lblAccLastName.Text = "label3";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(151, 201);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(65, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Prezime";
            // 
            // lblAccFirstName
            // 
            lblAccFirstName.AutoSize = true;
            lblAccFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccFirstName.Location = new Point(135, 120);
            lblAccFirstName.Name = "lblAccFirstName";
            lblAccFirstName.Size = new Size(51, 20);
            lblAccFirstName.TabIndex = 2;
            lblAccFirstName.Text = "label2";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(151, 83);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(36, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Ime";
            // 
            // lblPersonIcon
            // 
            lblPersonIcon.AutoSize = true;
            lblPersonIcon.Location = new Point(14, 24);
            lblPersonIcon.Name = "lblPersonIcon";
            lblPersonIcon.Size = new Size(84, 20);
            lblPersonIcon.TabIndex = 0;
            lblPersonIcon.Text = "Person icon";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(1, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 49);
            panel2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 531);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnAddNotification);
            Controls.Add(btnLecturers);
            Controls.Add(btnSubjects);
            Controls.Add(btnNotifications);
            Controls.Add(btnProfile);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Infoeduka";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblCredentials;
        private Label lblTitle;
        private Label lblImage;
        private Button btnProfile;
        private Button btnNotifications;
        private Button btnSubjects;
        private Button btnLecturers;
        private Button btnAddNotification;
        private Panel panel1;
        private Label lblAccPassword;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblAccEmail;
        private Label lblAccLastName;
        private Label lblLastName;
        private Label lblAccFirstName;
        private Label lblFirstName;
        private Label lblPersonIcon;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
    }
}