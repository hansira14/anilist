using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;


namespace AniList.UC
{
    public partial class home : System.Windows.Forms.UserControl
    {
        public home(string type)
        {
            InitializeComponent();
            switch (type)
            {
                case "home": Homepage();
                    break;
                case "series": Series();
                    break;
                case "movies": Movies();
                    break;
                case"others": Others();
                    break;
                case "Watching":
                    MessageBox.Show(type);
                    MessageBox.Show(login.loginuser);
                    tableMylist nn = new tableMylist($"SELECT * FROM MyList WHERE username='{login.loginuser}' AND status='Watching'");
                    flowLayoutPanel1.Controls.Add(nn);
                    break;
            }
        }
        void Homepage()
        {
            featured feat = new featured();
            flowLayoutPanel1.Controls.Add(feat);
            table trending = new table(4, "Trending now", 10);
            flowLayoutPanel1.Controls.Add(trending);
            tableRank toprank = new tableRank(6, "Top Ranked", 10);
            flowLayoutPanel1.Controls.Add(toprank);
            table topair = new table(1, "Top airing", 10);
            flowLayoutPanel1.Controls.Add(topair);
            table popu = new table(2, "Most popular", 20);
            flowLayoutPanel1.Controls.Add(popu);
            table fav = new table(3, "Most favorited", 20);
            flowLayoutPanel1.Controls.Add(fav);
 
            List<Anime> searchresults = retrieve.GetList(21, 10);
            tableUpcoming upcoming = new tableUpcoming(searchresults, "Top Upcoming");
            flowLayoutPanel1.Controls.Add(upcoming);
        }
        void Series()
        {
            featured feat = new featured();
            flowLayoutPanel1.Controls.Add(feat);
            table trending = new table(4, "Trending now (Series)", 10);
            flowLayoutPanel1.Controls.Add(trending);
            tableRank toprank = new tableRank(9, "Top Ranked (Series)", 10);
            flowLayoutPanel1.Controls.Add(toprank);
            table topair = new table(1, "Top airing (Series)", 10);
            flowLayoutPanel1.Controls.Add(topair);
            table popu = new table(7, "Most popular (Series)", 20);
            flowLayoutPanel1.Controls.Add(popu);
            table fav = new table(8, "Most favorited (Series)", 20);
            flowLayoutPanel1.Controls.Add(fav);

            List<Anime> searchresults = retrieve.GetList(88, 0, "SELECT TOP 10 * FROM Animelist WHERE status = 'Not yet aired' AND type = 'TV' ORDER BY users DESC");
            tableUpcoming upcoming = new tableUpcoming(searchresults, "Top Upcoming Series");
            flowLayoutPanel1.Controls.Add(upcoming);
        }
        void Movies()
        {
            featured feat = new featured(13);
            flowLayoutPanel1.Controls.Add(feat);
            table trending = new table(19, "Trending now (Movies)", 10);
            flowLayoutPanel1.Controls.Add(trending);
            tableRank toprank = new tableRank(12, "Top Ranked (Movies)", 10);
            flowLayoutPanel1.Controls.Add(toprank);
            table popu = new table(10, "Most popular (Movies)", 20);
            flowLayoutPanel1.Controls.Add(popu);
            table fav = new table(11, "Most favorited (Movies)", 20);
            flowLayoutPanel1.Controls.Add(fav);

            List<Anime> searchresults = retrieve.GetList(88, 0, "SELECT TOP 10 * FROM Animelist WHERE status = 'Not yet aired' AND type = 'Movie' ORDER BY users DESC");
            tableUpcoming upcoming = new tableUpcoming(searchresults, "Top Upcoming Movies");
            flowLayoutPanel1.Controls.Add(upcoming);
        }
        void Others()
        {
            featured feat = new featured(17);
            flowLayoutPanel1.Controls.Add(feat);
            table trending = new table(20, "Trending now (Others)", 10);
            flowLayoutPanel1.Controls.Add(trending);
            tableRank toprank = new tableRank(16, "Top Ranked (Others)", 10);
            flowLayoutPanel1.Controls.Add(toprank);
            table topair = new table(18, "Top airing (Others)", 10);
            flowLayoutPanel1.Controls.Add(topair);
            table popu = new table(14, "Most popular (Others)", 20);
            flowLayoutPanel1.Controls.Add(popu);
            table fav = new table(15, "Most favorited (Others)", 20);
            flowLayoutPanel1.Controls.Add(fav);

            List<Anime> searchresults = retrieve.GetList(88, 0, "SELECT TOP 10 * FROM Animelist WHERE status = 'Not yet aired' AND type NOT IN ('TV', 'Movie') ORDER BY users DESC");
            tableUpcoming upcoming = new tableUpcoming(searchresults, "Top Upcoming Others");
            flowLayoutPanel1.Controls.Add(upcoming);
        }
    }
}
