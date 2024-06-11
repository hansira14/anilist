using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AniList
{
    public partial class addanime : Form
    {
        Anime aa;
        string statusValue;
        anime ani = null;
        animeTop ani2 = null;
        animePic ani0 = null;
        animeRecom ani4 = null;
        DateTime nowAt1159PM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 0);

        public addanime(Anime x, string z, anime anime = null)
        {
            InitializeComponent();
            aa = x;
            statusValue = z;
            ani = anime;
        }
        public addanime(Anime x, string z, animeTop anime)
        {
            InitializeComponent();
            aa = x;
            statusValue = z;
            ani2 = anime;
        }
        public addanime(Anime x, string z, animePic anime)
        {
            InitializeComponent();
            aa = x;
            statusValue = z;
            ani0 = anime;
        }
        public addanime(Anime x, string z, animeRecom anime)
        {
            InitializeComponent();
            aa = x;
            statusValue = z;
            ani4 = anime;
        }

        private void addanime_Load(object sender, EventArgs e)
        {
            start.MaxDate = nowAt1159PM;
            finished.MaxDate = nowAt1159PM;
            start.Value = DateTime.Now; finished.Value = DateTime.Now;
            string[] choices = new string[0];
            title.Text = aa.Title;
            if(aa.Poster!="")pictureBox1.ImageLocation = aa.Poster;
            else if(aa.Pic!=null) pictureBox1.Image=aa.Pic;
            else pictureBox1.ImageLocation = aa.Poster;
            if (aa.Status == "Not yet aired")
            {
                status.Items.Clear();
                choices = new string[] { "Plans to watch" };
            }
            else if (aa.Status == "Currently Airing")
            {
                status.Items.Clear();
                choices = new string[] { "Watching", "Plans to watch", "Paused","Dropped" };
            }
            status.Items.AddRange(choices);
            if (statusValue != null)
            {
                status.SelectedItem= statusValue;
                Proceed.Text = "Edit Anime";
                del.Visible = true;
                dbc.Connect();
                dbc.con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = dbc.con;
                cmd.CommandText = "SELECT score, review, progress, started, finished FROM MyList WHERE username = ? AND animeid = ?";
                cmd.Parameters.AddWithValue("?", login.loginuser);
                cmd.Parameters.AddWithValue("?", aa.AnimeId);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Use GetFloat, GetDouble or GetDecimal if the score is stored as float, double or decimal in the database, respectively
                        score.Value = reader.IsDBNull(0) ? 0 : Convert.ToDecimal(reader.GetDecimal(0)); // Convert the score to the appropriate type
                        review.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        progress.Value = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        start.Value = reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3);
                        finished.Value = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                    }
                }
                cmd.ExecuteNonQuery();
                dbc.con.Close();
            }
            rev = review.Text;
        }
        string rev=null;
        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (status.SelectedItem.ToString())
            {
                case "Completed":
                    score.Enabled = true; start.Enabled = true; finished.Enabled = true; progress.Enabled = true;
                    progress.Value = (decimal)aa.Episodes; review.Enabled = true; progress.Enabled = false;
                    break;
                case "Watching":
                    score.Enabled = true; start.Enabled = true; progress.Enabled = true; review.Enabled = true;
                    break;
                case "Plans to watch":
                    break;
                case "Dropped":
                    score.Enabled = true; start.Enabled = true; progress.Enabled = true; review.Enabled = true;
                    break;
                case "Paused":
                    score.Enabled = true; start.Enabled = true; progress.Enabled = true; review.Enabled = true;
                    break;
            }
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            if (statusValue == null)
            {
                dbc.Connect();
                dbc.con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = dbc.con;
                switch (status.SelectedItem.ToString())
                {
                    case "Completed":
                        AA.Add(aa.AnimeId, "completedcount");
                        cmd.CommandText = "INSERT INTO Mylist (username, animeid, started, status, finished,progress, review) " +
                              "VALUES (?, ?, ?, 'Completed',?,?,?)";
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", start.Text);
                        cmd.Parameters.AddWithValue("?", finished.Text);
                        cmd.Parameters.AddWithValue("?", aa.Episodes);
                        cmd.Parameters.AddWithValue("?", review.Text);
                        break;
                    case "Watching":
                        AA.Add(aa.AnimeId, "watchingcount");
                        cmd.CommandText = "INSERT INTO Mylist (username, animeid, started, status,progress,review) " +
                              "VALUES (?, ?, ?, 'Watching',?,?)";
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", start.Text);
                        cmd.Parameters.AddWithValue("?", progress.Value);
                        cmd.Parameters.AddWithValue("?", review.Text);
                        break;
                    case "Plans to watch":
                        AA.Add(aa.AnimeId, "planscount");
                        cmd.CommandText = "INSERT INTO Mylist (username, animeid, status) " +
                              "VALUES (?, ?, 'Plans to watch')";
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        break;
                    case "Dropped":
                        AA.Add(aa.AnimeId, "droppedcount");
                        cmd.CommandText = "INSERT INTO Mylist (username, animeid, started, status,progress, review) " +
                              "VALUES (?, ?, ?, 'Dropped',?,?)";
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", start.Text);
                        cmd.Parameters.AddWithValue("?", progress.Value);
                        cmd.Parameters.AddWithValue("?", review.Text);
                        break;
                    case "Paused":
                        AA.Add(aa.AnimeId, "pausedcount");
                        cmd.CommandText = "INSERT INTO Mylist (username, animeid, started, status,progress, review) " +
                              "VALUES (?, ?, ?, 'Paused',?,?)";
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", start.Text);
                        cmd.Parameters.AddWithValue("?", progress.Value);
                        cmd.Parameters.AddWithValue("?", review.Text);
                        break;
                }
                cmd.ExecuteNonQuery();
                AA.LogAction(login.loginuser, aa.AnimeId, $"Added {aa.Title} to {status.SelectedItem.ToString()} list.");
                mess1.Text = "Added successfully";
                dashboard.Dash.Message($"Anime added to {status.SelectedItem.ToString()}");
                if (ani != null)
                {
                    ani.add.Text = ""; ani.add.Image = Properties.Resources.edit;
                }
                else if(ani2!=null)
                {
                    ani2.add.Text = ""; ani2.add.Image = Properties.Resources.edit;
                }
                else if(ani0!=null)
                {
                    ani0.add.Text = ""; ani0.add.Image = Properties.Resources.edit;
                }
                else if (ani4 != null)
                {
                    ani4.add.Text = ""; ani4.add.Image = Properties.Resources.edit;
                }
                statusValue = status.SelectedItem.ToString();
            }
            else
            {
                dbc.Connect();
                dbc.con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = dbc.con;
                switch (status.SelectedItem.ToString())
                {
                    case "Watching":
                        AA.Updatestat(aa.AnimeId, "watchingcount", statusValue);
                        cmd.CommandText = "UPDATE Mylist SET started=?, status='Watching', progress=?, review=? WHERE animeid=? AND username=?";
                        cmd.Parameters.AddWithValue("?", start.Value.ToString()); 
                        cmd.Parameters.AddWithValue("?", progress.Value.ToString());
                        cmd.Parameters.AddWithValue("?", review.Text);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        break;
                    case "Completed":
                        AA.Updatestat(aa.AnimeId, "completedcount", statusValue);
                        cmd.CommandText = "UPDATE Mylist SET started=?, status='Completed', progress=?, review=?, finished=? WHERE animeid=? AND username=?";
                        cmd.Parameters.AddWithValue("?", start.Value.ToString());
                        cmd.Parameters.AddWithValue("?", progress.Value.ToString());
                        cmd.Parameters.AddWithValue("?", review.Text);
                        cmd.Parameters.AddWithValue("?", finished.Value.ToString());
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        break;
                    case "Plans to watch":
                        AA.Updatestat(aa.AnimeId, "planscount", statusValue);
                        cmd.CommandText = "UPDATE Mylist SET status = 'Plans to watch'" +
                        "WHERE animeid = ? AND username = ?";
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        break;
                    case "Dropped":
                        AA.Updatestat(aa.AnimeId, "droppedcount", statusValue);
                        cmd.CommandText = "UPDATE Mylist SET started=?, status='Dropped', progress=?,  review=? WHERE animeid=? AND username=?";
                        cmd.Parameters.AddWithValue("?", start.Value.ToString());
                        cmd.Parameters.AddWithValue("?", progress.Value.ToString());
                        cmd.Parameters.AddWithValue("?", review.Text);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        break;
                    case "Paused":
                        AA.Updatestat(aa.AnimeId, "pausedcount", statusValue);
                        cmd.CommandText = "UPDATE Mylist SET started=?, status='Paused', progress=?,  review=? WHERE animeid=? AND username=?";
                        cmd.Parameters.AddWithValue("?", start.Value.ToString());
                        cmd.Parameters.AddWithValue("?", progress.Value.ToString());
                        cmd.Parameters.AddWithValue("?", review.Text);
                        cmd.Parameters.AddWithValue("?", aa.AnimeId);
                        cmd.Parameters.AddWithValue("?", login.loginuser);
                        break;
                }
                cmd.ExecuteNonQuery();
                AA.LogAction(login.loginuser, aa.AnimeId, $"Updated {aa.Title} details.");
                mess1.Text = "Updated successfully";
                dashboard.Dash.Message($"Anime updated to {status.SelectedItem.ToString()}");
                statusValue = status.SelectedItem.ToString();
            }
            if (score.Value != 0 || scorechange == true)
            {
                int scoreValue;
                bool isWholeNumber = int.TryParse(score.Text, out scoreValue);

                if (isWholeNumber && scoreValue >= 1 && scoreValue <= 10) ScoreAnime();
                else
                {
                    MessageBox.Show("Score must be between 1 and 10.");
                    return;
                }
            }
            if (review.Text != "") Review();
            del.Visible = true;
            dbc.con.Close();
            dashboard.Dash.Userdetails();
            MessageBox.Show("Successfully updated list!");
            this.Close();
        }
        public void ScoreAnime()
        {
            string username = login.loginuser, newRating = score.Text;
            string animeId = aa.AnimeId.ToString();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            OleDbDataReader reader;
            string currentRating = "0";
            cmd.CommandText = $"SELECT score FROM MyList WHERE username = '{username}' AND animeid = {animeId}";
            using ( reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    currentRating = reader["score"].ToString();
                }
            }
            reader.Close();
            if (currentRating != newRating&& currentRating!="0")
            {
                cmd.CommandText = $"UPDATE Animelist SET r{currentRating} = r{currentRating} - 1 WHERE animeid = {animeId}";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"UPDATE Animelist SET r{newRating} = r{newRating} + 1 WHERE animeid = {animeId}";
                cmd.ExecuteNonQuery();
            }
            else if (currentRating == "0" && newRating!="0")
            {
                cmd.CommandText = $"UPDATE Animelist SET r{newRating} = r{newRating} + 1, ratedby = ratedby + 1 WHERE animeid = {animeId}";
                cmd.ExecuteNonQuery();
            }
            else return;

            cmd.CommandText = $"UPDATE Animelist SET rating = (r1*1 + r2*2 + r3*3 + r4*4 + r5*5 + r6*6 + r7*7 + r8*8 + r9*9 + r10*10) / (r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10) WHERE animeid = {animeId}";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"UPDATE MyList SET score = {newRating} WHERE username = '{username}' AND animeid = {animeId}";
            cmd.ExecuteNonQuery();
        }
        public void Review()
        {
            string username = login.loginuser;
            string newReview = $"{username}: " + review.Text;
            string animeId = aa.AnimeId.ToString();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            OleDbDataReader reader;

            string currentReview = "";

            cmd.CommandText = $"SELECT reviews FROM Animelist WHERE animeid = @AnimeId";
            cmd.Parameters.AddWithValue("@AnimeId", animeId);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    currentReview = reader["reviews"].ToString();
                }
            }
            reader.Close();

            string updatedReview = "";
            if (currentReview.Contains(username + ":"))
            {
                // Remove the old review
                var lines = currentReview.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                updatedReview = string.Join(Environment.NewLine, lines.Where(line => !line.StartsWith(username + ":")));

            }
            else
            {
                updatedReview = currentReview;
            }

            if (review.Text != rev)
            {
                // Add the new review
                updatedReview += $"{newReview}{Environment.NewLine}";

                cmd.CommandText = $"UPDATE Animelist SET reviews = '{updatedReview}' WHERE animeid ={animeId}";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = $"UPDATE MyList SET review = @ReviewText WHERE username = @Username AND animeid = {animeId}";
            cmd.Parameters.AddWithValue("@ReviewText", review.Text);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
        }
        string GetStatus()
        {
            string statusValue = null;
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
                }
            }
            return statusValue;
        }
        private void del_Click(object sender, EventArgs e)
        {
            dbc.Connect();
            dbc.con.Open();
            AA.Delete(aa.AnimeId, GetStatus());
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            OleDbDataReader reader;
            string currentRating = "0";
            cmd.CommandText = $"SELECT score FROM MyList WHERE username = '{login.loginuser}' AND animeid = {aa.AnimeId}";
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    currentRating = reader["score"].ToString();
                }
            }
            reader.Close();
            if (currentRating != "0")
            {
                cmd.CommandText = $"UPDATE Animelist SET r{currentRating} = r{currentRating} - 1, ratedby=ratedby-1 WHERE animeid = {aa.AnimeId}";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"UPDATE Animelist SET rating = (r1*1 + r2*2 + r3*3 + r4*4 + r5*5 + r6*6 + r7*7 + r8*8 + r9*9 + r10*10) / (r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10) WHERE animeid = {aa.AnimeId}";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "DELETE FROM MyList WHERE username = ? AND animeid = ?";
            cmd.Parameters.AddWithValue("?", login.loginuser);
            cmd.Parameters.AddWithValue("?", aa.AnimeId);
            cmd.ExecuteNonQuery();
            AA.LogAction(login.loginuser, aa.AnimeId, $"Deleted {aa.Title} from list.");

            dbc.con.Close();
            dashboard.Dash.Userdetails();
            mess2.Text = "Deleted successfully";
            if (ani != null)
            {
                ani.add.Text = "+"; ani.add.Image = null;
            }
            else if (ani2 != null)
            {
                ani.add.Text = "+"; ani.add.Image = null;
            }
            else if (ani0 != null)
            {
                ani.add.Text = "+"; ani.add.Image = null;
            }
            else if (ani4 != null)
            {
                ani.add.Text = "+"; ani.add.Image = null;
            }
            MessageBox.Show("Successfully deleted anime!");
            this.Close();
        }
        bool scorechange = false;
        private void score_ValueChanged(object sender, EventArgs e)
        {
            scorechange = true;
        }
    }
}
