using AniList.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AniList.UC
{
    public partial class adminactivity : UserControl
    {
        public string Username;
        public string Names;
        public string Action;
        public string Dt;
        public adminactivity(Userlogs ul)
        {
            InitializeComponent();
            User user = retrieve.GetUser(ul.Username);
            Username = ul.Username;
            Names = name.Text = $"{user.Fname} {user.Lname}";
            username.Text=ul.Username;
            date.Text=ul.Dt.ToString();
            Dt = ul.Dt.ToString("MMM dd, yyyy");
            Action=action.Text = ul.Action;
            pic.Image = user.Pic;
        }

        private void adminactivity_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(239, 147, 98);
            name.ForeColor = Color.FromArgb(25, 25, 25);
            date.ForeColor = Color.FromArgb(25, 25, 25);
            action.ForeColor = Color.FromArgb(25, 25, 25);
            panel.FillColor=Color.FromArgb(178, 107, 77);
            username.ForeColor = Color.Black;
        }

        private void adminactivity_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                name.ForeColor = Color.FromArgb(239, 147, 98);
                date.ForeColor = Color.Silver;
                action.ForeColor = Color.Silver;
                panel.FillColor = Color.FromArgb(18,18,18);
                username.ForeColor =  Color.Silver;
            }
        }

        private void username_Click(object sender, EventArgs e)
        {
            userprofile up = new userprofile(Username);
            admin.ad.page.AutoScroll = false;
            admin.ad.addUC(up);
        }
    }
}
