using AniList.Forms;
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
    public partial class adminuser : UserControl
    {
        OleDbCommand cmd;
        OleDbDataReader reader;
        public adminuser()
        {
            InitializeComponent();
            label3.Text = retrieve.Usercount().ToString();
            dbc.Connect();
            dbc.con.Open();
            cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            NewUsers();UserLogsPerDay();
            dbc.con.Close();
        }
        void NewUsers()
        {
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
                rel.Series[0].Points.AddXY(dt.ToString("MM/dd/yyyy"), day.Value);
            }
        }

        void UserLogsPerDay()
        {
            cmd.CommandText = "SELECT DateValue([datetime]) AS datetimeDate, COUNT(*) AS dailyCount FROM UserLog GROUP BY DateValue([datetime])";
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminuserlist aul = new adminuserlist();
           admin.ad.addUC(aul);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminloglist all = new adminloglist();
            admin.ad.addUC(all);
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            edit.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (!pictureBox2.ClientRectangle.Contains(pictureBox2.PointToClient(Control.MousePosition)))
            {
                edit.Visible = false;
            }
        }
        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            addd.Visible = true;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            if (!pictureBox1.ClientRectangle.Contains(pictureBox1.PointToClient(Control.MousePosition)))
            {
                addd.Visible = false;
            }
        }
    }
}
