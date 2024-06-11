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
    public partial class adminloglist : UserControl
    {
        List<Userlogs> userlist;
        string searchText;
        public adminloglist()
        {
            InitializeComponent();
            userlist = retrieve.GetUserlogs("SELECT * FROM UserLog");
            Display();
        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genre.SelectedIndex == 0)
            {
                //sort List<User> userlist by Name (property) asc
                userlist = userlist.OrderBy(user => user.User.Name).ToList();
            }
            else if (genre.SelectedIndex == 1)
            {
                //sort by name desc
                userlist = userlist.OrderByDescending(user => user.User.Name).ToList();
            }
            else if (genre.SelectedIndex == 2)
            {
                //sort by  Username asc
                userlist = userlist.OrderBy(user => user.Username).ToList();
            }
            else if (genre.SelectedIndex == 3)
            {
                //sort by  Username desc
                userlist = userlist.OrderByDescending(user => user.Username).ToList();
            }
            else if (genre.SelectedIndex == 4)
            {
                //sort by Joined (datetime) desc
                userlist = userlist.OrderByDescending(user => user.Dt).ToList();
            }
            else if (genre.SelectedIndex == 5)
            {
                //sort by Joined (datetime) asc
                userlist = userlist.OrderBy(user => user.Dt).ToList();
            }

            Display();
            Filter();
        }
        void Filter()
        {
            if (searchText == null) return;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is adminactivity userr)
                {
                    bool matchFound = userr.Names.ToLower().Contains(searchText) || userr.Username.ToLower().Contains(searchText) || userr.Dt.ToLower().Contains(searchText);
                    userr.Visible = matchFound;
                }
            }
        }
        void Display()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Userlogs log in userlist)
            {
                adminactivity ac = new adminactivity(log);
                flowLayoutPanel1.Controls.Add(ac);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
             searchText = search.Text.Trim().ToLower();
             Filter();
        }
    }
}
