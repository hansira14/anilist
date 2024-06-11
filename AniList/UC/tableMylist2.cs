using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AniList.UC
{
    public partial class tableMylist2 : UserControl
    {
        List<Youranime> final = null;
        List<Youranime> yanime;
        string selectedType = null;
        string selectedGenre = null;
        string selectedYear = null;
        string sortby = null;
        string Q;
        string User = null;
        public tableMylist2(string q = null, string user=null)
        {
            Q = q;
            InitializeComponent();
            User = user;
        }
        private void table3_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        public void RefreshList()
        {
            if(User!=null) yanime = retrieve.GetYouranime(null, User);
            else yanime = retrieve.GetYouranime();
            switch (Q)
            {
                case "Watching":
                    final = yanime.Where(y => y.Status == "Watching").ToList();
                    ww.Checked = true;
                    break;
                case "Completed":
                    final = yanime.Where(y => y.Status == "Completed").ToList();
                    cc.Checked = true;
                    break;
                case "Paused":
                    final = yanime.Where(y => y.Status == "Paused").ToList();
                    pp.Checked = true;
                    break;
                case "Dropped":
                    final = yanime.Where(y => y.Status == "Dropped").ToList();
                    dd.Checked = true;
                    break;
                case "Plans to watch":
                    final = yanime.Where(y => y.Status == "Plans to watch").ToList();
                    pl.Checked = true;
                    break;
                case "":
                    final = yanime; all.Checked = true;
                    break;
                default:
                    final = yanime; all.Checked = true;
                    break;
            }
            Filter();
        }
        void Display()
        {
            foreach (Control control in flowLayoutPanel1.Controls.OfType<animeMylist>().ToList())
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            for (int i = 0; i < final.Count; i++)
            {
                Youranime z = final[i];
                animeMylist ani = new animeMylist(z);
                if (final.Count > 4)
                {
                    if (i >= final.Count - 2) ani.y = +150;
                    else ani.y = -82;
                }
                else ani.y = -82;
                ani.x = 0;
                AddControlToFlowLayout(ani);
            }

        }
        private void AddControlToFlowLayout(Control controlToAdd)
        {
            flowLayoutPanel1.Controls.Add(controlToAdd);
            int totalHeight = flowLayoutPanel1.Controls.Cast<Control>().Sum(control => control.Height);
            this.Height = totalHeight;
        }


        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedIndex == -1) return;
            selectedType = type.SelectedItem.ToString();
            RefreshList();
            ttb.Visible = true;
        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genre.SelectedIndex == -1) return;
            selectedGenre = genre.SelectedItem.ToString();
            RefreshList();
            ggb.Visible = true;
        }

        private void year_Scroll(object sender, ScrollEventArgs e)
        {
            if (yr.Text == null) return;
            yr.Text = year.Value.ToString();
            yyb.Visible = true;
            selectedYear = year.Value.ToString();
            RefreshList();
        }

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sort.SelectedIndex == -1) return;
            sortby = sort.SelectedItem.ToString();
            RefreshList();
            ssb.Visible = true;
        }

        private void all_Click(object sender, EventArgs e)
        {
            Q = "";
            RefreshList();
        }

        private void ww_Click(object sender, EventArgs e)
        {
            Q = "Watching";
            RefreshList();
        }

        private void cc_Click(object sender, EventArgs e)
        {
            Q = "Completed";
            RefreshList();
        }

        private void pp_Click(object sender, EventArgs e)
        {
            Q = "Paused";
            RefreshList();
        }

        private void dd_Click(object sender, EventArgs e)
        {
            Q = "Dropped";
            RefreshList();
        }

        private void pl_Click(object sender, EventArgs e)
        {
            Q = "Plans to watch";
            RefreshList();
        }

        private void ttb_Click(object sender, EventArgs e)
        {
            type.SelectedIndex = -1;
            selectedType = null;
            ttb.Visible = false;
            RefreshList();
        }

        private void ggb_Click(object sender, EventArgs e)
        {
            genre.SelectedIndex = -1;
            selectedGenre = null;
            ggb.Visible = false;
            RefreshList();
        }

        private void yyb_Click(object sender, EventArgs e)
        {
            year.Value = 1900;
            yr.Text = "";
            selectedYear = null;
            yyb.Visible = false;
            RefreshList();
        }

        private void ssb_Click(object sender, EventArgs e)
        {
            sort.SelectedIndex = -1;
            sortby = null;
            ssb.Visible = false;
            RefreshList();
        }
        void Filter()
        {
            if (selectedType != null)
                final = final.Where(y => y.anime.Type == selectedType).ToList();

            if (selectedGenre != null)
                final = final.Where(y => y.anime.Genre.Contains(selectedGenre)).ToList();

            if (selectedYear != null)
            {
                int year = int.Parse(selectedYear);
                final = final.Where(y => y.anime.Aired.Year == year).ToList();
            }

            if (sortby != null)
            {
                switch (sortby)
                {
                    case "Name Asc":
                        final = final.OrderBy(y => y.anime.Title).ToList();
                        break;
                    case "Name Desc":
                        final = final.OrderByDescending(y => y.anime.Title).ToList();
                        break;
                    case "Progress":
                        final = final.OrderByDescending(y => y.Progress).ToList();
                        break;
                    case "Start Date":
                        final = final.OrderByDescending(y => y.Started).ToList();
                        break;
                    case "Completed Date":
                        final = final.OrderByDescending(y => y.Finished).ToList();
                        break;
                    case "Status":
                        final = final.OrderByDescending(y => y.Status).ToList();
                        break;
                    default: break;
                }
            }
            Display();
        }
        private void yr_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(yr.Text, out int result) && result > 1900 && result <= 2023)
            {
                year.Value = result;
            }
        }
        private void year_ValueChanged(object sender, EventArgs e)
        {
            if (yr.Text == null) return;
            yyb.Visible = true;
            selectedYear = year.Value.ToString();
            Filter();
        }
    }
}
