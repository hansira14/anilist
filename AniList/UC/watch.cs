using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class watch : UserControl
    {
        Anime aa;
        public watch(Anime z)
        {
            aa = z;
            InitializeComponent();
            epsbutton.Text ="Watch "+ aa.Title;
            if(z.Status=="Finished Airing")
            {
                for (int i = 1; i <= z.Episodes; i++)
                {
                    watchbutton wb = new watchbutton(aa.Title, i);
                    flowLayoutPanel1.Controls.Add(wb);
                }
            }
        }

        private void epsbutton_Click(object sender, EventArgs e)
        {
            string url = aa.Title.ToLower();
            url = Regex.Replace(url, @"[^\w\s-]", ""); // remove special characters
            url = Regex.Replace(url, @"\s+", " "); // replace multiple spaces with a single space
            url = url.Replace(" ", "-"); // replace spaces with hyphens
            url = url.Replace("--", "-"); // replace double hyphens with a single one
            url = url.Replace("--", "-"); // replace double hyphens with a single one
            System.Diagnostics.Process.Start("https://animezia.com/watch/" + url);
        }
    }
}
