using AniList.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class adminhome : UserControl
    {
        public adminhome()
        {
            InitializeComponent();
            List<User> userlist = retrieve.GetUserlist().Take(2).ToList();
            user us = new user(userlist[0]);
            user us2 = new user(userlist[1]);
            label2.Text = retrieve.Animecount().ToString("#,#");
            label5.Text = retrieve.Usercount().ToString() + " users";
            user1.Controls.Add(us);
            user2.Controls.Add(us2);
            List<Userlogs> ul=retrieve.GetUserlogs("SELECT * FROM UserLog");
            foreach(Userlogs x in ul)
            {
                adminactivity ac = new adminactivity(x);
                flowLayoutPanel1.Controls.Add(ac);
            }
            NewUsers();
        }
        void NewUsers()
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            OleDbDataReader reader;
            cmd.CommandText = "SELECT DateValue(joined) AS joinedDate, COUNT(*) AS dailyCount FROM Users GROUP BY DateValue(joined)";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> dayCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                dayCounts[reader[0].ToString()] = reader.GetInt32(1);
            }
            reader.Close();
            foreach (var day in dayCounts)
            {
                DateTime dt = DateTime.Parse(day.Key);
                chart1.Series[0].Points.AddXY(dt.ToString("MM/dd/yyyy"), day.Value);
            }
            dbc.con.Close();
        }

        private void guna2Panel2_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel2.FillColor=Color.FromArgb(239, 147, 98);
            label3.ForeColor = Color.FromArgb(18, 18, 18);
            label4.ForeColor = Color.FromArgb(113, 75, 55);
        }

        private void guna2Panel2_MouseLeave(object sender, EventArgs e)
        {
            if (!guna2Panel2.ClientRectangle.Contains(guna2Panel2.PointToClient(Control.MousePosition)))
            {
                guna2Panel2.FillColor = Color.FromArgb(18,18,18);
                label3.ForeColor = Color.FromArgb(228, 228, 228);
                label4.ForeColor = Color.FromArgb(239, 147, 98);
            }
        }

        private void guna2Panel4_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel4.FillColor = Color.FromArgb(239, 147, 98);
            label8.ForeColor = Color.FromArgb(18, 18, 18);
            label6.ForeColor = Color.FromArgb(113, 75, 55);
        }

        private void guna2Panel4_MouseLeave(object sender, EventArgs e)
        {
            if (!guna2Panel4.ClientRectangle.Contains(guna2Panel4.PointToClient(Control.MousePosition)))
            {
                guna2Panel4.FillColor = Color.FromArgb(18, 18, 18);
                label8.ForeColor = Color.FromArgb(228, 228, 228);
                label6.ForeColor = Color.FromArgb(239, 147, 98);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            adminanime aa = new adminanime();
            admin.ad.addUC(aa);
            admin.ad.anime.Checked = true;
        }

        private void guna2Panel4_Click(object sender, EventArgs e)
        {
            adminuser us = new adminuser();
            admin.ad.addUC(us);
            admin.ad.user.Checked = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text.Trim().ToLower();
            if (searchText == null) return;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is adminactivity act)
                {
                    bool matchFound = act.Names.ToLower().Contains(searchText) || act.Username.ToLower().Contains(searchText) || act.Dt.ToLower().Contains(searchText)|| act.Action.ToLower().Contains(searchText);
                    act.Visible = matchFound;
                }
            }
        }

        private void seemore_Click(object sender, EventArgs e)
        {
            adminuserlist aul = new adminuserlist();
            admin.ad.addUC(aul);
        }
    }
}
