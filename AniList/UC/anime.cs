using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AniList.UC;
using Guna.UI2.WinForms;
using static System.Windows.Forms.AxHost;

namespace AniList
{
    public partial class anime : UserControl
    {
        Anime aa;
        details det;
        dashboard dash;
        string status=null;

        private void anime_Load(object sender, EventArgs e)
        {
            label1.Text = aa.Title;
            label2.Text = aa.Premiere;
            label3.Text = aa.Rating.ToString();
            dash = this.ParentForm as dashboard;
            Statcheck();
        }
        public void Statcheck()
        {
            status = null;
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand checkCmd = new OleDbCommand();
            checkCmd.Connection = dbc.con;
            checkCmd.CommandText = "SELECT * FROM Mylist WHERE animeid = ? AND username = ?";
            checkCmd.Parameters.AddWithValue("?", aa.AnimeId);
            checkCmd.Parameters.AddWithValue("?", login.loginuser);
            OleDbDataReader reader = checkCmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                status = reader.GetString(reader.GetOrdinal("status"));
                reader.Close();
            }
            dbc.con.Close();
            if (status != null)
            {
                add.Text = ""; add.Image = Properties.Resources.edit;
            }
            else
            {
                add.Text = "+"; add.Image = null;
            }
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text.Length > 26) label1.Text = label1.Text.Substring(0, 24) + "...";
        }

        public anime(Anime z)
        {
            aa = z;
            InitializeComponent();
            AA.SetRoundedRegion(this, 25);
            if (login.adminmode == true)
            {
                panel2.Visible = false;
                pictureBox1.Click -= pictureBox1_Click;
            }
              if(aa.Poster!="")pictureBox1.ImageLocation = aa.Poster;
            else if (aa.Pic != null) pictureBox1.Image = aa.Pic;
            else pictureBox1.ImageLocation = aa.Poster;
            pictureBox1.Controls.Add(panel2);
            panel2.BackColor = Color.FromArgb(0, Color.Black);


            //panel1.BackColor = Color.FromArgb(200, Color.Black);
            //using (var client = new WebClient())
            //{
            //    using (var stream = client.OpenRead(aa.Poster))
            //    {
            //        Bitmap baseImage = new Bitmap(stream);
            //        Rectangle cropArea = new Rectangle(0, 191, baseImage.Width, 48);
            //        Bitmap croppedImage = baseImage.Clone(cropArea, baseImage.PixelFormat);
            //        Bitmap blurredImage = new Bitmap(croppedImage);
            //        AForge.Imaging.Filters.GaussianBlur filter = new AForge.Imaging.Filters.GaussianBlur(30, 10);
            //        filter.ApplyInPlace(blurredImage);
            //        Bitmap overlay = new Bitmap(croppedImage.Width, croppedImage.Height);
            //        using (Graphics g = Graphics.FromImage(overlay))
            //        {
            //            Color transparentColor = Color.FromArgb(128, 0, 0, 0);
            //            SolidBrush brush = new SolidBrush(transparentColor);
            //            g.FillRectangle(brush, 0, 0, overlay.Width, overlay.Height);
            //        }
            //        Bitmap combinedImage = new Bitmap(croppedImage.Width, croppedImage.Height);
            //        using (Graphics g = Graphics.FromImage(combinedImage))
            //        {
            //            g.DrawImage(blurredImage, 0, 0);
            //            g.DrawImage(overlay, 0, 0);
            //        }
            //        panel1.BackgroundImage = combinedImage;
            //    }
            //}
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            add.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            if (!panel2.ClientRectangle.Contains(panel2.PointToClient(Control.MousePosition)))
            {
                add.Visible = false;
                if (parentForm != null)
                {
                    foreach (Control control in parentForm.Controls)
                    {
                        if (control is details)
                        {
                            parentForm.Controls.Remove(control);
                            control.Dispose();
                        }
                    }
                }
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            det = new details(aa.Title, aa.English, aa.Studio, aa.Type, aa.Episodes.ToString(), aa.Rank.ToString(), aa.Genre);
            Form parentForm = this.FindForm();
            Point animeLocation = this.PointToScreen(Point.Empty);
            Point formLocation = parentForm.PointToClient(animeLocation);
            Rectangle area = new Rectangle(74, 73, 860, 631);
            if (area.Contains(formLocation))
            {
                det.Location = new Point(formLocation.X - det.Width + 465, formLocation.Y);
                parentForm.Controls.Add(det);
                det.BringToFront();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Statcheck();
            AniList.add.tolist(this.FindForm(), status, aa, this);
            if (det != null) det.Dispose();
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            fin.Visible = true; p2w.Visible = true; watch.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            Rectangle rectangularArea = new Rectangle(91, 11, 123, 28);
            if (!rectangularArea.Contains(PointToClient(MousePosition)))
            {
                fin.Visible = false;
                p2w.Visible = false;
                watch.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Statcheck();
            animepage anip = new animepage(aa, status);
            dash.addUC(anip);
            if (det != null) det.Dispose();
        }

        private void anime_Leave(object sender, EventArgs e)
        {
            if (det != null) det.Dispose();
        }

        private void watch_Click(object sender, EventArgs e)
        {
            if (aa.Status == "Not yet aired")
            {
                dash.Message("Anime not yet aired!");
                return;
            }
            if (Check("Watching") == true) return;
            OleDbCommand insertCmd = new OleDbCommand();
            insertCmd.Connection = dbc.con;
            insertCmd.CommandText = "INSERT INTO Mylist (username, animeid, started, status) " +
                                     "VALUES (?, ?, ?, 'Watching')";
            insertCmd.Parameters.AddWithValue("?", login.loginuser);
            insertCmd.Parameters.AddWithValue("?", aa.AnimeId);
            insertCmd.Parameters.AddWithValue("?", DateTime.UtcNow.ToString());
            insertCmd.ExecuteNonQuery();
            AA.Add(aa.AnimeId, "watchingcount");
            AA.LogAction(login.loginuser, aa.AnimeId, $"Added {aa.Title} as Watching.");
            dash.Message("Anime added to WATCHING");
            dbc.con.Close();
            add.Text = ""; add.Image = Properties.Resources.edit;
            dash.Userdetails();
        }


        private void fin_Click(object sender, EventArgs e)
        {
            if (aa.Status == "Not yet aired")
            {
                dash.Message("Anime not yet aired!"); return;
            }
            else if(aa.Status == "Currently Airing")
            {
                dash.Message("Anime not yet finished!"); return;
            }
            if (Check("Completed") == true) return;
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "INSERT INTO Mylist (username, animeid, started, status, finished,progress) " +
                              "VALUES (?, ?, ?, 'Completed',?,?)";
            cmd.Parameters.AddWithValue("?", login.loginuser);
            cmd.Parameters.AddWithValue("?", aa.AnimeId);
            cmd.Parameters.AddWithValue("?", DateTime.UtcNow.ToString());
            cmd.Parameters.AddWithValue("?", DateTime.UtcNow.ToString());
            cmd.Parameters.AddWithValue("?", aa.Episodes);
            cmd.ExecuteNonQuery();
            dash.Message("Anime added to COMPLETED");
            AA.Add(aa.AnimeId, "completedcount");
            AA.LogAction(login.loginuser, aa.AnimeId, $"Added {aa.Title} as Completed.");
            dbc.con.Close();
            add.Text = ""; add.Image = Properties.Resources.edit;
            dash.Userdetails();
        }

        private void p2w_Click(object sender, EventArgs e)
        {
            if (Check("Plans to watch") == true) return;
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "INSERT INTO Mylist (username, animeid, status) " +
                              "VALUES (?, ?, 'Plans to watch')";
            cmd.Parameters.AddWithValue("?", login.loginuser);
            cmd.Parameters.AddWithValue("?", aa.AnimeId);
            cmd.ExecuteNonQuery();
            AA.Add(aa.AnimeId, "planscount");
            AA.LogAction(login.loginuser, aa.AnimeId, $"Added {aa.Title} as Plans to watch.");
            dbc.con.Close();
            dash.Message("Anime added to PLANS TO WATCH");
            add.Text = ""; add.Image = Properties.Resources.edit;
            dash.Userdetails();
        }
        private bool Check(string stat)
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand checkCmd = new OleDbCommand();
            checkCmd.Connection = dbc.con;
            checkCmd.CommandText = "SELECT * FROM Mylist WHERE animeid = ? AND username = ?";
            checkCmd.Parameters.AddWithValue("?", aa.AnimeId);
            checkCmd.Parameters.AddWithValue("?", login.loginuser);
            OleDbDataReader reader = checkCmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                status = reader.GetString(reader.GetOrdinal("status"));
                reader.Close();
                if (status == stat)
                {
                    dash.Message("Anime already added");
                    return true;
                }
                else
                {
                    OleDbCommand updateCmd = new OleDbCommand();
                    updateCmd.Connection = dbc.con;
                    switch (stat)
                    {
                        case "Watching":
                            AA.Updatestat(aa.AnimeId, "watchingcount", status);
                            updateCmd.CommandText = "UPDATE Mylist SET started = ?, status = 'Watching' " +
                            "WHERE animeid = ? AND username = ?";
                            updateCmd.Parameters.AddWithValue("?", DateTime.UtcNow.ToString());
                            updateCmd.Parameters.AddWithValue("?", aa.AnimeId);
                            updateCmd.Parameters.AddWithValue("?", login.loginuser);
                            break;
                        case "Completed":
                            AA.Updatestat(aa.AnimeId, "completedcount", status);
                            updateCmd.CommandText = "UPDATE Mylist SET started = ?, status = 'Completed', finished=?, progress=? " +
                            "WHERE animeid = ? AND username = ?";
                            updateCmd.Parameters.AddWithValue("?", DateTime.UtcNow.ToString());
                            updateCmd.Parameters.AddWithValue("?", DateTime.UtcNow.ToString());
                            updateCmd.Parameters.AddWithValue("?", aa.Episodes);
                            updateCmd.Parameters.AddWithValue("?", aa.AnimeId);
                            updateCmd.Parameters.AddWithValue("?", login.loginuser);
                            break;
                        case "Plans to watch":
                            AA.Updatestat(aa.AnimeId, "planscount", status);
                            updateCmd.CommandText = "UPDATE Mylist SET status = 'Plans to watch'" +
                            "WHERE animeid = ? AND username = ?";
                            updateCmd.Parameters.AddWithValue("?", aa.AnimeId);
                            updateCmd.Parameters.AddWithValue("?", login.loginuser);
                            break;
                    }
                    updateCmd.ExecuteNonQuery();
                    AA.LogAction(login.loginuser, aa.AnimeId, $"Updated {aa.Title} as {stat}.");
                    dash.Message($"Anime updated to {stat}!");
                    dbc.con.Close();
                    dash.Userdetails();
                    return true;
                }
            }
            return false;
        }
    }
}
