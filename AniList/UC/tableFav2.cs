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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AniList.UC
{
    public partial class tableFav2 : UserControl
    {
        List<Anime> final = null;
        public string selectedType = null;
        public string selectedGenre = null;
        public string selectedYear = null;
        public string selectedTheme = null;
        public string selectedStatus = null;
        public string sortby = null;
        private List<Anime> animeList;
        private int currentAnimeIndex = 0, X=0;
        private const int batchSize = 50;

        public tableFav2(List<Anime> list, int x=0)
        {
            InitializeComponent();
            this.animeList = list;
            this.next.Visible = false;
            X = x;
        }

        private void AddNextBatch(int x=0)
        {
            table.ColumnCount = 5;
            int endIndex;
            if (final == null) final = animeList;
            table.Controls.Clear();
            if(x==0) currentAnimeIndex=0;
            if(x==1) currentAnimeIndex = currentAnimeIndex - batchSize;
            endIndex = Math.Min(currentAnimeIndex + batchSize, final.Count);
            table.RowCount = (endIndex-currentAnimeIndex) / 5;
            if ((endIndex - currentAnimeIndex) % 5 != 0) table.RowCount++;
            for (int i = currentAnimeIndex; i < endIndex; i++)
            {
                animePic ani = new animePic(final[i]);
                ani.Margin = new Padding(15, 15, 15, 15);
                table.Controls.Add(ani);
            }
            currentAnimeIndex = endIndex;
            if (currentAnimeIndex < final.Count) this.next.Visible = true;
            else this.next.Visible = false;
            this.Height = 155 + table.Height;
        }
        private void table4_Load(object sender, EventArgs e)
        {
            AddNextBatch();
            panel.Controls.Add(next);
            next.SendToBack();
            panel3.BringToFront();
        }
        void Filter(int x = 0)
        {
            final = new List<Anime>(animeList);

            if (selectedType != null)
            {
                if (selectedType == "Others") final = final.Where(y => y.Type != "TV" && y.Type != "Movie").ToList();
                else final = final.Where(y => y.Type == selectedType).ToList();
            }

            if (selectedGenre != null)
                final = final.Where(y => y.Genre.Contains(selectedGenre)).ToList();

            if (selectedYear != null)
            {
                int year = int.Parse(selectedYear);
                final = final.Where(y => y.Aired.Year == year).ToList();
            }
            if (selectedTheme != null)
            {
                final = final.Where(y => y.Theme.Contains(selectedTheme)).ToList();
            }
            if (selectedStatus!=null)
            {
                final = final.Where(y => y.Status.Contains(selectedStatus)).ToList();
            }

            if (sortby != null)
            {
                switch (sortby)
                {
                    case "Title Asc":
                        final = final.OrderBy(y => y.Title).ToList();
                        break;
                    case "Title Desc":
                        final = final.OrderByDescending(y => y.Title).ToList();
                        break;
                    case "Aired Date Asc":
                        final = final.OrderBy(y => y.Aired).ToList();
                        break;
                    case "Aired Date Desc":
                        final = final.OrderByDescending(y => y.Aired).ToList();
                        break;
                    case "Popularity Asc":
                        final = final.OrderBy(y => y.Users).ToList();
                        break;
                    case "Popularity Desc":
                        final = final.OrderByDescending(y => y.Users).ToList();
                        break;
                    case "Favorites Asc":
                        final = final.OrderBy(y => y.Favorites).ToList();
                        break;
                    case "Rating Asc":
                        final = final.OrderBy(y => y.Rating).ToList();
                        break;
                    case "Rating Desc":
                        final = final.OrderByDescending(y => y.Rating).ToList();
                        break;
                    case "Favorites Desc":
                        final = final.OrderByDescending(y => y.Favorites).ToList();
                        break;
                    default:
                        break;
                }
            }
            AddNextBatch(x);
        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genre.SelectedIndex == -1) return;
            selectedGenre = genre.SelectedItem.ToString();
            Filter();
            ggb.Visible = true;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedIndex == -1) return;
            selectedType = type.SelectedItem.ToString();
            Filter();
            ttb.Visible = true;
        }

        private void themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themes.SelectedIndex == -1) return;
            selectedTheme = themes.SelectedItem.ToString();
            Filter();
            thb.Visible = true;
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (year.SelectedIndex == -1) return;
            selectedYear = year.SelectedItem.ToString();
            Filter();
            yyb.Visible = true;
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status.SelectedIndex == -1) return;
            selectedStatus = status.SelectedItem.ToString();
            Filter();
            stb.Visible = true;
        }

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sort.SelectedIndex == -1) return;
            sortby = sort.SelectedItem.ToString();
            if(X==0) Filter(1);
            else Filter(0);
            ssb.Visible = true;
        }

        private void ggb_Click(object sender, EventArgs e)
        {
            genre.SelectedIndex = -1;
            selectedGenre = null;
            ggb.Visible = false;
            Filter();
        }

        private void ttb_Click(object sender, EventArgs e)
        {
            type.SelectedIndex = -1;
            selectedType = null;
            ttb.Visible = false;
            Filter();
        }

        private void thb_Click(object sender, EventArgs e)
        {
            themes.SelectedIndex = -1;
            selectedTheme = null;
            thb.Visible = false;
            Filter();
        }

        private void yyb_Click(object sender, EventArgs e)
        {
            year.SelectedIndex = -1;
            selectedYear = null;
            yyb.Visible = false;
            Filter();
        }

        private void stb_Click(object sender, EventArgs e)
        {
            status.SelectedIndex = -1;
            selectedStatus = null;
            stb.Visible = false;
            Filter();
        }

        private void ssb_Click(object sender, EventArgs e)
        {
            sort.SelectedIndex = -1;
            sortby = null;
            ssb.Visible = false;
            Filter();
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            AddNextBatch(2);
        }
    }
}
