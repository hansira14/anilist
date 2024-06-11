using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.Forms
{
    public partial class forgotpass : Form
    {
        Form ff;
        public forgotpass(Form f)
        {
            InitializeComponent();
            ff = f;
        }
        void check()
        {
            string us = useremail.Text;
            string Question1 = question1.SelectedItem.ToString();
            string Answer1 = answer1.Text;
            string Question2 = question2.SelectedItem.ToString();
            string Answer2 = answer2.Text;

            dbc.Connect();
            string query = "SELECT * FROM Users WHERE username = @us OR email = @us";
            OleDbCommand cmd = new OleDbCommand(query, dbc.con);
            cmd.Parameters.AddWithValue("@us", us);

            dbc.con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            bool foundPair = false;

            if (reader.HasRows)
            {
                while (reader.Read() && !foundPair)
                {
                    string dbQuestion1 = reader["securityquestion1"].ToString();
                    string dbAnswer1 = reader["securityanswer1"].ToString();
                    string dbQuestion2 = reader["securityquestion2"].ToString();
                    string dbAnswer2 = reader["securityanswer2"].ToString();

                    if ((dbQuestion1 == Question1 && dbAnswer1 == Answer1 && dbQuestion2 == Question2 && dbAnswer2 == Answer2) ||
                        (dbQuestion1 == Question2 && dbAnswer1 == Answer2 && dbQuestion2 == Question1 && dbAnswer2 == Answer1))
                    {
                        pass1.Visible = true;
                        pass2.Visible = true;
                        guna2Button1.Visible = true;
                        guna2Button2.Visible = true;
                        proceed.Text = "Save";
                        label5.Text = "";
                        foundPair = true;
                    }
                }

                if (!foundPair)
                {
                    pass1.Visible = false;
                    pass2.Visible = false;
                    guna2Button1.Visible = false;
                    guna2Button2.Visible = false;
                    proceed.Text = "Next";
                    label5.Text = "Incorrect security question/answer pair.";
                }
            }
            else label5.Text = "Username/email not found.";

            reader.Close();
            dbc.con.Close();
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                ff.ShowDialog();
            }
            catch (Exception ex)
            {
                ff.Show();
            }
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            check();
            if ((pass1.Text != "" && pass2.Text != "") && pass1.Text == pass2.Text)
            {
                if (AA.Strongpass(pass1.Text) == false || AA.Strongpass(pass2.Text) == false) return;
                label3.Text = "Successfully changed password!";
                dbc.Connect();
                dbc.con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = dbc.con;
                cmd.CommandText = $"UPDATE Users SET [password]='{pass1.Text}' WHERE username='{useremail.Text}'";
                cmd.ExecuteNonQuery();
                dbc.con.Close();
            }
            else label1.Text = "Passwords do not match/invalid.";
        }

        private void pass1_Leave(object sender, EventArgs e)
        {
            if (AA.Strongpass(pass1.Text) == false) return;
        }

        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button2.Checked)
            {
                pass1.PasswordChar = '\0';
                pass2.PasswordChar = '\0';
            }
            else
            {
                pass1.PasswordChar = '*';
                pass2.PasswordChar = '*';

            }
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button1.Checked)
            {
                pass1.PasswordChar = '\0';
                pass2.PasswordChar = '\0';
            }
            else
            {
                pass1.PasswordChar = '*';
                pass2.PasswordChar = '*';

            }
        }
    }
}
