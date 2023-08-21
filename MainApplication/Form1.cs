using System.Net;
using Utilities;

namespace MainApplication
{
    public partial class Form1 : Form
    {
        private Login login = new Login();
        bool logoutButton = false;
        private List<Notification> notifications;
        private List<Course> subjects;
        private List<Account> lecturers;
        private int selectedSubValue;
        private int selectedLectValue;
        private string notificationTitle = "lblMessageTitle";
        private string notificationMessage = "rtbMessage";
        private string notificationDelete = "lblDeleteNotification";
        private string notificationCourse = "lblMessageCourse";
        private string administrator = "administrator";
        private Course subject;
        private Account lecturer;
        private readonly Account acc;
        private System.Windows.Forms.Timer glowTimer;
        private double glowIntensity = 0.0;
        private const double maxGlowIntensity = 0.5;
        public Form1()
        {
            InitializeComponent();
            this.Resize += App_Resize;
            this.WindowState = FormWindowState.Maximized;
            login.ShowDialog();
            acc = login.GetAccount();
            Profile();
            ucLogOut.Logout = UcLogOut_LogOut_Click;
            glowTimer = new System.Windows.Forms.Timer();
            glowTimer.Interval = 100;
            glowTimer.Tick += GlowTimer_Tick;
        }
        private bool Authorization()
        {
            return acc.Role == administrator;
        }
        private void Profile()
        {
            if (!Authorization())
            {
                Controls.Remove(btnLecturers);
            }
            string print = $"{acc.FirstName} {acc.LastName}";
            ucCredentials.Credential = print;
            lblAccFirstName.Text = acc.FirstName;
            lblAccLastName.Text = acc.LastName;
            lblAccEmail.Text = acc.Email;
            lblAccPassword.Text = acc.Password;
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                //*************************************************************************************************
                Image = Properties.Resources.pik_logo
                //*************************************************************************************************
            };
            lblLogo.Controls.Add(pictureBox);
            if (acc.Course == string.Empty || acc.Course == null)
            {
                lblAccCourse.Text = "Ne vodite nijedan kolgij";
            }
            else
            {
                lblAccCourse.Text = acc.Course;
            }
        }
        private void Notifications()
        {
            flpNotifications.Controls.Clear();
            if (notifications != null)
            {
                notifications.Clear();
            }
            notifications = Notification.GetNotifications();
            foreach (Notification notification in notifications)
            {
                Notice(notification);
            }
        }
        private void Notice(Notification notification)
        {
            Panel p = new Panel();
            p.BackColor = Color.Orange;
            p.Size = new Size(500, 450);
            Label lblMessageTitle = new Label();
            lblMessageTitle.Name = notificationTitle;
            lblMessageTitle.Location = new Point(10, 10);
            lblMessageTitle.Size = new Size(290, 30);
            lblMessageTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblMessageTitle.Text = notification.Title;
            RichTextBox rtbMessage = new RichTextBox();
            rtbMessage.BackColor = Color.LightGoldenrodYellow;
            rtbMessage.Name = notificationMessage;
            rtbMessage.ReadOnly = true;
            rtbMessage.Location = new Point(5, 45);
            rtbMessage.Size = new Size(490, 370);
            rtbMessage.Text = notification.Message;
            Label lblMessageCourse = new Label();
            lblMessageCourse.Location = new Point(5, 420);
            lblMessageCourse.Size = new Size(250, 35);
            lblMessageCourse.Text = notification.Course;
            lblMessageCourse.Font = new Font("Arial", 10, FontStyle.Regular);
            lblMessageCourse.Name = notificationCourse;
            Label lblMessageDate = new Label();
            lblMessageDate.Location = new Point(350, 420);
            lblMessageDate.Size = new Size(150, 35);
            lblMessageDate.Font = new Font("Arial", 10, FontStyle.Regular);
            lblMessageDate.Text = notification.Date.ToString();
            Label lblDeleteNotification = new Label();
            lblDeleteNotification.ForeColor = Color.White;
            lblDeleteNotification.AutoSize = true;
            lblDeleteNotification.Location = new Point(465, 4);
            lblDeleteNotification.Name = notificationDelete;
            lblDeleteNotification.Size = new Size(84, 20);
            lblDeleteNotification.Font = new Font(lblDeleteNotification.Font.FontFamily, 14, FontStyle.Bold);
            lblDeleteNotification.Text = "X";
            lblDeleteNotification.Click += LblDeleteNotification_Click;
            lblDeleteNotification.MouseEnter += LblDeleteNotification_MouseEnter;
            lblDeleteNotification.MouseLeave += LblDeleteNotification_MouseLeave;
            p.Controls.Add(lblDeleteNotification);
            p.Controls.Add(lblMessageTitle);
            p.Controls.Add(rtbMessage);
            p.Controls.Add(lblMessageCourse);
            p.Controls.Add(lblMessageDate);
            flpNotifications.Controls.Add(p);
        }
        private void LblDeleteNotification_Click(object sender, EventArgs e)
        {
            Label? selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                Panel? parent = selectedLabel.Parent as Panel;
                if (parent != null)
                {
                    Label? messageTitle = parent.Controls.Find(notificationTitle, true).FirstOrDefault() as Label;
                    Label? messageCourse = parent.Controls.Find(notificationCourse, true).FirstOrDefault() as Label;
                    RichTextBox? messageText = parent.Controls.Find(notificationMessage, true).FirstOrDefault() as RichTextBox;
                    if (messageTitle != null && messageText != null && messageCourse != null)
                    {
                        Notification.DeleteNotification(new Notification(messageTitle.Text, messageText.Text, messageCourse.Text));
                    }
                }
            }
            //------------------------------------------------------------
            Notifications();
        }
        private void LblDeleteNotification_MouseLeave(object sender, EventArgs e)
        {
            Label? label = sender as Label;
            label.BackColor = Color.Orange;
            label.ForeColor = Color.White;
        }

        private void LblDeleteNotification_MouseEnter(object sender, EventArgs e)
        {
            Label? label = sender as Label;
            label.BackColor = Color.Black;
            label.ForeColor = Color.White;
        }
        private void Subjects()
        {
            listSubjects.Items.Clear();
            subjects = Course.GetSubjects();
            pnlSubjects.Controls.Add(listSubjects);
            if (Authorization())
            {
                pnlSubjects.Controls.Add(btnInsertSubject);
                pnlSubjects.Controls.Add(btnUpdateSubject);
                pnlSubjects.Controls.Add(btnDeleteSubject);
            }
            foreach (Course subject in subjects)
            {
                listSubjects.Items.Add(subject);
            }
        }
        private void Lecturers()
        {
            lecturers = Account.GetAccounts();
            listLecturers.Items.Clear();
            pnlLecturers.Controls.Add(listLecturers);
            pnlLecturers.Controls.Add(btnInsertLecturer);
            pnlLecturers.Controls.Add(btnUpdateLecturer);
            pnlLecturers.Controls.Add(btnDeleteLecturer);
            foreach (Account lecturer in lecturers)
            {
                if (lecturer.Role != administrator)
                {
                    listLecturers.Items.Add(lecturer);
                }
            }
        }
        private void App_Resize(object sender, EventArgs e)
        {
            //header
            ResponsiveControl(pnlHeader, 1, 0.1, 0, 0);
            ResponsiveControl(btnLecturers, 0.1, 0.055, 0.3, 0.1);
            ResponsiveControl(btnNotifications, 0.1, 0.055, 0.1, 0.1);
            ResponsiveControl(btnProfile, 0.1, 0.055, 0, 0.1);
            ResponsiveControl(btnSubjects, 0.1, 0.055, 0.2, 0.1);

            ResponsiveControl(lblLogo, 0.1, 0.05, 0.05, 0.025);
            ResponsiveControl(lblTitle, 0.1, 0.1, 0.15, 0.025);
            ResponsiveControl(ucCredentials, 0.13, 0.06, 0.85, 0.025);
            ResponsiveControl(ucLogOut, 0.1255, 0.125, 0.8525, 0.08);
            //header

            //profile
            ResponsiveControl(pnlProfile, 0.55, 0.55, 0.23, 0.25);
            //Separation lines
            ResponsiveControl(pnlProfile1, 0.4, 0.009, 0.08, 0.09);
            ResponsiveControl(pnlProfile2, 0.4, 0.009, 0.08, 0.2);
            ResponsiveControl(pnlProfile3, 0.4, 0.009, 0.08, 0.32);
            //Separation lines
            //First name
            ResponsiveControl(lblTitleFirstName, 0.15, 0.1, 0.15, 0.1);
            ResponsiveControl(lblAccFirstName, 0.15, 0.1, 0.15, 0.12);
            //First name
            //Last name
            ResponsiveControl(lblTitleLastName, 0.15, 0.1, 0.35, 0.1);
            ResponsiveControl(lblAccLastName, 0.15, 0.1, 0.35, 0.12);
            //Last name
            //Email
            ResponsiveControl(lblTitleEmail, 0.15, 0.1, 0.15, 0.22);
            ResponsiveControl(lblAccEmail, 0.15, 0.1, 0.15, 0.24);
            //Email
            //Password
            ResponsiveControl(lblTitlePassword, 0.15, 0.1, 0.35, 0.22);
            ResponsiveControl(lblAccPassword, 0.15, 0.1, 0.35, 0.24);
            //Password
            //Course
            ResponsiveControl(lblTitleCourse, 0.15, 0.1, 0.15, 0.34);
            ResponsiveControl(lblAccCourse, 0.15, 0.1, 0.15, 0.36);
            //Course
            //profile

            //Notifications
            ResponsiveControl(flpNotifications, 0.8, 0.6, 0.05, 0.2);
            ResponsiveControl(btnAddNotification, 0.06, 0.08, 0.9, 0.18);
            //Notifications

            //Lecturers
            ResponsiveControl(pnlLecturers, 0.75, 0.6, 0.13, 0.2);
            ResponsiveControl(btnInsertLecturer, 0.1, 0.05, 0.15, 0.5);
            ResponsiveControl(btnUpdateLecturer, 0.1, 0.05, 0.32, 0.5);
            ResponsiveControl(btnDeleteLecturer, 0.1, 0.05, 0.49, 0.5);
            ResponsiveControl(listLecturers, 0.65, 0.47, 0.05, 0.02);
            //Lecturers

            //Courses
            ResponsiveControl(pnlSubjects, 0.75, 0.6, 0.13, 0.2);
            ResponsiveControl(btnInsertSubject, 0.1, 0.05, 0.15, 0.5);
            ResponsiveControl(btnUpdateSubject, 0.1, 0.05, 0.32, 0.5);
            ResponsiveControl(btnDeleteSubject, 0.1, 0.05, 0.49, 0.5);
            ResponsiveControl(listSubjects, 0.65, 0.47, 0.05, 0.02);
            //Courses

            //footer
            ResponsiveControl(pnlFooter, 1, 0.1, 0, 0.9);
            //footer
        }
        public void ResponsiveControl(Control control, double sizeWidth, double sizeHeight, double locationWidth, double locationHeight)
        {
            control.Size = new Size((int)(this.Width * sizeWidth), (int)(this.Height * sizeHeight));
            control.Location = new Point((int)(this.Width * locationWidth), (int)(this.Height * locationHeight));
        }

        private void CentriranjeTexta_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index >= 0)
            {
                ListBox listBox = (ListBox)sender;
                string itemText = listBox.Items[e.Index].ToString();

                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    using (Brush brush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds, sf);
                    }
                }
            }
        }
        private void UcCredentials_MouseEnter(object sender, EventArgs e)
        {
            glowIntensity = 0;
            glowTimer.Start();
        }
        private void GlowWithoutInteruptions_MouseEnter(object sender, EventArgs e)
        {
            glowTimer.Start();
        }

        private void UcCredentials_MouseLeave(object sender, EventArgs e)
        {
            glowIntensity = 0;
            glowTimer.Stop();
            ucCredentials.Invalidate();
        }

        private void GlowTimer_Tick(object sender, EventArgs e)
        {
            if (glowIntensity < maxGlowIntensity)
            {
                glowIntensity += 0.13;
                ucCredentials.Invalidate();
            }
            else
            {
                glowTimer.Stop();
            }
        }

        private void UcCredentials_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb((int)(glowIntensity * 255), Color.Orange)))
            {
                int glowSize = 10;
                e.Graphics.FillRectangle(brush, ClientRectangle.X - glowSize, ClientRectangle.Y - glowSize,
                                       ClientRectangle.Width + 2 * glowSize, ClientRectangle.Height + 2 * glowSize);
            }
        }
        private void UcCredentials_Click(object sender, EventArgs e)
        {
            if (logoutButton == false)
            {
                ucCredentials.BackColor = SystemColors.ScrollBar;
                logoutButton = true;
                ucLogOut.Visible = false;
            }
            else if (logoutButton == true)
            {
                ucCredentials.BackColor = Color.Orange;
                logoutButton = false;
                ucLogOut.Visible = true;
            }
        }
        private void UcLogOut_LogOut_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            RemoveLecturers();
            RemoveSubjects();
            RemoveNotifications();
            this.Controls.Add(pnlProfile);
            btnProfile.BackColor = Color.Orange;
            btnNotifications.BackColor = Color.White;
            btnSubjects.BackColor = Color.White;
            btnLecturers.BackColor = Color.White;
            Profile();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            RemoveProfile();
            RemoveLecturers();
            RemoveSubjects();
            this.Controls.Add(flpNotifications);
            btnProfile.BackColor = Color.White;
            btnNotifications.BackColor = Color.Orange;
            btnSubjects.BackColor = Color.White;
            btnLecturers.BackColor = Color.White;
            Notifications();
            this.Controls.Add(btnAddNotification);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            RemoveProfile();
            RemoveNotifications();
            RemoveLecturers();
            this.Controls.Add(pnlSubjects);
            btnProfile.BackColor = Color.White;
            btnNotifications.BackColor = Color.White;
            btnSubjects.BackColor = Color.Orange;
            btnLecturers.BackColor = Color.White;
            Subjects();
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            RemoveProfile();
            RemoveNotifications();
            RemoveSubjects();
            this.Controls.Add(pnlLecturers);
            btnProfile.BackColor = Color.White;
            btnNotifications.BackColor = Color.White;
            btnSubjects.BackColor = Color.White;
            btnLecturers.BackColor = Color.Orange;
            Lecturers();
        }
        private void RemoveLecturers()
        {
            this.Controls.Remove(pnlLecturers);
        }
        private void RemoveSubjects()
        {
            this.Controls.Remove(pnlSubjects);
        }
        private void RemoveNotifications()
        {
            this.Controls.Remove(btnAddNotification);
            this.Controls.Remove(flpNotifications);
        }
        private void RemoveProfile()
        {
            this.Controls.Remove(pnlProfile);
        }
        private void BtnAddNotification_Click(object sender, EventArgs e)
        {
            CreateNotification createNotification = new CreateNotification();
            createNotification.ShowDialog();

            if (createNotification.Create == true)
            {
                Notification notification = createNotification.Msg;
                Notice(notification);
            }
        }

        private void BtnInsertSubject_Click(object sender, EventArgs e)
        {
            CourseManagerForm insertSubject = new CourseManagerForm();
            insertSubject.ShowDialog();
            FillSubjectList();
        }
        ///-----------------------------------------------------
        private void BtnUpdateSubject_Click(object sender, EventArgs e)
        {
            foreach (Course subjecti in subjects)
            {
                if (subjecti.Title == subject.Title && subjecti.Ects == subject.Ects)
                {
                    CourseManagerForm updateSubject = new CourseManagerForm(subjecti.Title, subjecti.Ects);
                    updateSubject.ShowDialog();
                }
            }
            FillSubjectList();
        }

        private void FillSubjectList()
        {
            listSubjects.Items.Clear();
            subjects.Clear();
            subjects = Course.GetSubjects();
            foreach (Course subject in subjects)
            {
                listSubjects.Items.Add(subject);
            }
        }

        private void BtnDeleteSubject_Click(object sender, EventArgs e)
        {
            listSubjects.Items.RemoveAt(selectedSubValue);
            subjects.Clear();
            foreach (object item in listSubjects.Items)
            {
                string value = item.ToString();
                string[] details = value.Split('-');
                subjects.Add(new Course(details[0].Trim(), int.Parse(details[1].Trim())));
                Course.StoreSubjects(subjects);
            }
            selectedSubValue = 0;
        }
        //--------------------------------------------------------------
        private void BtnInsertLecturer_Click(object sender, EventArgs e)
        {
            LecturerManagerForm insertLecturer = new LecturerManagerForm();
            insertLecturer.ShowDialog();
            listLecturers.Items.Clear();
            lecturers.Clear();
            lecturers = Account.GetAccounts();
            foreach (Account lecturer in lecturers)
            {
                listLecturers.Items.Add(lecturer);
            }
        }

        private void BtnUpdateLecturer_Click(object sender, EventArgs e)
        {
            foreach (Account lectureri in lecturers)
            {
                if (lectureri.FirstName == lecturer.FirstName && lectureri.LastName == lecturer.LastName)
                {
                    LecturerManagerForm insertLecturer = new LecturerManagerForm(lecturer.FirstName, lecturer.LastName, lecturer.Email, lecturer.Password, lecturer.Course);
                    insertLecturer.ShowDialog();
                }
            }
            listLecturers.Items.Clear();
            lecturers.Clear();
            lecturers = Account.GetAccounts();
            foreach (Account lecturer in lecturers)
            {
                listLecturers.Items.Add(lecturer);
            }
        }

        private void BtnDeleteLecturer_Click(object sender, EventArgs e)
        {
            listLecturers.Items.RemoveAt(selectedLectValue);
            foreach (Account lectureri in lecturers)
            {
                if (lecturer.FirstName == lecturer.FirstName && lecturer.LastName == lecturer.LastName)
                {
                    lecturers.Remove(lectureri);
                }
            }
            //lecturers.RemoveAt(selectedLectValue);

            Account.StoreLecturers(lecturers);
            selectedLectValue = 0;
        }
        private void ListSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSubjects.SelectedItem != null)
            {
                selectedSubValue = listSubjects.SelectedIndex;
                subject = (Course)listSubjects.SelectedItem;
            }
        }
        private void ListLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLecturers.SelectedItem != null)
            {
                selectedLectValue = listLecturers.SelectedIndex;
                lecturer = (Account)listLecturers.SelectedItem;
            }
        }

    }
}