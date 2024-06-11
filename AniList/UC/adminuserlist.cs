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
    public partial class adminuserlist : UserControl
    {
        List<User> userlist;
        string searchText;
        public adminuserlist()
        {
            InitializeComponent();
            userlist = retrieve.GetUserlist();
            Display();
        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genre.SelectedIndex == 0)
            {
                //sort List<User> userlist by Name (property) asc
                userlist = userlist.OrderBy(user => user.Name).ToList();
            }
            else if (genre.SelectedIndex == 1)
            {
                //sort by name desc
                userlist = userlist.OrderByDescending(user => user.Name).ToList();
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
                userlist = userlist.OrderByDescending(user => user.Joined).ToList();
            }
            else if (genre.SelectedIndex == 5)
            {
                //sort by Joined (datetime) asc
                userlist = userlist.OrderBy(user => user.Joined).ToList();
            }
            else if (genre.SelectedIndex == 6)
            {
                //sort by Animecount (int) asc
                userlist = userlist.OrderBy(user => user.Animecount).ToList();
            }
            else if (genre.SelectedIndex == 7)
            {
                //sort by Animecount (int) desc
                userlist = userlist.OrderByDescending(user => user.Animecount).ToList();
            }

            Display();
            Filter();
        }
        void Filter()
        {
            if (searchText == null) return;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is user userr)
                {
                    bool matchFound = userr.Namee.ToLower().Contains(searchText) || userr.Username.ToLower().Contains(searchText) || userr.Dt.ToLower().Contains(searchText);
                    userr.Visible = matchFound;
                }
            }
        }
        void Display()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (User user in userlist)
            {
                user us = new user(user);
                flowLayoutPanel1.Controls.Add(us);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
             searchText = search.Text.Trim().ToLower();
             Filter();
        }
    }
}
