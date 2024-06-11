using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class watchbutton : UserControl
    {
        int x;
        string Title;
        public watchbutton(string title, int i=0)
        {
            x = i;
            Title = title;
            InitializeComponent();
            epsbutton.Text = i.ToString();
        }

        private void epsbutton_Click(object sender, EventArgs e)
        {
            string url = Title.ToLower();
            url = Regex.Replace(url, @"[^\w\s-]", ""); // remove special characters
            url = Regex.Replace(url, @"\s+", " "); // replace multiple spaces with a single space
            url = url.Replace(" ", "-"); // replace spaces with hyphens
            url = url.Replace("--", "-"); // replace double hyphens with a single one
            url = url.Replace("--", "-"); // replace double hyphens with a single one
            url = "https://animezia.com/watch/" + url + "-episode-" + epsbutton.Text.ToString();
            System.Diagnostics.Process.Start(url);
        }
    }
}
