using AniList.Forms;
using CefSharp.DevTools.CSS;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class statsprofile : UserControl
    {
        string User = null;
        public static int animecount(string user)
        {
            int count = 0;
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "SELECT COUNT(*) FROM MyList WHERE username = @user";
            cmd.Parameters.AddWithValue("@user", user);
            count = (int)cmd.ExecuteScalar();
            dbc.con.Close();
            return count;
        }

        public statsprofile(string user = null)
        {
            InitializeComponent();
            if (user == null)
            {
                user = login.loginuser;
                totalanime.Text = dashboard.Dash.counts.Sum().ToString();
            }
            else totalanime.Text = animecount(user).ToString();
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;

            cmd.CommandText = $"SELECT SUM(progress) FROM MyList WHERE username = '{user}'";
            try
            {
                double epssum = Convert.ToDouble(cmd.ExecuteScalar());
                epswatched.Text = epssum.ToString();
            }
            catch (Exception ex) { }

            cmd.CommandText = "SELECT SUM(m.progress * a.duration) FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid WHERE m.username = @username AND m.progress > 0";
            cmd.Parameters.AddWithValue("@username", user);
            try
            {
                double mins = Convert.ToDouble(cmd.ExecuteScalar());
                double dayswatch = mins / 60;
                dayswatched.Text = dayswatch.ToString("0.00");
            }
            catch (Exception ex) { }

            cmd.CommandText = "SELECT SUM(a.duration * a.episodes) FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid WHERE m.username = @username AND m.status = 'Plans to watch'";
            cmd.Parameters.AddWithValue("@username", user);
            try
            {
                double minsplan = Convert.ToDouble(cmd.ExecuteScalar());
                double daysplan = minsplan / 60;
                daysplanned.Text = daysplan.ToString("0.00");
            }
            catch (Exception ex) { }

            cmd.CommandText = "SELECT AVG(score) FROM MyList WHERE username = @username AND score > 0";
            cmd.Parameters.AddWithValue("@username", user);
            try
            {
                double meanScore = Convert.ToDouble(cmd.ExecuteScalar());
                meanscore.Text = meanScore.ToString("0.00");
            }
            catch (Exception ex) { }

            //top genre
            cmd.CommandText = "SELECT a.genre FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid WHERE m.username = '" + user + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                string[] genres = reader.GetString(0).Split(','); // split on comma
                foreach (string genre in genres)
                {
                    string trimmedGenre = genre.Trim(); // remove any whitespace
                    if (genreCounts.ContainsKey(trimmedGenre))
                    {
                        genreCounts[trimmedGenre]++;
                    }
                    else
                    {
                        genreCounts[trimmedGenre] = 1;
                    }
                }
            }
            reader.Close();
            var topGenres = genreCounts.OrderByDescending(pair => pair.Value).Take(6);
            int genresum = topGenres.Sum(pair => pair.Value);
            Dictionary<string, string> topGenrespercent = new Dictionary<string, string>();
            foreach (var pair in topGenres)
            {
                string typeLabel = pair.Key;
                int typeCount = pair.Value;
                double percentage = (double)typeCount / genresum * 100;
                string percentageString = $"{percentage.ToString("0.00")}%";
                topGenrespercent[typeLabel] = percentageString;
            }

            try
            {
                key1.Text = topGenrespercent.First().Key; key2.Text = topGenrespercent.Skip(1).First().Key;
                key3.Text = topGenrespercent.Skip(2).First().Key; key4.Text = topGenrespercent.Skip(3).First().Key;
                key5.Text = topGenrespercent.Skip(4).First().Key; key6.Text = topGenrespercent.Skip(5).First().Key;
                value1.Text = topGenrespercent.First().Value; value2.Text = topGenrespercent.Skip(1).First().Value;
                value3.Text = topGenrespercent.Skip(2).First().Value; value4.Text = topGenrespercent.Skip(3).First().Value;
                value5.Text = topGenrespercent.Skip(4).First().Value; value6.Text = topGenrespercent.Skip(5).First().Value;
            }
            catch (Exception ex) { }

            // Anime per score
            cmd.CommandText = "SELECT score, COUNT(*) AS scoreCount FROM MyList WHERE username = '" + user + "' GROUP BY score ORDER BY COUNT(*) DESC";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> scoreCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                scoreCounts[reader[0].ToString()] = reader.GetInt32(1);
            }
            reader.Close();

            // Format Distribution
            cmd.CommandText = "SELECT a.type, COUNT(*) AS typeCount FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid WHERE m.username = '" + user + "' GROUP BY a.type";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                typeCounts[reader.GetString(0)] = reader.GetInt32(1);
            }
            reader.Close();

            // Status Distribution
            cmd.CommandText = "SELECT status, COUNT(*) AS statusCount FROM MyList WHERE username = '" + user + "' GROUP BY status";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> statusCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                statusCounts[reader.GetString(0)] = reader.GetInt32(1);
            }
            reader.Close();

            // Release Year
            cmd.CommandText = "SELECT YEAR(a.aired) AS airedYear, COUNT(*) AS yearCount FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid WHERE m.username = '" + user + "' GROUP BY YEAR(a.aired)";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> yearCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                yearCounts[reader[0].ToString()] = reader.GetInt32(1);
            }
            reader.Close();

            //Anime per eps
            cmd.CommandText = "SELECT a.episodes FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid WHERE m.username = '" + user + "'";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> episodeCounts = new Dictionary<string, int>()
            {
                { "1", 0 },
                { "2-6", 0 },
                { "7-15", 0 },
                { "16-20", 0 },
                { "21-30", 0 },
                { "31-40", 0 },
                { "41-50", 0 },
                { "51-60", 0 },
                { "61-70", 0 },
                { "71-80", 0 },
                { "81-90", 0 },
                { "91-100", 0 },
                { "100-200", 0 },
                { "200+", 0 },
            };
            while (reader.Read())
            {
                int episodes = Convert.ToInt32(reader[0]);
                if (episodes == 1) episodeCounts["1"]++;
                else if (episodes <= 6) episodeCounts["2-6"]++;
                else if (episodes <= 15) episodeCounts["7-15"]++;
                else if (episodes <= 20) episodeCounts["16-20"]++;
                else if (episodes <= 30) episodeCounts["21-30"]++;
                else if (episodes <= 40) episodeCounts["31-40"]++;
                else if (episodes <= 50) episodeCounts["41-50"]++;
                else if (episodes <= 60) episodeCounts["51-60"]++;
                else if (episodes <= 70) episodeCounts["61-70"]++;
                else if (episodes <= 80) episodeCounts["71-80"]++;
                else if (episodes <= 90) episodeCounts["81-90"]++;
                else if (episodes <= 100) episodeCounts["91-100"]++;
                else if (episodes <= 200) episodeCounts["100-200"]++;
                else episodeCounts["200+"]++;
            }
            reader.Close();
            dbc.con.Close();

            var sortedTypeCounts = typeCounts.OrderByDescending(pair => pair.Value);
            var sortedStatusCounts = statusCounts.OrderByDescending(pair => pair.Value);
            var sortedScores = scoreCounts.OrderBy(pair => Convert.ToInt32(pair.Key.Split('-')[0]));

            foreach (var xx in topGenres) genre.Series[0].Points.AddXY(xx.Key, xx.Value);
            foreach (var xx in sortedScores) if (xx.Key != "0") aps.Series[0].Points.AddXY(xx.Key, xx.Value);
            foreach (var xx in yearCounts) release.Series[0].Points.AddXY(xx.Key, xx.Value);
            foreach (var xx in episodeCounts) if (xx.Value > 0) ape.Series[0].Points.AddXY(xx.Key, xx.Value);

            foreach (var xx in sortedTypeCounts) format.Series[0].Points.AddXY(xx.Key, xx.Value);
            foreach (var xx in sortedStatusCounts) status.Series[0].Points.AddXY(xx.Key, xx.Value);

            int typeCountsSum = sortedTypeCounts.Sum(pair => pair.Value);
            int statusCountsSum = sortedStatusCounts.Sum(pair => pair.Value);
            Dictionary<string, string> statusPercentages = new Dictionary<string, string>();
            Dictionary<string, string> typePercentages = new Dictionary<string, string>();
            int count = 0;
            foreach (var pair in sortedTypeCounts.Take(3))
            {
                string typeLabel = pair.Key;
                int typeCount = pair.Value;
                double percentage = (double)typeCount / typeCountsSum * 100;
                string percentageString = $"{percentage.ToString("0.00")}%";
                typePercentages[typeLabel] = percentageString;
                if (count == 0)
                {
                    f1.Text = typeLabel; f11.Text = percentageString;
                }
                else if (count == 1)
                {
                    f2.Text = typeLabel; f22.Text = percentageString;
                }
                else if (count == 2)
                {
                    f3.Text = typeLabel; f33.Text = percentageString;
                }
                count++;
            }
            count = 0;
            foreach (var pair in sortedStatusCounts.Take(3))
            {
                string statusLabel = pair.Key;
                int statusCount = pair.Value;
                double percentage = (double)statusCount / statusCountsSum * 100;
                string percentageString = $"{percentage.ToString("0.00")}%";
                statusPercentages[statusLabel] = percentageString;
                if (count == 0)
                {
                    s1.Text = statusLabel; s11.Text = percentageString;
                }
                else if (count == 1)
                {
                    s2.Text = statusLabel; s22.Text = percentageString;
                }
                else if (count == 2)
                {
                    s3.Text = statusLabel; s33.Text = percentageString;
                }
                count++;
            }

        }

        private void key1_Click(object sender, EventArgs e)
        {
            string gen = null;
            var clickedLabel = sender as Label;
            if (clickedLabel != null) gen = clickedLabel.Text;
            else return;
            if(gen== null || gen=="-") return;
            List<Anime> searchresults = retrieve.GetList(99, 0);
            tableFav results = new tableFav(searchresults);
            results.table.Controls.Clear();
            results.panel3.Size = new Size(1060, 101);
            int genreIndex = results.genre.Items.Cast<string>().ToList().FindIndex(item => item.ToLower() == gen.ToLower());
            if (genreIndex != -1) results.genre.SelectedIndex = genreIndex;
            //int themesIndex = results.themes.Items.Cast<string>().ToList().FindIndex(item => item.ToLower() == genre.Text.ToLower());
            //if (themesIndex != -1) results.themes.SelectedIndex = themesIndex;
            if (login.adminmode==false) dashboard.Dash.addUC(results);
            else admin.ad.addUC(results);
        }

        private void f3_Click(object sender, EventArgs e)
        {
            string gen = null;
            var clickedLabel = sender as Label;
            if (clickedLabel != null) gen = clickedLabel.Text;
            else return;
            if (gen == null || gen == "-") return;
            List<Anime> searchresults = retrieve.GetList(99, 0);
            tableFav results = new tableFav(searchresults);
            results.table.Controls.Clear();
            results.panel3.Size = new Size(1060, 101);
            int type = results.type.Items.Cast<string>().ToList().FindIndex(item => item.ToLower() == gen.ToLower());
            if (type != -1) results.type.SelectedIndex = type;
            //int themesIndex = results.themes.Items.Cast<string>().ToList().FindIndex(item => item.ToLower() == genre.Text.ToLower());
            //if (themesIndex != -1) results.themes.SelectedIndex = themesIndex;
            if (login.adminmode == false) dashboard.Dash.addUC(results);
            else admin.ad.addUC(results);
        }

        private void s1_Click_1(object sender, EventArgs e)
        {
            string gen = null;
            var clickedLabel = sender as Label;
            if (clickedLabel != null) gen = clickedLabel.Text;
            else return;
            if (gen == null || gen == "-") return;
            tableMylist youranime = new tableMylist(gen);
            if (login.adminmode == false) dashboard.Dash.addUC(youranime);
            else admin.ad.addUC(youranime);
        }

        private void key1_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void key1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.Font = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
            }
        }

    }
}
