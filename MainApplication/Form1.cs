using Utilities;

namespace MainApplication
{
    public partial class Form1 : Form
    {
        private List<Account> accounts = Account.ParseAccount();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            foreach (Account account in accounts)
            {
                if (account.Email == tbEmail.Text && account.Password == tbPassword.Text)
                {
                    this.Controls.Clear();
                }
            }
        }
    }
}