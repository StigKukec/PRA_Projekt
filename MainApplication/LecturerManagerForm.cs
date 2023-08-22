using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace MainApplication
{
    public partial class LecturerManagerForm : Form
    {
        private readonly string lecturer = "lecturer";
        private readonly bool create;
        private readonly bool update;
        private readonly string firstname;
        private readonly string lastname;
        private readonly List<Account> accounts;
        private List<Course> courses;
        private readonly StringBuilder sb = new();

        public LecturerManagerForm(string firstName, string lastName, string email, string password, string courses)
        {
            accounts = Account.GetAccounts();
            this.firstname = firstName;
            this.lastname = lastName;
            update = true;
            InitializeComponent();
            FillCourses();
            tbEmail.Text = email;
            tbPassword.Text = password;
            tbLectFirstName.Text = firstName;
            tbLectLastName.Text = lastName;
            tbChoosenCourses.Text = courses;
        }
        public LecturerManagerForm()
        {
            create = true;
            InitializeComponent();
            FillCourses();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (create == true)
            {
                CreateLecturer();
            }
            if (update == true)
            {
                UpdateLecturer();
            }
            this.Close();
        }

        private void CreateLecturer()
        {
            Account.StoreLecturer(new Account(tbLectFirstName.Text, tbLectLastName.Text, tbEmail.Text, tbPassword.Text, lecturer, tbChoosenCourses.Text));
        }

        private void UpdateLecturer()
        {
            foreach (Account account in accounts)
            {
                if (firstname == account.FirstName && lastname == account.LastName)
                {
                    account.FirstName = tbLectFirstName.Text;
                    account.LastName = tbLectLastName.Text;
                    account.Email = tbEmail.Text;
                    account.Password = tbPassword.Text;
                    account.Course = tbChoosenCourses.Text;
                }
            }
            Account.StoreLecturers(accounts);
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            String course = cbCourses.SelectedItem.ToString();

            int length = sb.Length;
            if (length == 0)
            {
                sb.Append(course);
            }
            else if (length > 1)
            {
                sb.Append(", " + course);
            }

            tbChoosenCourses.Text = sb.ToString();
        }

        private void btnClearChoosenCourses_Click(object sender, EventArgs e)
        {
            tbChoosenCourses.Clear();
        }

        private void FillCourses()
        {
            courses = Course.GetSubjects();
            cbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourses.Items.AddRange(courses.Select(x => x.Title).ToArray());
            cbCourses.SelectedItem = lecturer;
        }
       
    }
}
