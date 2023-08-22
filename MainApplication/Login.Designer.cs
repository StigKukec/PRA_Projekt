namespace MainApplication
{
    partial class Login
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
            panel1 = new Panel();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnLogin = new Button();
            pnlLogoImage = new Panel();
            lblFailLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lblFailLogin);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pnlLogoImage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 412);
            panel1.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(107, 246);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(206, 37);
            tbPassword.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(107, 181);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(206, 37);
            tbEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 249);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 184);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightBlue;
            btnLogin.Location = new Point(30, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(321, 54);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // pnlLogoImage
            // 
            pnlLogoImage.Location = new Point(117, 12);
            pnlLogoImage.Name = "pnlLogoImage";
            pnlLogoImage.Size = new Size(173, 143);
            pnlLogoImage.TabIndex = 0;
            // 
            // lblFailLogin
            // 
            lblFailLogin.AutoSize = true;
            lblFailLogin.ForeColor = Color.Red;
            lblFailLogin.Location = new Point(117, 298);
            lblFailLogin.Name = "lblFailLogin";
            lblFailLogin.Size = new Size(191, 20);
            lblFailLogin.TabIndex = 6;
            lblFailLogin.Text = "Nije valjan email ili lozinka!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 412);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnLogin;
        private Panel pnlLogoImage;
        private Label lblFailLogin;
    }
}