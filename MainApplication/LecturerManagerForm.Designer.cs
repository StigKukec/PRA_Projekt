namespace MainApplication
{
    partial class LecturerManagerForm
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
            btnCancel = new Button();
            label2 = new Label();
            btnProceed = new Button();
            tbLectFirstName = new TextBox();
            tbLectLastName = new TextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbPassword = new TextBox();
            cbCourses = new ComboBox();
            label5 = new Label();
            tbChoosenCourses = new TextBox();
            btnClearChoosenCourses = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(36, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 42);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Zatvori";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 81);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(220, 348);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(110, 42);
            btnProceed.TabIndex = 5;
            btnProceed.Text = "Završi";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += BtnProceed_Click;
            // 
            // tbLectFirstName
            // 
            tbLectFirstName.Location = new Point(122, 33);
            tbLectFirstName.Name = "tbLectFirstName";
            tbLectFirstName.Size = new Size(194, 27);
            tbLectFirstName.TabIndex = 6;
            // 
            // tbLectLastName
            // 
            tbLectLastName.Location = new Point(122, 81);
            tbLectLastName.Name = "tbLectLastName";
            tbLectLastName.Size = new Size(194, 27);
            tbLectLastName.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(122, 130);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(194, 27);
            tbEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 133);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 9;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 185);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Lozinka:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(122, 182);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(194, 27);
            tbPassword.TabIndex = 10;
            // 
            // cbCourses
            // 
            cbCourses.FormattingEnabled = true;
            cbCourses.Location = new Point(122, 232);
            cbCourses.Name = "cbCourses";
            cbCourses.Size = new Size(194, 28);
            cbCourses.TabIndex = 12;
            cbCourses.SelectedIndexChanged += cbCourses_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 235);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 13;
            label5.Text = "Kolegiji:";
            // 
            // tbChoosenCourses
            // 
            tbChoosenCourses.Location = new Point(50, 284);
            tbChoosenCourses.Name = "tbChoosenCourses";
            tbChoosenCourses.ReadOnly = true;
            tbChoosenCourses.Size = new Size(202, 27);
            tbChoosenCourses.TabIndex = 14;
            // 
            // btnClearChoosenCourses
            // 
            btnClearChoosenCourses.Location = new Point(258, 284);
            btnClearChoosenCourses.Name = "btnClearChoosenCourses";
            btnClearChoosenCourses.Size = new Size(58, 27);
            btnClearChoosenCourses.TabIndex = 15;
            btnClearChoosenCourses.Text = "Obriši";
            btnClearChoosenCourses.UseVisualStyleBackColor = true;
            btnClearChoosenCourses.Click += btnClearChoosenCourses_Click;
            // 
            // LecturerManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 402);
            Controls.Add(btnClearChoosenCourses);
            Controls.Add(tbChoosenCourses);
            Controls.Add(label5);
            Controls.Add(cbCourses);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(tbLectLastName);
            Controls.Add(tbLectFirstName);
            Controls.Add(btnProceed);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Name = "LecturerManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organizacija predavača";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Label label2;
        private Button btnProceed;
        private TextBox tbLectFirstName;
        private TextBox tbLectLastName;
        private TextBox tbEmail;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private ComboBox cbCourses;
        private Label label5;
        private TextBox tbChoosenCourses;
        private Button btnClearChoosenCourses;
    }
}