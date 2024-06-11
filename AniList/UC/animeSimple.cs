using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class animeSimple : UserControl
    {
        Anime aa;
        public animeSimple(Anime aa)
        {
            InitializeComponent();
            this.aa = aa;
            AA.SetRoundedRegion(this, 10);
              if(aa.Poster!="")pictureBox1.ImageLocation = aa.Poster;
            else if (aa.Pic != null) pictureBox1.Image = aa.Pic;
            else pictureBox1.ImageLocation = aa.Poster;
            if (login.adminmode == true)
            {
                pictureBox1.MouseClick -= pictureBox1_MouseClick;
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            animepage anip = new animepage(aa);
            dashboard.Dash.addUC(anip);
        }
    }
}
