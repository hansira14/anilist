using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AniList.UC;
using Guna.UI2.WinForms;

namespace AniList
{
    public partial class animeMylist : UserControl
    {
        Anime aa;
        Youranime yy;
        dashboard dash;
        PictureBox pic;
        public int x = 106, y = 30;
        private void anime_Load(object sender, EventArgs e)
        {
            title.Text = aa.Title;
            rating.Text = aa.Rating.ToString();
            dash = this.ParentForm as dashboard;
            yourscore.Text = yy.Score.ToString();
            progress.Text = yy.Progress.ToString();
            stat.Text = yy.Status.ToString();
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (title.Text.Length > 50) title.Text = title.Text.Substring(0, 20) + "...";
        }

        public animeMylist(Youranime z)
        {
            yy = z;
            aa = z.anime;
            InitializeComponent();
            if (login.adminmode == true)
            {
                pictureBox1.Click -= pictureBox1_Click;
                title.Click -= title_Click;
            }
              if(aa.Poster!="")pictureBox1.ImageLocation = aa.Poster;
            else if (aa.Pic != null) pictureBox1.Image = aa.Pic;
            else pictureBox1.ImageLocation = aa.Poster;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            tableMylist parentfinal=null;
            while (parent != null)
            {
                if (parent is tableMylist)
                {
                    parentfinal= (tableMylist)parent;
                    break;
                }
                parent = parent.Parent;
            }
            add.tolist(this.FindForm(), yy.Status, aa, parentfinal);
            if (pic != null) pic.Dispose();
        }

        private void anime2_Leave(object sender, EventArgs e)
        {
            if (pic != null) pic.Dispose();
        }
        private void anime3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(239, 147, 98);
            Color textColor = Color.FromArgb(25, 25, 25);
            title.ForeColor = textColor;
            rating.ForeColor = textColor;
            yourscore.ForeColor = textColor;
            progress.ForeColor = textColor;
            stat.ForeColor = textColor;
            pictureBox1.Image = Properties.Resources.more;
            pic = new PictureBox();
            pic.Size = new Size(106, 145);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
              if(aa.Poster!="") pic.ImageLocation = aa.Poster;
            else if (aa.Pic != null) pic.Image = aa.Pic;
            else pic.ImageLocation = aa.Poster;
            Form parentForm = this.FindForm();
            Point animeLocation = this.PointToScreen(Point.Empty);
            Point formLocation = parentForm.PointToClient(animeLocation);

            pic.Location = new Point(formLocation.X - x, formLocation.Y - y);
            parentForm.Controls.Add(pic);
            pic.BringToFront();

        }

        private void anime3_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                title.ForeColor = Color.LightGray;
                rating.ForeColor = Color.FromArgb(228, 191, 102);
                yourscore.ForeColor = Color.LightGray; 
                progress.ForeColor = Color.LightGray; 
                stat.ForeColor = Color.LightGray;
                  if(aa.Poster!="")pictureBox1.ImageLocation = aa.Poster;
                else if (aa.Pic != null) pictureBox1.Image = aa.Pic;
                else pictureBox1.ImageLocation = aa.Poster;

            }
            Form parentForm = FindForm();

            if (parentForm != null)
            {
                foreach (Control control in parentForm.Controls)
                {
                    if (control is PictureBox)
                    {
                        parentForm.Controls.Remove(control);
                        control.Dispose();
                    }
                }
            }
        }

        private void title_Click(object sender, EventArgs e)
        {
            animepage anip = new animepage(aa, yy.Status);
            dash.addUC(anip);
            if (pic != null) pic.Dispose();
        }
    }
}