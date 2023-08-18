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
    public partial class CourseManagerForm : Form
    {
        private readonly bool create;
        private readonly bool update;
        private string title;
        private int ects;
        private List<Course> subjects = Course.GetSubjects();

        public CourseManagerForm(string title, int ects)
        {
            this.title = title;
            this.ects = ects;
            update = true;
            InitializeComponent();
            tbSubjectTitle.Text = title;
            nudEctsNumber.Value = ects;
        }

        public CourseManagerForm()
        {
            create = true;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (create == true)
            {
                CreateSubject();
            }
            if (update == true)
            {
                UpdateSubject();
            }
            this.Close();
        }

        private void UpdateSubject()
        {
            foreach (Course subject in subjects)
            {
                if (title == subject.Title && ects == subject.Ects)
                {
                    subject.Title = tbSubjectTitle.Text;
                    subject.Ects = int.Parse(nudEctsNumber.Text);
                }
            }
            Course.StoreSubjects(subjects);
        }

        private void CreateSubject()
        {
            Course.StoreSubject(new Course(tbSubjectTitle.Text, int.Parse(nudEctsNumber.Controls.Owner.Text)));
        }
    }
}
