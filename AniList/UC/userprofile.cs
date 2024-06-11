using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class userprofile : UserControl
    {
        string User = null;
        public userprofile(string user=null)
        {
            InitializeComponent();
            if(user!=null)login.loginuser = user;
            useroverview ov = new useroverview(user);
            User us=retrieve.GetUser(login.loginuser);
            here.Controls.Add(ov);
            User = user;
            username.Text = us.Username;
            pic.Image = us.Pic;
        }

        private void anilist_Click(object sender, EventArgs e)
        {
            here.Controls.Clear();
            tableMylist2 youranime = new tableMylist2(null, User);
            here.Controls.Add(youranime);
        }

        private void favorites_Click(object sender, EventArgs e)
        {
            here.Controls.Clear();
            List<Anime> searchresults = null;
            if(User==null) searchresults=retrieve.GetList(77, 0);
            else searchresults = retrieve.GetList(88, 0, $"SELECT F.animeid AS F_animeid, A.* FROM Favorites F INNER JOIN Animelist A ON F.animeid =A.animeid WHERE F.username = '{User}'");
            tableFav2 results = new tableFav2(searchresults);
            here.Controls.Add(results);
        }

        private void stats_Click(object sender, EventArgs e)
        {
            here.Controls.Clear();
            statsprofile stats = new statsprofile(User);
            here.Controls.Add(stats);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            here.Controls.Clear();
            useroverview ov = new useroverview(User);
            here.Controls.Add(ov);
        }
    }
}
