using AniList.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList
{
    public partial class watching : UserControl
    {
        Anime aa;
        public watching(Youranime z)
        {
            InitializeComponent();
            if (z == null)
            {
                //this.Enabled = false;
                return;
            }
            aa = z.anime;
            AA.SetRoundedRegion(panel1, 8);
            AA.SetRoundedRegion(pictureBox1, 6);
             if(aa.Poster!="")pictureBox1.ImageLocation = aa.Poster;
            else if (aa.Pic != null) pictureBox1.Image = aa.Pic;
            else pictureBox1.ImageLocation = aa.Poster;
            if (aa.Episodes > 0) progress.Maximum = Convert.ToInt32(aa.Episodes);
            else progress.Maximum = 24;
            progress.Value = Convert.ToInt32(z.Progress);
            title.Text = aa.Title;
            eps.Text = aa.Episodes.ToString() + " episodes";
        }
        private void sMouseEnter(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void sMouseLeave(object sender, EventArgs e)
        {
            if (!panel1.ClientRectangle.Contains(panel1.PointToClient(Control.MousePosition)))
                button1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            animepage anip = new animepage(aa);
            dashboard.Dash.addUC(anip);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progress.Value <= aa.Episodes || aa.Episodes==0)
            {
                if(progress.Value == aa.Episodes-1)
                {
                    progress.Value++;
                    dbc.Connect();
                    dbc.con.Open();
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = dbc.con;
                    cmd2.CommandText = $"UPDATE MyList SET status = ?, finished = ?, progress = ? WHERE username = ? AND animeid = ?";
                    cmd2.Parameters.AddWithValue("?", "Completed");
                    cmd2.Parameters.AddWithValue("?", DateTime.Now.ToString("MM/dd/yyyy"));
                    cmd2.Parameters.AddWithValue("?", aa.Episodes);
                    cmd2.Parameters.AddWithValue("?", login.loginuser);
                    cmd2.Parameters.AddWithValue("?", aa.AnimeId);
                    cmd2.ExecuteNonQuery();
                    AA.Updatestat(aa.AnimeId, "completedcount", "Watching");
                    AA.LogAction(login.loginuser, aa.AnimeId, $"Comepleted watching {aa.Title}.");
                    dbc.con.Close();
                    dashboard.Dash.Userdetails();
                    dashboard.Dash.Message("Anime COMPLETED!");
                    return;

                }
                else progress.Value++;
            }
            else return;
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"UPDATE MyList SET progress = progress + 1 WHERE username = '{login.loginuser}' AND animeid = {aa.AnimeId};";
            cmd.ExecuteNonQuery();
            AA.LogAction(login.loginuser, aa.AnimeId, $"{aa.Title} progress increased");
            dbc.con.Close();
            //dashboard.Dash.Userdetails();
            dashboard.Dash.Message("Progress updated!");
        }

        private void title_TextChanged_1(object sender, EventArgs e)
        {
            if (title.Text.Length > 20) title.Text = title.Text.Substring(0, 18) + "...";
        }
    }
}
