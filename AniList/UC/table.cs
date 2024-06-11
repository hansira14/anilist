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
    public partial class table : UserControl
    {
        public table(int x, string z, int count = 0)
        {
            InitializeComponent();
            retrieve.LoadTrendingAnime(tablee, x, count);
            list.Text = z;
            if (z.Contains("Trending")) seemore.Visible = false;
        }
        private const int ScrollAmount = 750;
        private void prev_Click(object sender, EventArgs e)
        {
            int newX = Math.Min(tablee.Location.X + ScrollAmount, 0);
            tablee.Location = new Point(newX, tablee.Location.Y);
        }

        private void next_Click(object sender, EventArgs e)
        {
            int maxLeft = panel.Width - tablee.Width;
            if (maxLeft > 0) maxLeft = 0;
            int newX = Math.Max(tablee.Location.X - ScrollAmount, maxLeft);
            tablee.Location = new Point(newX, tablee.Location.Y);
        }

        private void tablee_MouseEnter(object sender, EventArgs e)
        {
            prev.Visible = true;
            next.Visible = true;
        }

        private void tablee_MouseLeave(object sender, EventArgs e)
        {
            if (!tablee.ClientRectangle.Contains(tablee.PointToClient(Control.MousePosition)))
            {
                prev.Visible = false;
                next.Visible = false;
            }
        }
        private void seemore_Click_1(object sender, EventArgs e)
        {
            List<Anime> searchresults = retrieve.GetList(99);
            tableFav results = new tableFav(searchresults, 1);
            if (list.Text.Contains("Top airing"))
            {
                results.status.SelectedIndex = 1;
                results.sort.SelectedIndex = 5;
            }
            else if (list.Text.Contains("Most popular")) results.sort.SelectedIndex = 5;
            else if (list.Text.Contains("Most favorited")) results.sort.SelectedIndex = 9;


            if (list.Text.Contains("(Series)")) results.type.SelectedIndex = 0;
            else if (list.Text.Contains("(Movies)")) results.type.SelectedIndex = 1;
            else if (list.Text.Contains("(Others)")) results.type.SelectedIndex = 2;

            results.panel3.Size = new Size(1060, 101);
            dashboard.Dash.addUC(results);
        }
    }
}
