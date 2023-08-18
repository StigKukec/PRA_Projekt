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
        public Login()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            foreach (Account account in accounts)
            {
                if (account.Email == "l.z@racunarstvo.hr" && account.Password == "Pa$$w0rd")
                {
                    this.Dispose();
                    Account = account;
                }
            }
        }
        public Account GetAccount()
        {
            return Account;
        } 
    }
}
