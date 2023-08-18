using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class Credentials : UserControl
    {
        private string credentials;
        public string Credential
        {
            set
            {
                credentials = value;
                FillCredentials();
            }
        }
        public EventHandler GlowEvent
        {
            set
            {
                lblCredentials.MouseEnter += value;
                lblUserIcon.MouseEnter += value;
            }
        }

        public Credentials()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                Image = Properties.Resources.user_icon
            };
            lblUserIcon.Controls.Add(pictureBox);

        }
        private void FillCredentials()
        {
            if (credentials == null)
            {
                lblCredentials.Text = "Greška";
            }
            else
            {
                lblCredentials.Text = credentials;
            }
        }

    }
}
