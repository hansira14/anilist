using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using AniList.UC;

namespace AniList
{
    public static class retrieve
    {
        public static List<Anime> GetList(int type, int count = 0,string q=null)
        {
            string ncount;
            List<Anime> animelist = new List<Anime>();
            dbc.Connect();
            dbc.con.Open();
            string query = null;
            if (count == 0) ncount = "";
            else ncount = "TOP " + count.ToString();
            DateTime pastYear = new DateTime(DateTime.Now.Year - 1, 1, 1);
            switch (type)
            {
                case 77:
                    query = $"SELECT F.animeid AS F_animeid, A.* FROM Favorites F INNER JOIN Animelist A ON F.animeid =A.animeid WHERE F.username = '{login.loginuser}'";
                    break;
                case 88:
                    query = q; break;
                case 99:
                    query = "SELECT * FROM Animelist";
                    break;
                case 0:
                    query = "SELECT * FROM Animelist WHERE title LIKE @tt OR english LIKE @tt OR type LIKE @tt OR premiere LIKE @tt OR genre LIKE @tt OR studio LIKE @tt OR status LIKE @tt OR source LIKE @tt OR themes LIKE @tt OR demographics LIKE @tt ORDER BY users DESC";
                    dbc.cmd = new OleDbCommand(query, dbc.con); // initialize dbc.cmd here
                    dbc.cmd.Parameters.AddWithValue("@tt", "%" + q + "%");
                    break;
                case 1: //top airing
                    query = "SELECT " + ncount + " * FROM Animelist WHERE status = 'Currently Airing' ORDER BY rating DESC";
                    break;
                case 2: //most popular
                    query = "SELECT " + ncount + " * FROM Animelist ORDER BY users DESC";
                    break;
                case 3: //most favorited
                    query = "SELECT " + ncount + " * FROM Animelist ORDER BY favorites DESC";
                    break;
                case 4: //trending by premiere season
                    string currentSeason = GetCurrentSeason();
                    query = "SELECT " + ncount + " * FROM Animelist WHERE premiere LIKE @Premiere ORDER BY users DESC";
                    dbc.cmd = new OleDbCommand(query, dbc.con); // initialize dbc.cmd here
                    dbc.cmd.Parameters.AddWithValue("@Premiere", currentSeason + "%");
                    break;
                case 5: //featured
                    query = "SELECT *\r\nFROM Animelist\r\nWHERE animeid IN (SELECT animeid FROM Featured)\r\n";
                    break;
                case 6: //top ranked
                    query = "SELECT " + ncount + " * FROM Animelist ORDER BY rank ASC";
                    break;
                case 7: //most popular SERIES
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type = 'TV' ORDER BY users DESC";
                    break;
                case 8: //most favorited SERIES
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type = 'TV' ORDER BY favorites DESC";
                    break;
                case 9: //top ranked SERIES
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type = 'TV' ORDER BY rank ASC";
                    break;
                case 10: //most popular MOVIES
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type = 'Movie' ORDER BY users DESC";
                    break;
                case 11: //most favorited MOVIES
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type = 'Movie' ORDER BY favorites DESC";
                    break;
                case 12: //top ranked MOVIES
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type = 'Movie' ORDER BY rank ASC";
                    break;
                case 13: //featured MOVIES
                    query = "SELECT *\r\nFROM Animelist\r\nWHERE animeid IN (SELECT animeid FROM FeaturedMovies)\r\n";
                    break;
                case 14: //most popular OTHERS
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type NOT IN ('TV', 'Movie') ORDER BY users DESC";
                    break;
                case 15: //most favorited OTHERS
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type NOT IN ('TV', 'Movie') ORDER BY favorites DESC";
                    break;
                case 16: //top ranked OTHERS
                    query = "SELECT " + ncount + " * FROM Animelist WHERE type NOT IN ('TV', 'Movie') ORDER BY rank ASC";
                    break;
                case 17: //featured OTHERS
                    query = "SELECT *\r\nFROM Animelist\r\nWHERE animeid IN (SELECT animeid FROM FeaturedOthers)\r\n";
                    break;
                case 18://top airing OTHERS
                    query = "SELECT " + ncount + " * FROM Animelist WHERE status = 'Currently Airing' AND type NOT IN ('TV', 'Movie') ORDER BY rating DESC";
                    break;
                case 19://trending MOVIES
                    query = $"SELECT {ncount} * FROM Animelist WHERE type = 'Movie' AND aired >= #{pastYear.ToShortDateString()}# ORDER BY users DESC";
                    break;
                case 20: //trending OTHERS
                    query = $"SELECT {ncount} * FROM Animelist WHERE type NOT IN ('TV', 'Movie') AND aired >= #{pastYear.ToShortDateString()}# ORDER BY users DESC";
                    break;
                case 21: //upcoming
                    query= "SELECT " + ncount + " * FROM Animelist WHERE status = 'Not yet aired' ORDER BY users DESC";
                    break;
            }
            if (type != 4 && type!=0) dbc.cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(dbc.cmd);
            dbc.ds = new DataSet();
            dbc.bridge.Fill(dbc.ds, "Animelist");
            foreach (DataRow row in dbc.ds.Tables["Animelist"].Rows)
            {
                byte[] imageBytes = row["pic"] as byte[];
                Image image = null;

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    // Convert byte array to Image
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }

                DateTime aired, ended;
                if (row["aired"] != DBNull.Value && !string.IsNullOrEmpty(row["aired"].ToString())) aired = DateTime.Parse(row["aired"].ToString());
                else aired = DateTime.MinValue;
                if (row["ended"] != DBNull.Value && !string.IsNullOrEmpty(row["ended"].ToString())) ended = DateTime.Parse(row["ended"].ToString());
                else ended = DateTime.MinValue;
                Anime anime = new Anime(
                    (int)row["animeid"],
                    row["title"].ToString(),
                    row["english"].ToString(),
                    row["poster"].ToString(),
                    row["trailer"].ToString(),
                    (double)row["rating"],
                    (double)row["ratedby"],
                    (double)row["rank"],
                    (double)row["popularity"],
                    (double)row["users"],
                    row["type"].ToString(),
                    row["premiere"].ToString(),
                    row["genre"].ToString(),
                    row["studio"].ToString(),
                    (double)row["episodes"],
                    row["status"].ToString(),
                    aired,
                    ended,
                    row["broadcast"].ToString(),
                    row["source"].ToString(),
                    (double)row["duration"],
                    (double)row["favorites"],
                    row["synopsis"].ToString(),
                    row["relatedanime"].ToString().Replace("\n", "\r\n"),
                    row["themes"].ToString(),
                    row["demographics"].ToString(),
                    (double)row["completedcount"],
                    (double)row["watchingcount"],
                    (double)row["planscount"],
                    (double)row["pausedcount"],
                    (double)row["droppedcount"],
                    (double)row["r10"],
                    (double)row["r9"],
                    (double)row["r8"],
                    (double)row["r7"],
                    (double)row["r6"],
                    (double)row["r5"],
                    (double)row["r4"],
                    (double)row["r3"],
                    (double)row["r2"],
                    (double)row["r1"],
                    image,
                    row["reviews"].ToString()
                   );
                animelist.Add(anime);
            }
            dbc.con.Close();
            return animelist;
        }
        public static List<Youranime> GetYouranime(string qq=null, string user=null)
        {
            string query = null;
            List<Youranime> animelist = new List<Youranime>();
            dbc.Connect();
            dbc.con.Open();
            if (user == null) user = login.loginuser;
            if (qq==null) query = $"SELECT * FROM MyList WHERE username='{user}'";
            else query = qq ;
            dbc.cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(dbc.cmd);
            dbc.ds = new DataSet();
            dbc.bridge.Fill(dbc.ds, "MyList");
            foreach (DataRow row in dbc.ds.Tables["MyList"].Rows)
            {
                DateTime started, finished;
                if (row["started"] != DBNull.Value && !string.IsNullOrEmpty(row["started"].ToString())) started = DateTime.Parse(row["started"].ToString());
                else started = DateTime.MinValue;
                if (row["finished"] != DBNull.Value && !string.IsNullOrEmpty(row["finished"].ToString())) finished = DateTime.Parse(row["finished"].ToString());
                else finished = DateTime.MinValue;
                int id = (int)row["animeid"];
                double score;
                if (!double.TryParse(row["score"]?.ToString(), out score))
                {
                    throw new InvalidCastException($"Unable to cast row[score]: {row["score"]} to double");
                }

                double progress;
                if (!double.TryParse(row["progress"]?.ToString(), out progress))
                {
                    throw new InvalidCastException($"Unable to cast row[progress]: {row["progress"]} to double");
                }

                Youranime anime = new Youranime(
                    row["username"].ToString(),
                    id,
                    score,
                    progress,
                    started,
                    finished,
                    row["status"].ToString(),
                    GetAnime(id)
                );
                animelist.Add(anime);
            }
            dbc.con.Close();
            return animelist;
        }
        public static List<User> GetUserlist()
        {
            List<User> userlist = new List<User>();
            dbc.Connect();
            dbc.con.Open();
            string query = $"SELECT * FROM Users ORDER BY joined DESC";
            dbc.cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(dbc.cmd);
            dbc.ds = new DataSet();
            dbc.bridge.Fill(dbc.ds, "Users");
            foreach (DataRow row in dbc.ds.Tables["Users"].Rows)
            {
                byte[] imageBytes = row["pic"] as byte[];
                Image image = null;

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                DateTime joined;
                if (row["joined"] != DBNull.Value && !string.IsNullOrEmpty(row["joined"].ToString())) joined = DateTime.Parse(row["joined"].ToString());
                else joined = DateTime.MinValue;
                User user = new User(
                    row["username"].ToString(),
                    row["password"].ToString(),
                    row["fname"].ToString(),
                    row["lname"].ToString(),
                    row["email"].ToString(),
                    row["securityquestion1"].ToString(),
                    row["securityanswer1"].ToString(),
                    row["securityquestion2"].ToString(),
                    row["securityanswer2"].ToString(),
                    image,
                    joined,
                    row["preferences"].ToString(),
                    row["plan"].ToString()
                );
                userlist.Add(user);
            }
            dbc.con.Close();
            return userlist;
        }
        public static User GetUser(string usern)
        {
            User user1=null;
            dbc.Connect();
            dbc.con.Open();
            string query = $"SELECT * FROM Users WHERE username='{usern}'";
            dbc.cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(dbc.cmd);
            dbc.ds = new DataSet();
            dbc.bridge.Fill(dbc.ds, "Users");
            if (dbc.ds.Tables["Users"].Rows.Count > 0)
            {
                DataRow row = dbc.ds.Tables["Users"].Rows[0];
                byte[] imageBytes = row["pic"] as byte[];
                Image image = null;

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                DateTime joined;
                if (row["joined"] != DBNull.Value && !string.IsNullOrEmpty(row["joined"].ToString())) joined = DateTime.Parse(row["joined"].ToString());
                else joined = DateTime.MinValue;
                user1 = new User(
                    row["username"].ToString(),
                    row["password"].ToString(),
                    row["fname"].ToString(),
                    row["lname"].ToString(),
                    row["email"].ToString(),
                    row["securityquestion1"].ToString(),
                    row["securityanswer1"].ToString(),
                    row["securityquestion2"].ToString(),
                    row["securityanswer2"].ToString(),
                    image,
                    joined,
                    row["preferences"].ToString(),
                    row["plan"].ToString()
                );
            }
            dbc.con.Close();
            return user1;
        }
        public static List<Userlogs> GetUserlogs(string qq = null, string user = null)
        {
            string query = null;
            List<Userlogs> animelist = new List<Userlogs>();
            dbc.Connect();
            dbc.con.Open();
            if (user == null) user = login.loginuser;
            if (qq == null) query = $"SELECT * FROM UserLog WHERE username='{user}'";
            else query = qq;
            dbc.cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(dbc.cmd);
            dbc.ds = new DataSet();
            dbc.bridge.Fill(dbc.ds, "MyList");
            foreach (DataRow row in dbc.ds.Tables["MyList"].Rows)
            {
                DateTime dt;
                if (row["datetime"] != DBNull.Value && !string.IsNullOrEmpty(row["datetime"].ToString())) dt = DateTime.Parse(row["datetime"].ToString());
                else dt = DateTime.MinValue;
                int id = (int)row["animeid"];
                Userlogs anime = new Userlogs(
                    row["username"].ToString(),
                    id,
                    dt,
                    row["action"].ToString(),
                    GetAnime(id)
                );
                animelist.Add(anime);
            }
            dbc.con.Close();
            animelist = animelist.OrderByDescending(u => u.Dt).ToList();
            return animelist;
        }
        public static Anime GetAnime(int animeid, string qq=null)
        {
            Anime anime = null;
            string query =null;
            if (qq == null) query = $"SELECT * FROM Animelist WHERE animeid = {animeid}";
            else query = qq ;
            dbc.cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(dbc.cmd);
            dbc.ds = new DataSet();
            dbc.bridge.Fill(dbc.ds, "Animelist");

            if (dbc.ds.Tables["Animelist"].Rows.Count > 0)
            {
                DataRow row = dbc.ds.Tables["Animelist"].Rows[0];
                byte[] imageBytes = row["pic"] as byte[];
                Image image = null;

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    // Convert byte array to Image
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                DateTime aired, ended;
                if (row["aired"] != DBNull.Value && !string.IsNullOrEmpty(row["aired"].ToString())) aired = DateTime.Parse(row["aired"].ToString());
                else aired = DateTime.MinValue;
                if (row["ended"] != DBNull.Value && !string.IsNullOrEmpty(row["ended"].ToString())) ended = DateTime.Parse(row["ended"].ToString());
                else ended = DateTime.MinValue;
                anime = new Anime(
                    (int)row["animeid"],
                    row["title"].ToString(),
                    row["english"].ToString(),
                    row["poster"].ToString(),
                    row["trailer"].ToString(),
                    (double)row["rating"],
                    (double)row["ratedby"],
                    (double)row["rank"],
                    (double)row["popularity"],
                    (double)row["users"],
                    row["type"].ToString(),
                    row["premiere"].ToString(),
                    row["genre"].ToString(),
                    row["studio"].ToString(),
                    (double)row["episodes"],
                    row["status"].ToString(),
                    aired,
                    ended,
                    row["broadcast"].ToString(),
                    row["source"].ToString(),
                    (double)row["duration"],
                    (double)row["favorites"],
                    row["synopsis"].ToString(),
                    row["relatedanime"].ToString().Replace("\n", "\r\n"),
                    row["themes"].ToString(),
                    row["demographics"].ToString(),
                    (double)row["completedcount"],
                    (double)row["watchingcount"],
                    (double)row["planscount"],
                    (double)row["pausedcount"],
                    (double)row["droppedcount"],
                    (double)row["r10"],
                    (double)row["r9"],
                    (double)row["r8"],
                    (double)row["r7"],
                    (double)row["r6"],
                    (double)row["r5"],
                    (double)row["r4"],
                    (double)row["r3"],
                    (double)row["r2"],
                    (double)row["r1"],
                    image,
                    row["reviews"].ToString()
                    );
            }
            return anime;
        }

        public static string GetCurrentSeason()
        {
            return "Spring 2023";
            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            if (currentMonth >= 3 && currentMonth <= 5) return "Spring " + currentDate.Year;
            else if (currentMonth >= 6 && currentMonth <= 8) return "Summer " + currentDate.Year;
            else if (currentMonth >= 9 && currentMonth <= 11) return "Fall " + currentDate.Year;
            else return "Winter " + currentDate.Year;
        }
        public static void LoadTrendingAnime(TableLayoutPanel x, int type, int count = 0, int animetype = 0)
        {
            x.Controls.Clear();
            List<Anime> trendingAnime = GetList(type, count);
            x.ColumnCount = trendingAnime.Count;
            int i = 0;
            foreach (Anime z in trendingAnime)
            {
                if (animetype == 0)
                {
                    anime ani = new anime(z);
                    ani.Margin = new Padding(0, 0, 15, 0);
                    x.Controls.Add(ani);
                }
                else
                {
                    animeTop ani = new animeTop(z, i);
                    ani.Margin = new Padding(0, 0, 15, 0);
                    x.Controls.Add(ani);
                    i++;
                }
            }
        }
        public static int Animecount()
        {
            int count = 0;

            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "SELECT COUNT(*) FROM Animelist";

            // Instead of ExecuteNonQuery, which doesn't return any rows,
            // use ExecuteScalar, which returns the first column of the first row.
            count = (int)cmd.ExecuteScalar();

            dbc.con.Close();

            return count;
        }
        public static int Usercount()
        {
            int count = 0;

            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "SELECT COUNT(*) FROM Users";

            // Instead of ExecuteNonQuery, which doesn't return any rows,
            // use ExecuteScalar, which returns the first column of the first row.
            count = (int)cmd.ExecuteScalar();

            dbc.con.Close();

            return count;
        }

    }
}
