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
    public partial class genrebutton : UserControl
    {
        public genrebutton(string x)
        {
            InitializeComponent();
            guna2Button1.Text = x;
            if (login.adminmode == true)
            {

               guna2Button1.Click -= guna2Button1_Click;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //dashboard.Dash.searchresults = retrieve.GetList(88, 0, $"SELECT * FROM Animelist WHERE genre LIKE '%{guna2Button1.Text}%' OR themes LIKE '%{guna2Button1.Text}%'");
            dashboard.Dash.searchresults = retrieve.GetList(99, 0);
            dashboard.Dash.results = new tableFav(dashboard.Dash.searchresults);
            dashboard.Dash.results.table.Controls.Clear();
            dashboard.Dash.results.panel3.Size = new Size(1060, 101);
            int genreIndex = dashboard.Dash.results.genre.Items.Cast<string>().ToList().FindIndex(item => item.ToLower() == guna2Button1.Text.ToLower());
            if (genreIndex != -1) dashboard.Dash.results.genre.SelectedIndex = genreIndex;
            int themesIndex = dashboard.Dash.results.themes.Items.Cast<string>().ToList().FindIndex(item => item.ToLower() == guna2Button1.Text.ToLower());
            if (themesIndex != -1) dashboard.Dash.results.themes.SelectedIndex = themesIndex;
            dashboard.Dash.addUC(dashboard.Dash.results);
        }
    }
}
