using AniList.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AniList.Forms
{
    public partial class newanime : Form
    {
        Anime Anime;
        newanime2 nw2;
        public bool okay = false;

        public newanime(Anime anime = null)
        {
            InitializeComponent();
            Anime = anime;
            nw2 = new newanime2(anime, this);
            if (anime != null)
            {
                guna2Button24.Text = "Update";
                if (anime.Poster != "") pic.ImageLocation = anime.Poster;
                else if (anime.Pic != null) pic.Image = anime.Pic;
                else pic.ImageLocation = anime.Poster;
                title.Text = anime.Title;
                engtitle.Text = anime.English;
                trailer.Text = anime.Trailer;
                type.SelectedIndex = type.Items.IndexOf(anime.Type);
                status.SelectedIndex = status.Items.IndexOf(anime.Status);
                studio.Text = anime.Studio;
                try
                {
                    aired.Value = anime.Aired;
                    ended.Value = anime.Ended;
                }
                catch (Exception ex) { }
                episode.Value = (decimal)anime.Episodes;
                duration.Value = (decimal)anime.Duration;
                demo.SelectedIndex = demo.Items.IndexOf(anime.Demo);
                synopsis.Text = anime.Synopsis;
                related.Text = anime.RelatedAnime;
                source.SelectedIndex = source.Items.IndexOf(anime.Source);
                try
                {
                    string[] parts = anime.Premiere.Split(' ');
                    string sea = parts[0];
                    string yer = parts[1];
                    season.SelectedIndex = season.Items.IndexOf(sea);
                    year.SelectedIndex = year.Items.IndexOf(yer);
                }
                catch (Exception ex) { }
                try
                {
                    string[] parts = anime.Broadcast.Split(new string[] { " at " }, StringSplitOptions.None);
                    string dayOfWeek = parts[0];
                    string tim = parts[1];
                    day.SelectedIndex = day.Items.IndexOf(dayOfWeek);
                    time.Text = tim;
                }
                catch (Exception ex) { }
                genre.Text = anime.Genre;
                theme.Text = anime.Theme;
                guna2Button24.Enabled = true;
                guna2Button1.Visible = true;
            }
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status.SelectedIndex == 0)
            {
                if (type.SelectedIndex != 0)
                {
                    aired.Enabled = true; ended.Enabled = false;
                }
                else
                {
                    aired.Enabled = true; ended.Enabled = true;
                }
            }
            else if (status.SelectedIndex == 1)
            {
                aired.Enabled = true; ended.Enabled = false;
            }
            else
            {
                aired.Enabled = false; ended.Enabled = false;
            }
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            if (title.Text == "" || type.SelectedIndex == -1 || status.SelectedIndex == -1 || source.SelectedIndex == -1 || studio.Text == "")
            {
                MessageBox.Show("Fill out all required fields"); return;
            }
            if (type.SelectedIndex == 0)
            {
                if (season.SelectedIndex == -1 || year.SelectedIndex == -1 || day.SelectedIndex == -1 || time.Text == null)
                {
                    MessageBox.Show("Fill out all required fields"); return;
                }
            }
            if (!int.TryParse(episode.Text.ToString(), out _))
            {
                MessageBox.Show("Invalid Episode count");
                return;
            }
            if (!int.TryParse(duration.Value.ToString(), out _))
            {
                MessageBox.Show("Invalid duration value");
                return;
            }
            this.Hide();
            nw2.Show();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedIndex != 0)
            {
                season.Enabled = false; year.Enabled = false; day.Enabled = false; time.Enabled = false;
            }
            else
            {
                season.Enabled = true; year.Enabled = true; day.Enabled = true; time.Enabled = true;
            }
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            string broadcast = $"{day.Text} at {time.Text}";
            string premiere = "";
            string airedd = aired.Text;
            string endedd = ended.Text;
            int rank = retrieve.Animecount() + 1;
            byte[] picData = null;

            if (pic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap bmp = new Bitmap(pic.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    picData = ms.ToArray();
                }
            }
            if (season.SelectedIndex != -1 || year.SelectedIndex != -1) premiere = $"{season.Text} {year.Text}";
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            if (Anime == null)
            {
                if (type.SelectedIndex != 0)
                {
                    if (status.SelectedIndex == 2)
                    {
                        cmd.CommandText = "INSERT INTO Animelist (title, type, genre, studio, episodes, status, source, duration, synopsis, relatedanime, themes, english, trailer,premiere,broadcast," +
                        "rating, ratedby, rank, popularity, users, favorites,planscount,droppedcount,pausedcount,completedcount,watchingcount,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,pic,demographics)" +
                        $"VALUES ('{title.Text}', '{type.Text}', '{genre.Text}', '{studio.Text}', {episode.Text}, '{status.Text}','{source.Text}',{duration.Value},'{synopsis.Text}','{related.Text}','{theme.Text}'," +
                        $"'{engtitle.Text}', '{trailer.Text}', 'N/A', 'N/A', " +
                        $"0,0,{rank},{rank},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,?,'{demo.Text}')";
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Animelist (title, type, genre, studio, episodes, status, source, duration, synopsis, relatedanime, themes, english, trailer,premiere,broadcast, aired," +
                        "rating, ratedby, rank, popularity, users, favorites,planscount,droppedcount,pausedcount,completedcount,watchingcount,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,pic,demographics)" +
                        $"VALUES ('{title.Text}', '{type.Text}', '{genre.Text}', '{studio.Text}', {episode.Text}, '{status.Text}','{source.Text}',{duration.Value},'{synopsis.Text}','{related.Text}','{theme.Text}'," +
                        $"'{engtitle.Text}', '{trailer.Text}', 'N/A', 'N/A', {aired.Text}," +
                        $"0,0,{rank},{rank},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,?,'{demo.Text}')";
                    }
                }
                else
                {
                    if (status.SelectedIndex == 0)
                        cmd.CommandText = "INSERT INTO Animelist (title, type, genre, studio, episodes, status, source, duration, synopsis, relatedanime, themes, english, trailer,premiere, aired, ended, broadcast," +
                        "rating, ratedby, rank, popularity, users, favorites,planscount,droppedcount,pausedcount,completedcount,watchingcount,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,pic,demographics)" +
                        $"VALUES ('{title.Text}', '{type.Text}', '{genre.Text}', '{studio.Text}', {episode.Text}, '{status.Text}','{source.Text}',{duration.Value},'{synopsis.Text}','{related.Text}','{theme.Text}'," +
                        $"'{engtitle.Text}', '{trailer.Text}', '{premiere}', {airedd}, {endedd}, '{broadcast}', " +
                        $"0,0,{rank},{rank},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,?,'{demo.Text}')";
                    else if (status.SelectedIndex == 1)
                        cmd.CommandText = "INSERT INTO Animelist (title, type, genre, studio, episodes, status, source, duration, synopsis, relatedanime, themes, english, trailer,premiere, aired, broadcast," +
                        "rating, ratedby, rank, popularity, users, favorites,planscount,droppedcount,pausedcount,completedcount,watchingcount,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,pic,demographics)" +
                        $"VALUES ('{title.Text}', '{type.Text}', '{genre.Text}', '{studio.Text}', {episode.Text}, '{status.Text}','{source.Text}',{duration.Value},'{synopsis.Text}','{related.Text}','{theme.Text}'," +
                        $"'{engtitle.Text}', '{trailer.Text}', '{premiere}', {airedd}, '{broadcast}', " +
                        $"0,0,{rank},{rank},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,?,'{demo.Text}')";
                    else
                        cmd.CommandText = "INSERT INTO Animelist (title, type, genre, studio, episodes, status, source, duration, synopsis, relatedanime, themes, english, trailer,premiere,broadcast," +
                        "rating, ratedby, rank, popularity, users, favorites,planscount,droppedcount,pausedcount,completedcount,watchingcount,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,pic,demographics)" +
                        $"VALUES ('{title.Text}', '{type.Text}', '{genre.Text}', '{studio.Text}', {episode.Text}, '{status.Text}','{source.Text}',{duration.Value},'{synopsis.Text}','{related.Text}','{theme.Text}'," +
                        $"'{engtitle.Text}', '{trailer.Text}', '{premiere}','{broadcast}', " +
                        $"0,0,{rank},{rank},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,?,'{demo.Text}')";
                }
                cmd.Parameters.AddWithValue("?", picData);
            }
            else
            {
                if (type.SelectedIndex != 0)
                {
                    if (status.SelectedIndex == 2)
                    {
                        cmd.CommandText = $"UPDATE Animelist SET title = '{title.Text}', type = '{type.Text}', genre = '{genre.Text}', studio = '{studio.Text}', episodes = {episode.Text}, status = '{status.Text}', source = '{source.Text}', duration = {duration.Value}, synopsis = '{synopsis.Text}', relatedanime = '{related.Text}', themes = '{theme.Text}', english = '{engtitle.Text}', trailer = '{trailer.Text}', premiere = '{premiere}', broadcast = '{broadcast}', demographics='{demo.Text}'," +
                        "pic=? WHERE animeid = " + Anime.AnimeId;
                    }
                    else
                    {
                        cmd.CommandText = $"UPDATE Animelist SET title = '{title.Text}', type = '{type.Text}', genre = '{genre.Text}', studio = '{studio.Text}', episodes = {episode.Text}, status = '{status.Text}', source = '{source.Text}', duration = {duration.Value}, synopsis = '{synopsis.Text}', relatedanime = '{related.Text}', themes = '{theme.Text}', english = '{engtitle.Text}', trailer = '{trailer.Text}', premiere = '{premiere}', broadcast = '{broadcast}', aired = {aired.Text},demographics='{demo.Text}'," +
                        "pic=? WHERE animeid = " + Anime.AnimeId;
                    }
                }
                else
                {
                    if (status.SelectedIndex == 0)
                    {
                        cmd.CommandText = $"UPDATE Animelist SET title = '{title.Text}', type = '{type.Text}', genre = '{genre.Text}', studio = '{studio.Text}', episodes = {episode.Text}, status = '{status.Text}', source = '{source.Text}', duration = {duration.Value}, synopsis = '{synopsis.Text}', relatedanime = '{related.Text}', themes = '{theme.Text}', english = '{engtitle.Text}', trailer = '{trailer.Text}', premiere = '{premiere}', aired = {aired.Text}, ended = {ended.Text}, broadcast = '{broadcast}',demographics='{demo.Text}'," +
                        "pic=? WHERE animeid = " + Anime.AnimeId;
                    }
                    else if (status.SelectedIndex == 1)
                    {
                        cmd.CommandText = $"UPDATE Animelist SET title = '{title.Text}', type = '{type.Text}', genre = '{genre.Text}', studio = '{studio.Text}', episodes = {episode.Text}, status = '{status.Text}', source = '{source.Text}', duration = {duration.Value}, synopsis = '{synopsis.Text}', relatedanime = '{related.Text}', themes = '{theme.Text}', english = '{engtitle.Text}', trailer = '{trailer.Text}', premiere = '{premiere}', aired = {aired.Text}, broadcast = '{broadcast}',demographics='{demo.Text}'," +
                        "pic=? WHERE animeid = " + Anime.AnimeId;
                    }
                    else
                    {
                        cmd.CommandText = $"UPDATE Animelist SET title = '{title.Text}', type = '{type.Text}', genre = '{genre.Text}', studio = '{studio.Text}', episodes = {episode.Text}, status = '{status.Text}', source = '{source.Text}', duration = {duration.Value}, synopsis = '{synopsis.Text}', relatedanime = '{related.Text}', themes = '{theme.Text}', english = '{engtitle.Text}', trailer = '{trailer.Text}', premiere = '{premiere}', broadcast = '{broadcast}', demographics='{demo.Text}'," +
                        "pic=? WHERE animeid = " + Anime.AnimeId;
                    }
                }
                cmd.Parameters.AddWithValue("?", picData);
            }
            cmd.ExecuteNonQuery();
            dbc.con.Close();
            if (Anime == null)
            {
                MessageBox.Show("Anime added to database!");
                Anime = retrieve.GetAnime(0, "SELECT * FROM Animelist WHERE animeid = (SELECT MAX(animeid) FROM Animelist)");
            }
            else MessageBox.Show("Anime updated!");
            animepage anip = new animepage(Anime);
            admin.ad.addUC(anip);
            this.Close();
        }

        private void newanime_Load(object sender, EventArgs e)
        {
            if (okay == true) guna2Button24.Enabled = true;
        }
        private void pic_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (ofd.ShowDialog() == DialogResult.OK) pic.Image = new Bitmap(ofd.FileName);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dbc.Connect();
            dbc.con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;

            cmd.CommandText = "DELETE FROM MyList WHERE animeid = ?";
            cmd.Parameters.AddWithValue("?", Anime.AnimeId);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM Animelist WHERE animeid = ?";
            cmd.ExecuteNonQuery();

            dbc.con.Close();
            MessageBox.Show("Successfully deleted anime!");
            admin.ad.pageHistory.Clear();
            admin.ad.currentPageIndex = -1;
            List<Anime> searchresults = retrieve.GetList(99);
            tableFav results = new tableFav(searchresults);
            results.panel3.Size = new Size(1060, 101);
            admin.ad.addUC(results);
            this.Close();
        }


        private void trailer_Leave(object sender, EventArgs e)
        {
            string youtubeUrl = trailer.Text;
            string videoId = ExtractVideoId(youtubeUrl);
            trailer.Text = videoId;
        }

        private string ExtractVideoId(string youtubeUrl)
        {
            var regex = new Regex(@"(?:youtube\.com\/(?:[^\/]+\/.+\/|(?:v|e(?:mbed)?)\/|.*[?&]v=)|youtu\.be\/)([^""&?\/\s]{11})");
            var match = regex.Match(youtubeUrl);
            return match.Success ? match.Groups[1].Value : string.Empty;
        }

    }
}
