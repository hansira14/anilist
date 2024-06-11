using AniList.Forms;
using CefSharp.DevTools.Profiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class useroverview : UserControl
    {
        List<Userlogs> temp= new List<Userlogs>();
        string Fname, Lname, Email, User;
        DateTime Joined;
        public useroverview(string user=null)
        {
            InitializeComponent();
            if (login.adminmode == true) guna2Button1.Visible = false;
            if (user != null) User = user;
            temp=retrieve.GetUserlogs(null, user);
            List<Userlogs> logs = temp.Take(5).ToList();
            foreach (Userlogs log in logs)
            {
                log ll = new log(log);
                history.Controls.Add(ll);
            }
            List<Youranime> yanime= retrieve.GetYouranime(null, user).Take(5).ToList();
            foreach(Youranime y in yanime)
            {
                animeSimple ani= new animeSimple(y.anime);
                addedanime.Controls.Add(ani);
            }
            UserCredentials();
            fname.Text =Fname; lname.Text = Lname;
            email.Text = Email; join.Text = Joined.ToString("MM-dd-yyyy");
            TimeSpan accountAge = DateTime.Now - Joined;
            joindays.Text = accountAge.TotalDays.ToString("0") + "days";
        }
        public void UserCredentials()
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "SELECT fname, lname, email, joined FROM Users WHERE Username = @Username";
            cmd.Parameters.AddWithValue("@Username", login.loginuser);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Fname = reader["fname"].ToString();
                Lname = reader["lname"].ToString();
                Email = reader["email"].ToString();
                Joined = DateTime.Parse(reader["joined"].ToString());
            }
            dbc.con.Close();
        }
        private void seemore_Click(object sender, EventArgs e)
        {
            historylog hl = new historylog(User);
            if(login.adminmode == false) dashboard.Dash.addUC(hl);
            else admin.ad.addUC(hl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist(null, User);
            if (login.adminmode == false) dashboard.Dash.addUC(youranime);
            else admin.ad.addUC(youranime);
        }
    }
}