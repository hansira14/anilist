using AniList.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AniList.UC
{
    public partial class adminanime : UserControl
    {
        OleDbCommand cmd;
        OleDbDataReader reader;
        void Studio()
        {
            cmd.CommandText = "SELECT studio, COUNT(*) AS typeCount FROM Animelist GROUP BY studio";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                typeCounts[reader.GetString(0)] = reader.GetInt32(1);
            }
            reader.Close();
            var sortedTypeCounts = typeCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedTypeCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                studioo.Series[0].Points.Add(point);
                studioo.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }
        void Status()
        {
            cmd.CommandText = "SELECT status, COUNT(*) AS typeCount FROM Animelist GROUP BY status";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                typeCounts[reader.GetString(0)] = reader.GetInt32(1);
            }
            reader.Close();
            var sortedTypeCounts = typeCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedTypeCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                stat.Series[0].Points.Add(point);
                stat.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }
        void Release()
        {
            cmd.CommandText = "SELECT YEAR(aired) AS airedYear, COUNT(*) AS yearCount FROM Animelist GROUP BY YEAR(aired)";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> yearCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                yearCounts[reader[0].ToString()] = reader.GetInt32(1);
            }
            reader.Close();
            foreach (var xx in yearCounts) rel.Series[0].Points.AddXY(xx.Key, xx.Value);
        }
        void Source()
        {
            cmd.CommandText = "SELECT source, COUNT(*) AS typeCount FROM Animelist GROUP BY source";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                typeCounts[reader.GetString(0)] = reader.GetInt32(1);
            }
            reader.Close();
            var sortedTypeCounts = typeCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedTypeCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                src.Series[0].Points.Add(point);
                src.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }
        void Counts()
        {
            string[] columns = new string[] { "planscount", "droppedcount", "pausedcount", "completedcount", "watchingcount" };
            Dictionary<string, int> statusCounts = new Dictionary<string, int>();

            foreach (string column in columns)
            {
                cmd.CommandText = $"SELECT SUM({column}) FROM Animelist";
                int sum = Convert.ToInt32(cmd.ExecuteScalar());
                statusCounts[column] = sum;
            }

            var sortedStatusCounts = statusCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedStatusCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                chart1.Series[0].Points.Add(point);
                chart1.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }
        void Type()
        {
            cmd.CommandText = "SELECT type, COUNT(*) AS typeCount FROM Animelist GROUP BY type";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                typeCounts[reader.GetString(0)] = reader.GetInt32(1);
            }
            reader.Close();
            var sortedTypeCounts = typeCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedTypeCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                format.Series[0].Points.Add(point);
                format.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }

        void rCounts()
        {
            cmd.CommandText = "SELECT r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 FROM Animelist";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> scoreCounts2 = new Dictionary<string, int>();
            while (reader.Read())
            {
                for (int i = 1; i <= 10; i++)
                {
                    string key = i.ToString();
                    double count = reader.GetDouble(i - 1);  // if fields are of type double
                    int intCount = (int)count;  // convert to int

                    if (scoreCounts2.ContainsKey(key))
                    {
                        scoreCounts2[key] += intCount;
                    }
                    else
                    {
                        scoreCounts2[key] = intCount;
                    }
                }
            }
            reader.Close();
            var sortedScores2 = scoreCounts2.OrderBy(pair => Convert.ToInt32(pair.Key));
            foreach (var xx in sortedScores2)
            {
                scoredis.Series[0].Points.AddXY(xx.Key, xx.Value);
            }
        }
        void Rating()
        {
            cmd.CommandText = "SELECT rating FROM Animelist";
            reader = cmd.ExecuteReader();
            Dictionary<string, int> scoreCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                double rating = reader.GetDouble(0);
                int roundedRating = (int)Math.Round(rating);
                string roundedRatingStr = roundedRating.ToString();
                if (scoreCounts.ContainsKey(roundedRatingStr)) scoreCounts[roundedRatingStr]++;
                else scoreCounts[roundedRatingStr] = 1;
            }
            reader.Close();
            var sortedScores = scoreCounts.OrderBy(pair => Convert.ToInt32(pair.Key));
            foreach (var xx in sortedScores) if (xx.Key != "0") aps.Series[0].Points.AddXY(xx.Key, xx.Value);
        }
        void adGenre()
        {
            cmd.CommandText = "SELECT a.genre FROM MyList m INNER JOIN Animelist a ON m.animeid = a.animeid";
            OleDbDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                string[] genres = reader.GetString(0).Split(','); // split on comma
                foreach (string genre in genres)
                {
                    string trimmedGenre = genre.Trim(); // remove any whitespace
                    if (genreCounts.ContainsKey(trimmedGenre)) genreCounts[trimmedGenre]++;
                    else genreCounts[trimmedGenre] = 1;
                }
            }
            reader.Close();
            var sortedTypeCounts = genreCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedTypeCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                addedgenre.Series[0].Points.Add(point);
                addedgenre.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }
        void Genre()
        {
            cmd.CommandText = "SELECT genre FROM Animelist";
            OleDbDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();
            while (reader.Read())
            {
                string[] genres = reader.GetString(0).Split(','); // split on comma
                foreach (string genre in genres)
                {
                    string trimmedGenre = genre.Trim(); // remove any whitespace
                    if (genreCounts.ContainsKey(trimmedGenre)) genreCounts[trimmedGenre]++;
                    else genreCounts[trimmedGenre] = 1;
                }
            }
            reader.Close();
            var sortedTypeCounts = genreCounts.OrderByDescending(pair => pair.Value);
            foreach (var xx in sortedTypeCounts)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = xx.Key;
                point.YValues = new double[] { xx.Value };
                point.Label = xx.Key;
                point.ToolTip = xx.Key + " : " + xx.Value.ToString();
                genre.Series[0].Points.Add(point);
                genre.Series[0].LegendText = "#LABEL (#VAL)";
            }
        }
        public void Reload()
        {
            label3.Text = retrieve.Animecount().ToString();
            dbc.Connect();
            dbc.con.Open();
            cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            Genre(); Rating(); rCounts(); adGenre(); Type(); Status(); Release(); Studio(); Source(); Counts();
            dbc.con.Close();
        }
        public adminanime()
        {
            InitializeComponent();
            AA.SetRoundedRegion(addedgenre, 10);
            AA.SetRoundedRegion(genre, 10);
            Reload();
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

        private void label3_Click(object sender, EventArgs e)
        {
            List<Anime> searchresults = retrieve.GetList(99);
            tableFav results = new tableFav(searchresults);
            results.panel3.Size = new Size(1060, 101);
            admin.ad.addUC(results);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            newanime nw = new newanime();
            AniList.add.tolist(admin.ad, nw);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3_Click(null, null);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AA.SetRanks();
            MessageBox.Show("Anime Rating Ranking updated!");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SetPopularityRanks(); MessageBox.Show("Anime Popularity Ranking updated!");
        }
        public static void SetPopularityRanks()
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;

            // Create a temporary table to store the new popularity ranks
            cmd.CommandText = @"CREATE TABLE TempPopularityRanks (
                            animeid INT,
                            popularity_rank INT
                        )";
            cmd.ExecuteNonQuery();

            // Populate the temporary table with the new popularity ranks based on the 'users' field
            cmd.CommandText = @"INSERT INTO TempPopularityRanks (animeid, popularity_rank)
                        SELECT a1.animeid, COUNT(a2.animeid) + 1 AS popularity_rank
                        FROM Animelist AS a1, Animelist AS a2
                        WHERE a2.users > a1.users OR (a2.users = a1.users AND a2.animeid > a1.animeid)
                        GROUP BY a1.animeid";
            cmd.ExecuteNonQuery();

            // Update the 'popularity' field in the original table using the temporary table
            cmd.CommandText = @"UPDATE Animelist
                        INNER JOIN TempPopularityRanks ON Animelist.animeid = TempPopularityRanks.animeid
                        SET Animelist.popularity = TempPopularityRanks.popularity_rank";
            cmd.ExecuteNonQuery();

            // Delete the temporary table
            cmd.CommandText = "DROP TABLE TempPopularityRanks;";
            cmd.ExecuteNonQuery();

            dbc.con.Close();
        }

    }
}
