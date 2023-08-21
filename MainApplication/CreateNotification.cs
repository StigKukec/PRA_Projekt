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
    public partial class CreateNotification : Form
    {
        private const string all = "Svi";
        public bool Create { get; set; }
        public Notification Msg { get; set; }
        private List<Course> courses;
        public CreateNotification()
        {
            InitializeComponent();
            courses?.Clear();
            cbCourse.Items.Add(all);
            cbCourse.SelectedItem = all;
            courses = Course.GetSubjects();
            cbCourse.Items.AddRange(courses.Select(x => x.Title).ToArray());
            Create = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Create = false;
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(tbMessageTitle.Text, rtbMessage.Text, cbCourse.SelectedItem.ToString());
            Msg = notification;
            notification.StoreNotification(notification);
            Create = true;
            this.Close();
        }
    }
}
