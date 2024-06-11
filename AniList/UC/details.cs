using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AniList.UC
{
    public partial class details : UserControl
    {
        public details(string t, string e, string s, string ty, string eps, string rn, string gn)
        {
            InitializeComponent();
            if (e == "N/A" || e=="") e = t;
            title.Text = e; tstudio.Text = s;
            if (eps == "0") eps = "?";
            type.Text = ty + "  •  " + eps + " episodes ";
            rank.Text = "#"+rn;
            string[] genres = gn.Split(',');
            int count = 0;
            for (int i = 0; i < genres.Length; i++)
            {
                if (genres[i].Trim() == "Award Winning")
                    continue;
                count++;
                if (count == 1)
                    genre1.Text = genres[i].Trim();
                else if (count == 2)
                    genre2.Text = genres[i].Trim();
                else if (count == 3)
                    genre3.Text = genres[i].Trim();
                if (count == 3) break;
            }

        }
        private void details_Load(object sender, EventArgs e)
        {
            AA.SetRoundedRegion(this, 15);
        }
    }
}
