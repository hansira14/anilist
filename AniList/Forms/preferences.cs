using AniList.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList
{
    public partial class preferences : Form
    {
        Form F;
        public preferences(Form f)
        {
            F = f;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void proceed_Click(object sender, EventArgs e)
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;

            cmd.CommandText = "UPDATE Users SET preferences = @preferences WHERE username = @username";
            cmd.Parameters.AddWithValue("@preferences", genre.Text);
            cmd.Parameters.AddWithValue("@username", login.loginuser);

            cmd.ExecuteNonQuery();
            dbc.con.Close();

            MessageBox.Show("Preferences Set!");
            this.Hide();
            dashboard dash = new dashboard();
            dash.ShowDialog();
            this.Close();

        }

        List<string> selectedGenres = new List<string>();

        private void guna2Button1_CheckedChanged_1(object sender, EventArgs e)
        {
            Guna2Button toggleButton = (Guna2Button)sender;

            if (toggleButton.Checked)
            {
                // check if the list has less than 3 genres and if this genre is not already selected
                if (selectedGenres.Count < 3 && !selectedGenres.Contains(toggleButton.Text))
                {
                    selectedGenres.Add(toggleButton.Text);
                }
                else
                {
                    // Prevent checking if 3 genres are already selected
                    toggleButton.Checked = false;
                }
            }
            else
            {
                if (selectedGenres.Contains(toggleButton.Text))
                {
                    selectedGenres.Remove(toggleButton.Text);
                }
            }

            // update genre.Text with the currently selected genres
            genre.Text = string.Join(", ", selectedGenres);

            if (selectedGenres.Count > 0)
            {
                proceed.Enabled = true;
            }
            else
            {
                proceed.Enabled = false;
            }
        }



    }
}
