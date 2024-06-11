using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;
using AniList.UC;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Net;
using System.IO;
using AniList.Forms;

namespace AniList
{
    public partial class dashboard : Form
    {
        string[] preferences = new string[3];
        public static bool menuexpand, userexpand, mouseover, isadd, isclick = false;
        public static int animeID;
        int currentPageIndex = -1;
        public tableFav results;
        public List<Anime> searchresults = null;
        private Timer timer = new Timer();
        public static dashboard Dash { get; private set; }
        List<UserControl> pageHistory = new List<UserControl>();
        home h1;
        List<Youranime> youranime = null;
        List<Anime> recommendations = null;
        public int[] counts = new int[5];
        public string fname, lname, email, secq1, secq2, seca1, seca2;
        public bool premium = false;
        public DateTime joined;
        public Image dp;

        private void ad()
        {
            ads ad = new ads(this);
            ad.ShowDialog();
        }
        private void AdTimer_Tick(object sender, EventArgs e)
        {
            ad();
        }
        private void Dashboard_Activated(object sender, EventArgs e)
        {
            adTimer.Start();
        }
        private void Dashboard_Deactivate(object sender, EventArgs e)
        {
            adTimer.Stop();
        }
        public void Userdetails()
        {
            string username = login.loginuser;
            dbc.Connect();
            dbc.con.Open();
            string[] statuses = { "Completed", "Watching", "Plans to watch", "Paused", "Dropped" };
            for (int i = 0; i < statuses.Length; i++)
            {
                string query = $"SELECT * FROM [MyList] WHERE username='{username}' AND status='{statuses[i]}'";
                OleDbCommand cmd = new OleDbCommand(query, dbc.con);
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read()) count++;
                counts[i] = count;
                reader.Close();
            }
            int ccount = counts[0], wcount = counts[1], pcount = counts[2], pscount = counts[3], dcount = counts[4];
            string queryFav = $"SELECT * FROM [Favorites] WHERE username='{username}'";
            OleDbCommand cmdFav = new OleDbCommand(queryFav, dbc.con);
            OleDbDataReader reader2 = cmdFav.ExecuteReader();
            int favoriteCount = 0;
            while (reader2.Read()) favoriteCount++;
            reader2.Close();
            wtext.Text = wcount.ToString(); ctext.Text = ccount.ToString(); pstext.Text = pscount.ToString();
            ptext.Text = pcount.ToString(); dtext.Text = dcount.ToString(); ftext.Text = favoriteCount.ToString();
            dbc.con.Close();

            youranime = retrieve.GetYouranime($"SELECT * FROM MyList WHERE username='{login.loginuser}' AND status='Watching'");
            watchingtable.Controls.Clear();
            if (youranime == null)
            {
                watching none = new watching(null);
                watchingtable.Controls.Add(none);
            }
            else
            {
                watchingtable.ColumnCount = youranime.Count;
                foreach (Youranime yy in youranime)
                {
                    watching ww = new watching(yy);
                    watchingtable.Controls.Add(ww);
                }
            }
            List<Youranime> checker = retrieve.GetYouranime($"SELECT * FROM MyList WHERE username='{login.loginuser}'");
            recomtable.Controls.Clear();
            recommendations = retrieve.GetList(88, 0, $"SELECT * FROM Animelist WHERE genre LIKE '%{preferences[0]}%' OR genre LIKE '%{preferences[1]}%' OR genre LIKE '%{preferences[2]}%' ORDER BY rating DESC");
            recommendations = recommendations.Where(rec => !checker.Any(ya => ya.AnimeID == rec.AnimeId)).Take(10).ToList();
            if (recommendations == null)
            {
                animeRecom none = new animeRecom(null);
                recomtable.Controls.Add(none);
            }
            else
            {
                recomtable.ColumnCount = recommendations.Count;
                foreach (Anime yy in recommendations)
                {
                    animeRecom a4 = new animeRecom(yy);
                    a4.Margin = new Padding(0, 0, 15, 0);
                    recomtable.Controls.Add(a4);
                }
            }
        }
        public void UserCredentials()
        {
            User user = retrieve.GetUser(login.loginuser);
            fname = user.Fname; lname = user.Lname; email = user.Email;
            secq1 = user.Sq1; secq2 = user.Sq2; seca1 = user.Sa1; seca2 = user.Sa2;
            preferences = user.Preferences.Split(',').Select(p => p.Trim()).ToArray();
            joined = user.Joined;
            if (user.Plan != "basic")
            {
                premium = true;
                plan.Visible = false;
                plan2.Visible = true;
                adTimer.Tick -= AdTimer_Tick;
                this.Activated-= Dashboard_Activated;
                this.Deactivate-= Dashboard_Deactivate;
            }

            dp = profile.Image = user.Pic;

            username.Text = login.loginuser;
            emailadd.Text = email;
        }
        private void back_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                page.Controls.Clear();
                page.Controls.Add(pageHistory[currentPageIndex]);
                pageHistory[currentPageIndex].Dock = DockStyle.Fill;
            }
            series.Checked = false;
            movies.Checked = false;
            others.Checked = false;
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < pageHistory.Count - 1)
            {
                currentPageIndex++;
                page.Controls.Clear();
                page.Controls.Add(pageHistory[currentPageIndex]);
                pageHistory[currentPageIndex].Dock = DockStyle.Fill;
            }
            series.Checked = false;
            movies.Checked = false;
            others.Checked = false;
        }
        public void addUC(UserControl xx)
        {
            pageHistory.RemoveRange(currentPageIndex + 1, pageHistory.Count - currentPageIndex - 1);
            pageHistory.Add(xx);
            page.Controls.Clear();
            page.Controls.Add(xx);
            xx.Dock = DockStyle.Fill;
            currentPageIndex = pageHistory.Count - 1;
        }
        public dashboard()
        {
            InitializeComponent();
            UserCredentials();
            AA.SetRoundedRegion(profile, 7);
            timer.Interval = 1500;
            timer.Tick += TimerElapsed;
            username.Text = login.loginuser;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            Dash = this;
            h1 = new home("home");
            addUC(h1);
            Userdetails();
        }
        private byte[] GetImageBytes(string imageUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadData(imageUrl);
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (menuexpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    menuexpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    menuexpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void usertimer_Tick(object sender, EventArgs e)
        {
            if (userexpand)
            {
                userpanel.Height -= 10;
                if (userpanel.Height == userpanel.MinimumSize.Height)
                {
                    userexpand = false;
                    usertimer.Stop();
                }
            }
            else
            {
                userpanel.Height += 10;
                if (userpanel.Height == userpanel.MaximumSize.Height)
                {
                    userexpand = true;
                    usertimer.Stop();
                }
            }
        }
        private void user_Click(object sender, EventArgs e)
        {
            usertimer.Start();
        }

        private void sidebar_MouseEnter(object sender, EventArgs e)
        {
            if (menuexpand) return;
            sidebarTimer.Start();
        }

        private void sidebar_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            if (!sidebar.ClientRectangle.Contains(mousePos))
            {
                if (mouseover) return;
                if (menuexpand == false) return;
                sidebarTimer.Start();
                if (userexpand) usertimer.Start();
            }
        }

        private void buttonleave(object sender, EventArgs e)
        {
            mouseover = false;
            sidebar_MouseLeave(null, null);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void home_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button radioButton = (Guna.UI2.WinForms.Guna2Button)sender;
            radioButton.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            addUC(h1);
            series.Checked = false;
            movies.Checked = false;
            others.Checked = false;
            //dbc.Connect();
            //dbc.con.Open();
            //string selectQuery = "SELECT [poster] FROM [Animelist]";
            //OleDbCommand selectCmd = new OleDbCommand(selectQuery, dbc.con);
            //OleDbDataReader reader = selectCmd.ExecuteReader();
            //int count = 0;
            //while (reader.Read())
            //{
            //    string imageURL = reader["poster"].ToString();
            //    // Convert image URL to long binary data
            //    byte[] imageBytes = GetImageBytes(imageURL);
            //    // Update the MyList entry with the long binary data
            //    string updateQuery = $"UPDATE Animelist SET ImageBinary=@ImageBinary WHERE poster='{imageURL}'";
            //    OleDbCommand updateCmd = new OleDbCommand(updateQuery, dbc.con);
            //    updateCmd.Parameters.AddWithValue("@ImageBinary", imageBytes);
            //    updateCmd.ExecuteNonQuery();
            //    count++;
            //    richTextBox1.AppendText($"Converted {count} images to long binary data." + Environment.NewLine);
            //    richTextBox1.ScrollToCaret();
            //}
            //reader.Close();
            //dbc.con.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            h1 = new home("home");
            addUC(h1);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(239, 147, 98);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(228, 228, 228);
        }

        private void series_Click(object sender, EventArgs e)
        {
            home s1 = new home("series");
            addUC(s1);
        }

        private void movies_Click(object sender, EventArgs e)
        {
            home m1 = new home("movies"); ;
            addUC(m1);
        }

        private void others_Click(object sender, EventArgs e)
        {
            home o1 = new home("others");
            addUC(o1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist("Watching");
            addUC(youranime);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist("Completed");
            addUC(youranime);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist("Plans to watch");
            addUC(youranime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist("Paused");
            addUC(youranime);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist("Dropped");
            addUC(youranime);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            tableMylist youranime = new tableMylist();
            addUC(youranime);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }
        private void TimerElapsed(object sender, EventArgs e)
        {
            timer.Stop();
            this.Invoke(new Action(() =>
            {
                string stext = search.Text.Trim();
                if (string.IsNullOrEmpty(stext))
                {
                    if (isclick == true)
                    {
                        searchresults = retrieve.GetList(99, 0);
                        isclick = false;
                    }
                    else return;
                }
                else searchresults = retrieve.GetList(0, 0, stext);
                results = new tableFav(searchresults);
                results.table.Controls.Clear();
                addUC(results);
            }));
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            about ab = new about(this);
            ab.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (results != null) results.panel3.Size = new Size(1060, 101);
        }
        int clicks = 0;

        private void button13_Click(object sender, EventArgs e)
        {
            searchresults = retrieve.GetList(77, 0);
            results = new tableFav(searchresults);
            results.table.Controls.Clear();
            addUC(results);
        }
        private const int ScrollAmount = 236;

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            add.tolist(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login account = new login();
            account.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void plan_MouseEnter(object sender, EventArgs e)
        {
            plan.Text = "upgrade";
            plan.BackColor = Color.FromArgb(25, 25, 25);
            plan.ForeColor = Color.FromArgb(239, 147, 98);
        }

        private void plan_MouseLeave(object sender, EventArgs e)
        {
            plan.Text = "basic";
            plan.BackColor = Color.FromArgb(239, 147, 98);
            plan.ForeColor = Color.FromArgb(25, 25, 25);
        }

        private void plan_Click(object sender, EventArgs e)
        {
            PremIntro intro = new PremIntro(this);
            intro.ShowDialog();
        }

        private void plan2_Click(object sender, EventArgs e)
        {
            //ads ad = new ads(this);
            //ad.ShowDialog();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            int newX = Math.Min(watchingtable.Location.X + ScrollAmount, 0);
            watchingtable.Location = new Point(newX, watchingtable.Location.Y);
        }

        private void next_Click(object sender, EventArgs e)
        {
            int maxLeft = watchings.Width - watchingtable.Width;
            if (maxLeft > 0) maxLeft = 0;
            int newX = Math.Max(watchingtable.Location.X - ScrollAmount, maxLeft);
            watchingtable.Location = new Point(newX, watchingtable.Location.Y);
        }

        private void prev2_Click(object sender, EventArgs e)
        {
            int newX = Math.Min(recomtable.Location.X + 165, 0);
            recomtable.Location = new Point(newX, recomtable.Location.Y);
        }

        private void next2_Click(object sender, EventArgs e)
        {
            int maxLeft = panel11.Width - recomtable.Width;
            if (maxLeft > 0) maxLeft = 0;
            int newX = Math.Max(recomtable.Location.X - 165, maxLeft);
            recomtable.Location = new Point(newX, recomtable.Location.Y);
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            userprofile user = new userprofile();
            addUC(user);
        }

        private void profile_Click(object sender, EventArgs e)
        {
            userprofile user = new userprofile();
            addUC(user);
        }

        private void search_Click(object sender, EventArgs e)
        {
            clicks++;
            if (clicks == 2)
            {
                TimerElapsed(null, null);
                isclick = true;
                clicks = 0;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonenter(object sender, EventArgs e)
        {
            mouseover = true;
            sidebar_MouseEnter(null, null);
        }
        public void Message(string xx)
        {
            Label messageLabel = new Label();
            messageLabel.AutoSize = true;
            messageLabel.BackColor = Color.FromArgb(239, 147, 98);
            messageLabel.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            messageLabel.ForeColor = Color.FromArgb(18, 18, 18);
            messageLabel.Text = xx;
            int x = (this.ClientSize.Width - messageLabel.Width) / 2 - 103;
            messageLabel.Location = new Point(x, 60);
            this.Controls.Add(messageLabel);
            messageLabel.BringToFront();
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (sender, e) =>
            {
                this.Controls.Remove(messageLabel);
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
    public static class AA
    {
        public static bool Strongpass(string pass)
        {
            if (CheckPassword(pass) == false)
            {
                MessageBox.Show("Your password must meet the following criteria:\r\nIt should be at least 8 characters long.\r\nIt should contain a combination of uppercase and lowercase letters, numbers, and special characters.\r\nAvoid common patterns and easily guessable passwords.");
                return false;
            }
            else return true;
        }
        public static bool CheckPassword(string password)
        {
            // Check length
            if (password.Length < 8)
            {
                return false;
            }

            // Check complexity
            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    hasSpecialChar = true;
                }
            }

            if (!(hasUppercase && hasLowercase && hasDigit && hasSpecialChar))
            {
                return false;
            }

            // Check common patterns
            string[] commonPatterns = { "123456", "password", "qwerty", "123456789", "12345678", "12345", "1234567", "football", "1234567890", "123123" };
            if (commonPatterns.Contains(password))
            {
                return false;
            }

            return true;
        }

        public static bool CheckUsername(string username)
        {
            bool exists = false;

            dbc.Connect();
            dbc.con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE username = @Username";
            cmd.Parameters.AddWithValue("@Username", username);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                exists = true;
            }

            dbc.con.Close();

            return exists;
        }

        public static void SetRoundedRegion(Control control, int radius)
        {
            Rectangle rectangle = new Rectangle(0, 0, control.Width, control.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }
        public static void LogAction(string user, int id, string action)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "INSERT INTO UserLog ([username], [animeid], [datetime], [action]) " +
                         "VALUES (@Username, @Animeid, @Date, @Action)";
            cmd.Parameters.AddWithValue("@Username", user);
            cmd.Parameters.AddWithValue("@Animeid", id);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@Action", action);
            cmd.ExecuteNonQuery();
        }
        public static void Delete(int id, string type)
        {
            string stat = null;
            switch (type)
            {
                case "Completed":
                    stat = "completedcount";
                    break;
                case "Watching":
                    stat = "watchingcount";
                    break;
                case "Plans to watch":
                    stat = "planscount";
                    break;
                case "Paused":
                    stat = "pausedcount";
                    break;
                case "Dropped":
                    stat = "droppedcount";
                    break;
            }
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"UPDATE Animelist SET {stat} = {stat} - 1, users=users-1 WHERE animeid={id}";
            cmd.ExecuteNonQuery();
        }
        public static void Delete(int id)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"UPDATE Animelist SET favorites = favorites - 1 WHERE animeid={id}";
            cmd.ExecuteNonQuery();
        }
        public static void Update(int id, string type, string type2)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"UPDATE Animelist SET {type} = {type} + 1, {type2}={type2}-1 WHERE animeid={id}";
            cmd.ExecuteNonQuery();
        }
        public static void Updatestat(int id, string type, string type2)
        {
            string stat = null;
            switch (type2)
            {
                case "Completed":
                    stat = "completedcount";
                    break;
                case "Watching":
                    stat = "watchingcount";
                    break;
                case "Plans to watch":
                    stat = "planscount";
                    break;
                case "Paused":
                    stat = "pausedcount";
                    break;
                case "Dropped":
                    stat = "droppedcount";
                    break;
            }
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            if (type == stat) return;
            cmd.CommandText = $"UPDATE Animelist SET {type} = {type} + 1, {stat}={stat}-1 WHERE animeid={id}";
            cmd.ExecuteNonQuery();
        }
        public static void Add(int id, string type)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"UPDATE Animelist SET {type} = {type} + 1,  users=users+1 WHERE animeid={id}";
            cmd.ExecuteNonQuery();
        }
        public static void Add(int id)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"UPDATE Animelist SET favorites = favorites + 1 WHERE animeid={id}";
            cmd.ExecuteNonQuery();
        }
        public static void SetRanks()
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "SELECT a1.animeid, COUNT(a2.animeid) + 1 AS rank INTO TempRanks FROM Animelist AS a1, Animelist AS a2 WHERE a2.rating > a1.rating OR (a2.rating = a1.rating AND a2.ratedby > a1.ratedby) GROUP BY a1.animeid;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Animelist INNER JOIN TempRanks ON Animelist.animeid = TempRanks.animeid SET Animelist.rank = TempRanks.rank;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DROP TABLE TempRanks;";
            cmd.ExecuteNonQuery();
            dbc.con.Close();
        }
    }
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(180, Color.Black)), this.ClientRectangle);
        }
    }
}