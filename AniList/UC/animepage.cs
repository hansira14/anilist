using AniList.Forms;
using CefSharp;
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
    public partial class animepage : UserControl
    {
        Anime aa;
        static overview ov;
        static watch wt;
        static statsanime st;
        string statusValue;
        int id;
        bool isfav = false, isFeat = false;
        public animepage(Anime z, string ss=null)
        {
            InitializeComponent();
            id = z.AnimeId;
            if (z.Status == "Not yet aired") watch.Enabled = false;
            if (login.adminmode == true)
            {
                premiere.Click -= premiere_Click;
                studio.Click -= studio_Click;
                demo.Click -= demo_Click;
            }
        }
        public void LoadData()
        {
            aa = retrieve.GetAnime(id);
            GetStatus();
            Overview();
             if(aa.Poster!="") poster.ImageLocation = aa.Poster;
            else if (aa.Pic != null) poster.Image = aa.Pic;
            else poster.ImageLocation = aa.Poster;
            title.Text = aa.Title;
            eng.Text = aa.English;
            score.Text = aa.Rating.ToString();
            rank.Text = "#" + aa.Rank + " Highest Rated All Time";
            popu.Text = "#" + aa.Popularity + " Most Popular All Time";
            users.Text = aa.Users.ToString("#,##0") + " Users";
            rates.Text = aa.RatedBy.ToString("#,##0");
            switch (aa.Status)
            {
                case "Finsihed Airing":
                    status.Text = "Finished Airing";
                    status.ForeColor = Color.FromArgb(174, 193, 178);
                    status.IconLeft = Properties.Resources.finished;
                    break;
                case "Currently Airing":
                    status.Text = "Currently Airing";
                    status.ForeColor = Color.FromArgb(159, 176, 211);
                    status.IconLeft = Properties.Resources.currently;
                    break;
                case "Not yet aired":
                    status.Text = "Not yet aired";
                    status.ForeColor = Color.FromArgb(234, 129, 172);
                    status.IconLeft = Properties.Resources.finished;
                    break;
            }

            AA.SetRoundedRegion(container, 10);
            type.Text = aa.Type;
            if (aa.Episodes == 0) eps.Text = "? episodes";
            else eps.Text = aa.Episodes.ToString() + " episodes";
            epd.Text = aa.Duration.ToString() + " minutes";
            statuss.Text = aa.Status;
            if(aa.Status=="Currently Airing")
            {
                try
                {
                    DateTime now = DateTime.Now;
                    string broadcast = aa.Broadcast;
                    DateTime nextBroadcast = GetNextBroadcastDateTime(broadcast, now);

                    TimeSpan timeRemaining = nextBroadcast - now;
                    string countdown = string.Format("Next episode in {0} days {1} mins",
                        timeRemaining.Days, timeRemaining.Minutes);
                    count.Text = countdown;
                }
                catch(Exception ex) { }
            }
            premiere.Text = aa.Premiere;
            start.Text = aa.Aired.ToString("MMM dd, yyyy");
            if (aa.Ended == DateTime.MinValue) end.Text = "???";
            else end.Text = aa.Ended.ToString("MMM dd, yyyy");
            if (aa.Aired == DateTime.MinValue) start.Text = "???";
            else start.Text = aa.Aired.ToString("MMM dd, yyyy");
            studio.Text = aa.Studio;
            source.Text = aa.Source;
            broadcast.Text = aa.Broadcast;
            fav.Text = aa.Favorites.ToString("#,##0") + " favorites";
            demo.Text = aa.Demo;
            string[] genreNames = aa.Genre.Split(',');
            themepanel.Controls.Clear();
            genrepanel.Controls.Clear();
            foreach (string xx in genreNames)
            {
                genrebutton genreButton = new genrebutton(xx.Trim());
                genrepanel.Controls.Add(genreButton);
            }
            string[] theme = aa.Theme.Split(',');
            foreach (string zz in theme)
            {
                genrebutton sss = new genrebutton(zz.Trim());
                themepanel.Controls.Add(sss);
            }
        }
        private DateTime GetNextBroadcastDateTime(string broadcast, DateTime now)
        {
            // Parse the day and time from the broadcast string
            string[] parts = broadcast.Split(new string[] { " at " }, StringSplitOptions.None);
            string dayOfWeekString = parts[0];
            string timeString = parts[1];

            // Remove the plural "s" from the dayOfWeekString
            if (dayOfWeekString.EndsWith("s", StringComparison.OrdinalIgnoreCase))
            {
                dayOfWeekString = dayOfWeekString.Substring(0, dayOfWeekString.Length - 1);
            }

            // Parse the day of the week from the dayOfWeekString with case-insensitive comparison
            DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayOfWeekString, ignoreCase: true);

            // Get the next occurrence of the specified day of the week
            DateTime nextOccurrence = now.Date;
            while (nextOccurrence.DayOfWeek != dayOfWeek)
            {
                nextOccurrence = nextOccurrence.AddDays(1);
            }

            // Parse the time from the timeString
            string[] timeParts = timeString.Split(':');
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);

            // Set the time on the nextOccurrence
            nextOccurrence = nextOccurrence.AddHours(hours).AddMinutes(minutes);

            // If the next broadcast is in the past, add a week to get the next occurrence
            if (nextOccurrence < now)
            {
                nextOccurrence = nextOccurrence.AddDays(7);
            }

            return nextOccurrence;
        }



        void GetStatus()
        {
            statusValue = null;
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand checkCmd1 = new OleDbCommand();
            checkCmd1.Connection = dbc.con;
            checkCmd1.CommandText = "SELECT * FROM Mylist WHERE animeid = ? AND username = ?";
            checkCmd1.Parameters.AddWithValue("?", aa.AnimeId);
            checkCmd1.Parameters.AddWithValue("?", login.loginuser);

            using (OleDbDataReader reader = checkCmd1.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    statusValue = reader.GetString(reader.GetOrdinal("status"));
                    addanime.Text = statusValue;
                }
                else addanime.Text = "Add to list";
            }
            if (login.adminmode == false)
            {
                OleDbCommand checkCmd2 = new OleDbCommand();
                checkCmd2.Connection = dbc.con;
                checkCmd2.CommandText = "SELECT * FROM Favorites WHERE animeid = ? AND username = ?";
                checkCmd2.Parameters.AddWithValue("?", aa.AnimeId);
                checkCmd2.Parameters.AddWithValue("?", login.loginuser);
                using (OleDbDataReader reader = checkCmd2.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        addfav.Image = Properties.Resources.faved;
                        isfav = true;
                    }
                    else
                    {
                        addfav.Image = Properties.Resources.notfaved;
                        isfav = false;
                    }
                }
            }
            if (login.adminmode == true) isFeatured();
            
            dbc.con.Close();
        }
        void isFeatured()
        {
            OleDbCommand checkCmd2 = new OleDbCommand();
            checkCmd2.Connection = dbc.con;
            checkCmd2.CommandText = $"SELECT * FROM Featured WHERE animeid = {aa.AnimeId}";
            if (checkAndSetFeaturedFlag(checkCmd2) == true) return;

            checkCmd2.CommandText = $"SELECT * FROM FeaturedMovies WHERE animeid = {aa.AnimeId}";
            if (checkAndSetFeaturedFlag(checkCmd2) == true) return;

            checkCmd2.CommandText = $"SELECT * FROM FeaturedOthers WHERE animeid = {aa.AnimeId}";
            if (checkAndSetFeaturedFlag(checkCmd2) == true) return;
        }

        bool checkAndSetFeaturedFlag(OleDbCommand command)
        {
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    addfav.Image = Properties.Resources.featured;
                    isFeat = true;
                    return true;
                }
                else
                {
                    addfav.Image = Properties.Resources.notfeatured;
                    isFeat = false;
                    return false;
                }
            }
        }


        void Overview()
        {
            pane.Controls.Clear();
            ov = new overview(aa);
            pane.Controls.Add(ov);
        }
        private async void animepage_Leave(object sender, EventArgs e)
        {
            //if (dashboard.dontleave==false) this.Dispose();
            if (chromiumWebBrowser1.IsBrowserInitialized)
            {
                await chromiumWebBrowser1.EvaluateScriptAsync("document.querySelector('video').pause();");
            }
        }

        private void addanime_Click(object sender, EventArgs e)
        {
            if (login.adminmode == true)
            {
                newanime nw = new newanime(aa);
                add.tolist(admin.ad, nw);
            }
            else add.tolist(this.FindForm(), statusValue, aa, this);
        }

        private void addfav_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            dbc.Connect();
            dbc.con.Open();
            string type1 = "";
            if (login.adminmode == true)
            {
                if (type.Text == "TV") type1 = "Featured";
                else if (type.Text=="Movie") type1 = "FeaturedMovies";
                else type1 = "FeaturedOthers";
                if (isFeat == true)
                {
                    cmd = new OleDbCommand($"DELETE FROM {type1} WHERE animeid = {aa.AnimeId}", dbc.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        admin.ad.Message("Error");
                        dbc.con.Close();
                        return;
                    }
                    isFeat = false;
                }
                else
                {
                    cmd = new OleDbCommand($"INSERT INTO {type1} (animeid) VALUES ({aa.AnimeId})", dbc.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        admin.ad.Message("Anime already featured!");
                        dbc.con.Close();
                        return;
                    }
                    isFeat = true;
                }
                if (isFeat == true)
                {
                    admin.ad.Message("Anime added to featured!");
                }
                else
                {
                    admin.ad.Message("Anime deleted to featured!");
                }
            }
            else
            {
                string sql1 = "INSERT INTO Favorites (username, animeid) VALUES (@username, @animeid)";
                string sql2 = "DELETE FROM Favorites WHERE username = ? AND animeid = ?";
                if (isfav != true)
                {
                    cmd = new OleDbCommand(sql1, dbc.con);
                    cmd.Parameters.AddWithValue("@username", login.loginuser);
                    cmd.Parameters.AddWithValue("@animeid", aa.AnimeId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        dashboard.Dash.Message("Anime already added!");
                        dbc.con.Close();
                        return;
                    }
                    isfav = true;
                }
                else
                {
                    cmd = new OleDbCommand(sql2, dbc.con);
                    cmd.Parameters.AddWithValue("@username", login.loginuser);
                    cmd.Parameters.AddWithValue("@animeid", aa.AnimeId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        dashboard.Dash.Message("Error");
                        dbc.con.Close();
                        return;
                    }
                    isfav = false;
                }
                if (isfav == true)
                {
                    dashboard.Dash.Message("Anime added to favorites!");
                    AA.Add(aa.AnimeId);
                    AA.LogAction(login.loginuser, aa.AnimeId, $"Added {aa.Title} to Favorites.");
                }
                else
                {
                    dashboard.Dash.Message("Anime deleted to favorites!");
                    AA.Delete(aa.AnimeId);
                    AA.LogAction(login.loginuser, aa.AnimeId, $"Deleted {aa.Title} from Favorites.");
                }
            }
            if(login.adminmode==false)dashboard.Dash.Userdetails();
            dbc.con.Close();
            GetStatus();
        }

        private void animepage_Load(object sender, EventArgs e)
        {
            if(statusValue!=null) addanime.Text = statusValue;
            LoadData();
            Overview();
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&loop=1&playlist={0}&controls=0&vq=hd1080&rel=0", aa.Trailer, aa.Trailer);
            chromiumWebBrowser1.Load(url);
            if (login.adminmode == true)
            {
               addanime.Text="Edit Anime";
            }
            if (dashboard.Dash.premium == false)
            {
                ads ad = new ads(dashboard.Dash);
                ad.ShowDialog();
            }
        }

        private void watch_Click(object sender, EventArgs e)
        {
            if (dashboard.Dash.premium == false)
            {
                PremIntro intro = new PremIntro(dashboard.Dash);
                intro.ShowDialog();
                return;
            }
            pane.Controls.Clear();
            wt = new watch(aa);
            pane.Controls.Add(wt);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pane.Controls.Clear();
            ov = new overview(aa);
            pane.Controls.Add(ov);
        }

        private void stats_Click(object sender, EventArgs e)
        {
            pane.Controls.Clear();
            st = new statsanime(aa);
            pane.Controls.Add(st);
        }

        private void premiere_Click(object sender, EventArgs e)
        {
            if (premiere.Text == "N/A") return;
            dashboard.Dash.searchresults = retrieve.GetList(88, 0, $"SELECT * FROM Animelist WHERE premiere LIKE '%{premiere.Text}%'");
            dashboard.Dash.results = new tableFav(dashboard.Dash.searchresults);
            dashboard.Dash.results.table.Controls.Clear();
            //dashboard.Dash.results.table.ColumnCount = 5;
            //dashboard.Dash.results.table.RowCount = dashboard.Dash.searchresults.Count / 5;
            //if (dashboard.Dash.searchresults.Count % 5 != 0) dashboard.Dash.results.table.RowCount++;
            dashboard.Dash.addUC(dashboard.Dash.results);
        }

        private void studio_Click(object sender, EventArgs e)
        {
            if (studio.Text == "N/A") return;
            dashboard.Dash.searchresults = retrieve.GetList(88, 0, $"SELECT * FROM Animelist WHERE studio LIKE '%{studio.Text}%'");
            dashboard.Dash.results = new tableFav(dashboard.Dash.searchresults);
            dashboard.Dash.results.table.Controls.Clear();
            dashboard.Dash.addUC(dashboard.Dash.results);
        }

        private void demo_Click(object sender, EventArgs e)
        {
            if (aa.Demo == "N/A") return;
            dashboard.Dash.searchresults = retrieve.GetList(88, 0, $"SELECT * FROM Animelist WHERE demographics LIKE '%{demo.Text}%'");
            dashboard.Dash.results = new tableFav(dashboard.Dash.searchresults);
            dashboard.Dash.results.table.Controls.Clear();
            dashboard.Dash.addUC(dashboard.Dash.results);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&loop=1&playlist={0}&controls=0&vq=hd1080&rel=0", aa.Trailer, aa.Trailer);
            chromiumWebBrowser1.Load(url);
        }
    }
}
