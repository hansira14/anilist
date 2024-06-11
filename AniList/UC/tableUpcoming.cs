using Guna.UI2.WinForms;
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
    public partial class tableUpcoming : UserControl
    {
        string type;
        public tableUpcoming(List<Anime> list, string s=null)
        {
            InitializeComponent();
            header.Text = s;
            type = s;
            table.RowCount = 2; table.ColumnCount = 5;
            foreach (Anime anime in list)
            {
                animePic ani = new animePic(anime);
                ani.Margin = new Padding(15, 15, 15, 15);
                table.Controls.Add(ani);
            }
        }
        private void seemore_Click_1(object sender, EventArgs e)
        {
            List<Anime> searchresults = retrieve.GetList(99); ;
            tableFav results = null;
            switch (type)
            {
                case "Top Upcoming Movies":
                    results = new tableFav(searchresults, 1);
                    results.type.SelectedIndex = 1;
                    break;
                case "Top Upcoming Series":
                    results = new tableFav(searchresults, 1);
                    results.type.SelectedIndex = 0;
                    break;
                case "Top Upcoming Others":
                    results = new tableFav(searchresults, 1);
                    results.type.SelectedIndex = 2;
                    break;
                default:
                    results = new tableFav(searchresults, 1);
                    break;
            }
            results.panel3.Size = new Size(1060, 101);
            results.status.SelectedIndex = 2;
            results.sort.SelectedIndex = 5;
            dashboard.Dash.addUC(results);
        }
    }
}
