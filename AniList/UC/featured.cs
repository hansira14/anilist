using AniList.UC;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace AniList
{
    public partial class featured : UserControl
    {
        private List<Anime> anime;
        private int i = 0;
        string statusValue = null;

        public featured(int x=0)
        {
            InitializeComponent();
            if(x==0) anime = retrieve.GetList(5);
            else anime = retrieve.GetList(x);
            AA.SetRoundedRegion(prev, 16);
            AA.SetRoundedRegion(next, 16);
            AA.SetRoundedRegion(panel1, 40);
        }

        private void featured_Load(object sender, EventArgs e)
        {
            loaddata();
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand checkCmd = new OleDbCommand();
            checkCmd.Connection = dbc.con;
            checkCmd.CommandText = "SELECT * FROM Mylist WHERE animeid = ? AND username = ?";
            checkCmd.Parameters.AddWithValue("?", anime[i].AnimeId);
            checkCmd.Parameters.AddWithValue("?", login.loginuser);
            OleDbDataReader reader = checkCmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                statusValue = reader.GetString(reader.GetOrdinal("status"));
                reader.Close();
            }
            dbc.con.Close();
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&loop=1&playlist={0}&controls=0&vq=hd1080&rel=0", anime[i].Trailer);
            chromiumWebBrowser1.Load(url);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            loaddata();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (i == anime.Count-1) return;
            i++;
            loaddata();
        }
        private void loaddata()
        {
            string videoId = anime[i].Trailer;
            title.Text = anime[i].Title;
            label2.Text = anime[i].Premiere + "  •  " + anime[i].Episodes + " episodes";
            synopsis.Text = anime[i].Synopsis;
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&loop=1&playlist={0}&controls=0&vq=hd1080&rel=0", videoId);
            chromiumWebBrowser1.Load(url);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            add.tolist(this.FindForm(), statusValue, anime[i]);
        }

        private async void featured_Leave(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.IsBrowserInitialized)
            {
                await chromiumWebBrowser1.EvaluateScriptAsync("document.querySelector('video').pause();");
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            animepage anip = new animepage(anime[i], statusValue);
            dashboard dash = this.ParentForm as dashboard;
            dash.addUC(anip);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&loop=1&playlist={0}&controls=0&vq=hd1080&rel=0", anime[i].Trailer);
            chromiumWebBrowser1.Load(url);
        }
    }

}
