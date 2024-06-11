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

namespace AniList.UC
{
    public partial class user : UserControl
    {
        User User;
        public string Username;
        public string Dt;
        public string Namee;
        public user(User user)
        {
            login.loginuser=user.Username;
            InitializeComponent();
            AA.SetRoundedRegion(this, 8);
            User = user;
            pic.Image = user.Pic;
            name.Text = $"{user.Fname} {user.Lname}";
            Namee = name.Text;
            usernamee.Text="@"+user.Username;
            Username = user.Username;
            join.Text = user.Joined.ToString("MMM dd, yyyy");
            Dt = join.Text;
            animecount.Text = user.Animecount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            userprofile up=new userprofile(User.Username);
            admin.ad.page.AutoScroll = false;
            admin.ad.addUC(up);
        }

        private void user_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(18,18,18);
            name.ForeColor= Color.FromArgb(239, 147, 98);
            usernamee.ForeColor= Color.FromArgb(239, 147, 98);
            asd.ForeColor= Color.FromArgb(239, 147, 98);
            animecount.ForeColor = Color.FromArgb(239, 147, 98);
        }

        private void user_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                this.BackColor = Color.FromArgb(239, 147, 98);
                name.ForeColor = Color.FromArgb(18, 18, 18);
                usernamee.ForeColor = Color.FromArgb(113, 75, 55);
                asd.ForeColor = Color.FromArgb(113, 75, 55);
                animecount.ForeColor = Color.FromArgb(18,18,18);
            }
        }
    }
}
