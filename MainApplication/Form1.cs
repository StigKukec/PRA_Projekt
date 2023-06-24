using Utilities;

namespace MainApplication
{
    public partial class Form1 : Form
    {
        private List<Account> accounts = Account.ParseAccount();
        private Login login = new Login();
        public Form1()
        {

            InitializeComponent();
            this.Resize += App_Resize;
            // this.WindowState = FormWindowState.Maximized;
            login.ShowDialog();
            Profile();
        }
        private void Profile()
        {
            Account acc = login.GetAccount();
            string credentials = $"{acc.FirstName} {acc.LastName}";
            lblCredentials.Text = credentials;
            lblAccFirstName.Text = acc.FirstName;
            lblAccLastName.Text = acc.LastName;
            lblAccEmail.Text = acc.Email;
            lblAccPassword.Text = acc.Password;
        }
        private void App_Resize(object sender, EventArgs e)
        {
            ResponsiveControl(pnlHeader, 1, 0.15, 0, 0);
            ResponsiveControl(btnAddNotification, 0.06, 0.08, 0.9, 0.18);
            ResponsiveControl(btnLecturers, 0.1, 0.055, 0.3, 0.165);
            ResponsiveControl(btnNotifications, 0.1, 0.055, 0.2, 0.165);
            ResponsiveControl(btnProfile, 0.1, 0.055, 0.1, 0.165);
            ResponsiveControl(btnSubjects, 0.1, 0.055, 0, 0.165);
        }
        public void ResponsiveControl(Control control, double sizeWidth, double sizeHeight, double locationWidth, double locationHeight)
        {
            control.Size = new Size((int)(this.Width * sizeWidth), (int)(this.Height * sizeHeight));
            control.Location = new Point((int)(this.Width * locationWidth), (int)(this.Height * locationHeight));
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Orange;
            btnNotifications.BackColor = Color.White;
            btnSubjects.BackColor = Color.White;
            btnLecturers.BackColor = Color.White;
            Profile();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.White;
            btnNotifications.BackColor = Color.Orange;
            btnSubjects.BackColor = Color.White;
            btnLecturers.BackColor = Color.White;

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.White;
            btnNotifications.BackColor = Color.White;
            btnSubjects.BackColor = Color.Orange;
            btnLecturers.BackColor = Color.White;

        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.White;
            btnNotifications.BackColor = Color.White;
            btnSubjects.BackColor = Color.White;
            btnLecturers.BackColor = Color.Orange;

        }

        private void btnAddNotification_Click(object sender, EventArgs e)
        {

        }
    }
}