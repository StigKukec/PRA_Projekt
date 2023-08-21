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
            listSubjects = new ListBox();
            listLecturers = new ListBox();
            btnInsertSubject = new Button();
            btnUpdateSubject = new Button();
            btnDeleteSubject = new Button();
            btnInsertLecturer = new Button();
            btnUpdateLecturer = new Button();
            btnDeleteLecturer = new Button();
            pnlHeader = new Panel();
            ucCredentials = new Credentials();
            lblTitle = new Label();
            lblLogo = new Label();
            flpNotifications = new FlowLayoutPanel();
            pnlSubjects = new Panel();
            pnlLecturers = new Panel();
            btnProfile = new Button();
            btnNotifications = new Button();
            btnSubjects = new Button();
            btnLecturers = new Button();
            btnAddNotification = new Button();
            pnlProfile = new Panel();
            pnlProfile3 = new Panel();
            lblProfileIcon = new Label();
            lblAccCourse = new Label();
            pnlProfile2 = new Panel();
            lblTitleCourse = new Label();
            pnlProfile1 = new Panel();
            lblAccPassword = new Label();
            lblTitlePassword = new Label();
            lblTitleEmail = new Label();
            lblAccEmail = new Label();
            lblAccLastName = new Label();
            lblTitleLastName = new Label();
            lblAccFirstName = new Label();
            lblTitleFirstName = new Label();
            pnlFooter = new Panel();
            ucLogOut = new LogOut();
            pnlHeader.SuspendLayout();
            pnlProfile.SuspendLayout();
            SuspendLayout();
            // 
            // listSubjects
            // 
            listSubjects.BackColor = Color.White;
            listSubjects.DrawMode = DrawMode.OwnerDrawFixed;
            listSubjects.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listSubjects.ItemHeight = 40;
            listSubjects.Location = new Point(100, 10);
            listSubjects.Name = "listSubjects";
            listSubjects.Size = new Size(1200, 500);
            listSubjects.TabIndex = 0;
            listSubjects.DrawItem += CentriranjeTexta_DrawItem;
            listSubjects.SelectedIndexChanged += ListSubjects_SelectedIndexChanged;
            // 
            // listLecturers
            // 
            listLecturers.BackColor = Color.White;
            listLecturers.DrawMode = DrawMode.OwnerDrawFixed;
            listLecturers.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listLecturers.ItemHeight = 40;
            listLecturers.Location = new Point(100, 10);
            listLecturers.Name = "listLecturers";
            listLecturers.Size = new Size(1200, 500);
            listLecturers.TabIndex = 0;
            listLecturers.DrawItem += CentriranjeTexta_DrawItem;
            listLecturers.SelectedIndexChanged += ListLecturers_SelectedIndexChanged;
            // 
            // btnInsertSubject
            // 
            btnInsertSubject.BackColor = Color.Orange;
            btnInsertSubject.Cursor = Cursors.Hand;
            btnInsertSubject.Location = new Point(400, 550);
            btnInsertSubject.Name = "btnInsertSubject";
            btnInsertSubject.Size = new Size(120, 50);
            btnInsertSubject.TabIndex = 0;
            btnInsertSubject.Text = "Stvori";
            btnInsertSubject.UseVisualStyleBackColor = false;
            btnInsertSubject.Click += BtnInsertSubject_Click;
            // 
            // btnUpdateSubject
            // 
            btnUpdateSubject.BackColor = Color.Gray;
            btnUpdateSubject.Cursor = Cursors.Hand;
            btnUpdateSubject.Location = new Point(600, 550);
            btnUpdateSubject.Name = "btnUpdateSubject";
            btnUpdateSubject.Size = new Size(120, 50);
            btnUpdateSubject.TabIndex = 0;
            btnUpdateSubject.Text = "Promijeni";
            btnUpdateSubject.UseVisualStyleBackColor = false;
            btnUpdateSubject.Click += BtnUpdateSubject_Click;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.BackColor = Color.Red;
            btnDeleteSubject.Cursor = Cursors.Hand;
            btnDeleteSubject.Location = new Point(800, 550);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(120, 50);
            btnDeleteSubject.TabIndex = 0;
            btnDeleteSubject.Text = "Obriši";
            btnDeleteSubject.UseVisualStyleBackColor = false;
            btnDeleteSubject.Click += BtnDeleteSubject_Click;
            // 
            // btnInsertLecturer
            // 
            btnInsertLecturer.BackColor = Color.Orange;
            btnInsertLecturer.Cursor = Cursors.Hand;
            btnInsertLecturer.Location = new Point(400, 550);
            btnInsertLecturer.Name = "btnInsertLecturer";
            btnInsertLecturer.Size = new Size(120, 50);
            btnInsertLecturer.TabIndex = 0;
            btnInsertLecturer.Text = "Stvori";
            btnInsertLecturer.UseVisualStyleBackColor = false;
            btnInsertLecturer.Click += BtnInsertLecturer_Click;
            // 
            // btnUpdateLecturer
            // 
            btnUpdateLecturer.BackColor = Color.Gray;
            btnUpdateLecturer.Cursor = Cursors.Hand;
            btnUpdateLecturer.Location = new Point(600, 550);
            btnUpdateLecturer.Name = "btnUpdateLecturer";
            btnUpdateLecturer.Size = new Size(120, 50);
            btnUpdateLecturer.TabIndex = 0;
            btnUpdateLecturer.Text = "Promijeni";
            btnUpdateLecturer.UseVisualStyleBackColor = false;
            btnUpdateLecturer.Click += BtnUpdateLecturer_Click;
            // 
            // btnDeleteLecturer
            // 
            btnDeleteLecturer.BackColor = Color.Red;
            btnDeleteLecturer.Cursor = Cursors.Hand;
            btnDeleteLecturer.Location = new Point(800, 550);
            btnDeleteLecturer.Name = "btnDeleteLecturer";
            btnDeleteLecturer.Size = new Size(120, 50);
            btnDeleteLecturer.TabIndex = 0;
            btnDeleteLecturer.Text = "Obriši";
            btnDeleteLecturer.UseVisualStyleBackColor = false;
            btnDeleteLecturer.Click += BtnDeleteLecturer_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ScrollBar;
            pnlHeader.Controls.Add(ucCredentials);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1283, 104);
            pnlHeader.TabIndex = 0;
            // 
            // ucCredentials
            // 
            ucCredentials.Location = new Point(963, 11);
            ucCredentials.Name = "ucCredentials";
            ucCredentials.Size = new Size(261, 74);
            ucCredentials.TabIndex = 2;
            ucCredentials.Click += UcCredentials_Click;
            ucCredentials.Paint += UcCredentials_Paint;
            ucCredentials.MouseEnter += UcCredentials_MouseEnter;
            ucCredentials.MouseLeave += UcCredentials_MouseLeave;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(164, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(203, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "INFOEDUKA";
            // 
            // lblLogo
            // 
            lblLogo.Image = Properties.Resources.pik_logo;
            lblLogo.Location = new Point(19, 11);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(111, 84);
            lblLogo.TabIndex = 0;
            // 
            // flpNotifications
            // 
            flpNotifications.AutoScroll = true;
            flpNotifications.BackColor = SystemColors.ScrollBar;
            flpNotifications.Location = new Point(185, 139);
            flpNotifications.Name = "flpNotifications";
            flpNotifications.Size = new Size(681, 340);
            flpNotifications.TabIndex = 6;
            // 
            // pnlSubjects
            // 
            pnlSubjects.BackColor = SystemColors.ScrollBar;
            pnlSubjects.Location = new Point(185, 139);
            pnlSubjects.Name = "pnlSubjects";
            pnlSubjects.Size = new Size(681, 340);
            pnlSubjects.TabIndex = 6;
            // 
            // pnlLecturers
            // 
            pnlLecturers.BackColor = SystemColors.ScrollBar;
            pnlLecturers.Location = new Point(185, 139);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new Size(681, 340);
            pnlLecturers.TabIndex = 6;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Orange;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Location = new Point(20, 111);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(111, 41);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profil";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += BtnProfile_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Cursor = Cursors.Hand;
            btnNotifications.Location = new Point(137, 111);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(111, 41);
            btnNotifications.TabIndex = 2;
            btnNotifications.Text = "Obavijesti";
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Cursor = Cursors.Hand;
            btnSubjects.Location = new Point(268, 111);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(111, 41);
            btnSubjects.TabIndex = 3;
            btnSubjects.Text = "Kolegiji";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnLecturers
            // 
            btnLecturers.Cursor = Cursors.Hand;
            btnLecturers.Location = new Point(388, 111);
            btnLecturers.Name = "btnLecturers";
            btnLecturers.Size = new Size(111, 41);
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
            btnAddNotification.Click += BtnAddNotification_Click;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = SystemColors.ScrollBar;
            pnlProfile.Controls.Add(pnlProfile3);
            pnlProfile.Controls.Add(lblProfileIcon);
            pnlProfile.Controls.Add(lblAccCourse);
            pnlProfile.Controls.Add(pnlProfile2);
            pnlProfile.Controls.Add(lblTitleCourse);
            pnlProfile.Controls.Add(pnlProfile1);
            pnlProfile.Controls.Add(lblAccPassword);
            pnlProfile.Controls.Add(lblTitlePassword);
            pnlProfile.Controls.Add(lblTitleEmail);
            pnlProfile.Controls.Add(lblAccEmail);
            pnlProfile.Controls.Add(lblAccLastName);
            pnlProfile.Controls.Add(lblTitleLastName);
            pnlProfile.Controls.Add(lblAccFirstName);
            pnlProfile.Controls.Add(lblTitleFirstName);
            pnlProfile.Location = new Point(307, 216);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(727, 366);
            pnlProfile.TabIndex = 6;
            // 
            // pnlProfile3
            // 
            pnlProfile3.Anchor = AnchorStyles.Top;
            pnlProfile3.BackColor = Color.Orange;
            pnlProfile3.Location = new Point(57, 293);
            pnlProfile3.Name = "pnlProfile3";
            pnlProfile3.Size = new Size(607, 10);
            pnlProfile3.TabIndex = 13;
            // 
            // lblProfileIcon
            // 
            lblProfileIcon.BackgroundImageLayout = ImageLayout.Stretch;
            lblProfileIcon.BorderStyle = BorderStyle.FixedSingle;
            lblProfileIcon.Image = Properties.Resources.user_icon;
            lblProfileIcon.Location = new Point(16, 12);
            lblProfileIcon.Name = "lblProfileIcon";
            lblProfileIcon.Size = new Size(75, 77);
            lblProfileIcon.TabIndex = 11;
            // 
            // lblAccCourse
            // 
            lblAccCourse.Anchor = AnchorStyles.Top;
            lblAccCourse.AutoSize = true;
            lblAccCourse.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccCourse.Location = new Point(167, 329);
            lblAccCourse.Name = "lblAccCourse";
            lblAccCourse.Size = new Size(59, 23);
            lblAccCourse.TabIndex = 12;
            lblAccCourse.Text = "label3";
            // 
            // pnlProfile2
            // 
            pnlProfile2.Anchor = AnchorStyles.Top;
            pnlProfile2.BackColor = Color.Orange;
            pnlProfile2.Location = new Point(57, 210);
            pnlProfile2.Name = "pnlProfile2";
            pnlProfile2.Size = new Size(607, 10);
            pnlProfile2.TabIndex = 10;
            // 
            // lblTitleCourse
            // 
            lblTitleCourse.Anchor = AnchorStyles.Top;
            lblTitleCourse.AutoSize = true;
            lblTitleCourse.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleCourse.Location = new Point(181, 306);
            lblTitleCourse.Name = "lblTitleCourse";
            lblTitleCourse.Size = new Size(76, 23);
            lblTitleCourse.TabIndex = 11;
            lblTitleCourse.Text = "Kolegiji:";
            // 
            // pnlProfile1
            // 
            pnlProfile1.Anchor = AnchorStyles.Top;
            pnlProfile1.BackColor = Color.Orange;
            pnlProfile1.Location = new Point(57, 92);
            pnlProfile1.Name = "pnlProfile1";
            pnlProfile1.Size = new Size(607, 10);
            pnlProfile1.TabIndex = 9;
            // 
            // lblAccPassword
            // 
            lblAccPassword.Anchor = AnchorStyles.Top;
            lblAccPassword.AutoSize = true;
            lblAccPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccPassword.Location = new Point(488, 260);
            lblAccPassword.Name = "lblAccPassword";
            lblAccPassword.Size = new Size(59, 23);
            lblAccPassword.TabIndex = 8;
            lblAccPassword.Text = "label7";
            // 
            // lblTitlePassword
            // 
            lblTitlePassword.Anchor = AnchorStyles.Top;
            lblTitlePassword.AutoSize = true;
            lblTitlePassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitlePassword.Location = new Point(501, 223);
            lblTitlePassword.Name = "lblTitlePassword";
            lblTitlePassword.Size = new Size(76, 23);
            lblTitlePassword.TabIndex = 7;
            lblTitlePassword.Text = "Lozinka:";
            // 
            // lblTitleEmail
            // 
            lblTitleEmail.Anchor = AnchorStyles.Top;
            lblTitleEmail.AutoSize = true;
            lblTitleEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleEmail.Location = new Point(501, 105);
            lblTitleEmail.Name = "lblTitleEmail";
            lblTitleEmail.Size = new Size(66, 23);
            lblTitleEmail.TabIndex = 6;
            lblTitleEmail.Text = "E-mail:";
            // 
            // lblAccEmail
            // 
            lblAccEmail.Anchor = AnchorStyles.Top;
            lblAccEmail.AutoSize = true;
            lblAccEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccEmail.Location = new Point(488, 142);
            lblAccEmail.Name = "lblAccEmail";
            lblAccEmail.Size = new Size(59, 23);
            lblAccEmail.TabIndex = 5;
            lblAccEmail.Text = "label6";
            // 
            // lblAccLastName
            // 
            lblAccLastName.Anchor = AnchorStyles.Top;
            lblAccLastName.AutoSize = true;
            lblAccLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccLastName.Location = new Point(165, 260);
            lblAccLastName.Name = "lblAccLastName";
            lblAccLastName.Size = new Size(59, 23);
            lblAccLastName.TabIndex = 4;
            lblAccLastName.Text = "label3";
            // 
            // lblTitleLastName
            // 
            lblTitleLastName.Anchor = AnchorStyles.Top;
            lblTitleLastName.AutoSize = true;
            lblTitleLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleLastName.Location = new Point(181, 223);
            lblTitleLastName.Name = "lblTitleLastName";
            lblTitleLastName.Size = new Size(79, 23);
            lblTitleLastName.TabIndex = 3;
            lblTitleLastName.Text = "Prezime:";
            // 
            // lblAccFirstName
            // 
            lblAccFirstName.Anchor = AnchorStyles.Top;
            lblAccFirstName.AutoSize = true;
            lblAccFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccFirstName.Location = new Point(165, 142);
            lblAccFirstName.Name = "lblAccFirstName";
            lblAccFirstName.Size = new Size(59, 23);
            lblAccFirstName.TabIndex = 2;
            lblAccFirstName.Text = "label2";
            // 
            // lblTitleFirstName
            // 
            lblTitleFirstName.Anchor = AnchorStyles.Top;
            lblTitleFirstName.AutoSize = true;
            lblTitleFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleFirstName.Location = new Point(181, 105);
            lblTitleFirstName.Name = "lblTitleFirstName";
            lblTitleFirstName.Size = new Size(45, 23);
            lblTitleFirstName.TabIndex = 1;
            lblTitleFirstName.Text = "Ime:";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Orange;
            pnlFooter.Location = new Point(1, 687);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1283, 67);
            pnlFooter.TabIndex = 7;
            // 
            // ucLogOut
            // 
            ucLogOut.BackColor = Color.Orange;
            ucLogOut.Location = new Point(963, 11);
            ucLogOut.Name = "ucLogOut";
            ucLogOut.Size = new Size(261, 74);
            ucLogOut.TabIndex = 2;
            ucLogOut.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(ucLogOut);
            Controls.Add(pnlFooter);
            Controls.Add(pnlProfile);
            Controls.Add(btnLecturers);
            Controls.Add(btnSubjects);
            Controls.Add(btnNotifications);
            Controls.Add(btnProfile);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1300, 800);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Infoeduka";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ResumeLayout(false);
        }









        #endregion

        private Panel pnlHeader;
        private Panel pnlSubjects;
        private Panel pnlLecturers;
        private Panel pnlFooter;
        private Panel pnlProfile2;
        private Panel pnlProfile1;
        private Panel pnlProfile;
        private Label lblTitle;
        private Label lblLogo;
        private Label lblAccPassword;
        private Label lblTitlePassword;
        private Label lblTitleEmail;
        private Label lblAccEmail;
        private Label lblAccLastName;
        private Label lblTitleLastName;
        private Label lblAccFirstName;
        private Label lblTitleFirstName;
        private Label lblProfileIcon;
        private FlowLayoutPanel flpNotifications;
        private ListBox listSubjects;
        private ListBox listLecturers;
        private Button btnProfile;
        private Button btnNotifications;
        private Button btnSubjects;
        private Button btnLecturers;
        private Button btnAddNotification;
        private Button btnInsertSubject;
        private Button btnUpdateSubject;
        private Button btnDeleteSubject;
        private Button btnInsertLecturer;
        private Button btnUpdateLecturer;
        private Button btnDeleteLecturer;
        private Credentials ucCredentials;
        private LogOut ucLogOut;
        private Panel pnlProfile3;
        private Label lblAccCourse;
        private Label lblTitleCourse;
    }
}