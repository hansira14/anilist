using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.Forms
{
    public partial class newanime2 : Form
    {
        newanime NW;
        public newanime2(Anime anime, newanime nw)
        {
            InitializeComponent();
            NW=nw;
            if (anime != null)
            {
                genre.Text= anime.Genre;
                themes.Text= anime.Theme;
                save.Enabled = true;
            }
        }
        private void genre_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button toggleButton = (Guna2Button)sender;

            if (toggleButton.Checked)
            {
                if (!genre.Text.Contains(toggleButton.Text))
                {
                    if (!string.IsNullOrEmpty(genre.Text))
                    {
                        genre.Text += ", ";
                    }
                    genre.Text += toggleButton.Text;
                }
            }
            else
            {
                string buttonText = toggleButton.Text;
                genre.Text = genre.Text.Replace(buttonText, string.Empty).Replace(", , ", ", ").Trim(',', ' ');
            }
            if(genre.Text!="") save.Enabled = true;
            else save.Enabled = false;
        }

        private void theme(object sender, EventArgs e)
        {
            Guna2Button toggleButton = (Guna2Button)sender;

            if (toggleButton.Checked)
            {
                if (!themes.Text.Contains(toggleButton.Text))
                {
                    if (!string.IsNullOrEmpty(themes.Text))
                    {
                        themes.Text += ", ";
                    }
                    themes.Text += toggleButton.Text;
                }
            }
            else
            {
                string buttonText = toggleButton.Text;
                themes.Text = themes.Text.Replace(buttonText, string.Empty).Replace(", , ", ", ").Trim(',', ' ');
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            NW.genre.Text = genre.Text;
            NW.okay = true;
            if(themes.Text!="")NW.theme.Text=themes.Text;
            this.Hide();
            NW.ShowDialog();
        }
    }
}
