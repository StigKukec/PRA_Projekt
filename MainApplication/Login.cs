using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace MainApplication
{
    public partial class Login : Form
    {
        private List<Account> accounts = Account.ParseAccount();
        private Account Account { get; set; }
        private bool loginSuccess = false;
        public Login()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                Image = Properties.Resources.pik_logo
            };
            pnlLogoImage.Controls.Add(pictureBox);
            lblFailLogin.Visible = false;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            foreach (Account account in accounts)
            {
                if (account.Email == tbEmail.Text && account.Password == tbPassword.Text)
                {
                    loginSuccess = true;
                    this.Dispose();
                    Account = account;
                }
            }
            if (loginSuccess == false) 
            {
                lblFailLogin.Visible = true;
            }

        }
        public Account GetAccount()
        {
            return Account;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
