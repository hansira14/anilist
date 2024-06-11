using CefSharp.DevTools.Profiler;
using FontAwesome.Sharp;
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

namespace AniList.Forms
{
    public partial class accountsettings : Form
    {
        bool correct = false;
        public accountsettings()
        {
            InitializeComponent();
            AA.SetRoundedRegion(pic, 7);
            fname.Text = dashboard.Dash.fname; lname.Text = dashboard.Dash.lname;
            email.Text = dashboard.Dash.email; username.Text = login.loginuser;
            pic.Image = dashboard.Dash.dp;
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

        private void proceed_Click(object sender, EventArgs e)
        {
            if (AA.CheckUsername(username.Text) == true && username.Text != login.loginuser)
            {
                MessageBox.Show("Username already exists!");
                return;
            }
            if (correct == false)
            {
                passmessage.Text = "Password invalid"; return;
            }
            if (username.Text == "" || fname.Text == "" || lname.Text == "" || email.Text == "")
            {
                savemessage.Text = "Fill up all required fields!"; return;
            }
            byte[] picData=null;

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


            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.Connection = dbc.con;
            if (npass.Text == "" && npass2.Text == "")
            {
                cmd.CommandText = $"UPDATE Users SET username='{username.Text}', fname='{fname.Text}', lname='{lname.Text}', email='{email.Text}', pic=@pic WHERE username='{login.loginuser}'";
            }
            else if (npass.Text == npass2.Text)
            {
                if (AA.Strongpass(npass.Text) == false)
                {
                    dbc.con.Close(); return;
                }
                cmd.CommandText = $"UPDATE Users SET username='{username.Text}', [password]='{npass.Text}', fname='{fname.Text}', lname='{lname.Text}', email='{email.Text}', pic=@pic WHERE username='{login.loginuser}'";
            }
            else
            {
                passmessage2.Text = "Passwords do not match!"; dbc.con.Close(); return;
            }
            cmd.Parameters.AddWithValue("@pic", picData);
            login.loginuser = username.Text;
            cmd.ExecuteNonQuery();
            dbc.con.Close();
            savemessage.Text = "Credentials updated successfully!";
            dashboard.Dash.UserCredentials();
        }

        private void cpass_Leave(object sender, EventArgs e)
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = $"SELECT password FROM Users WHERE username = '{login.loginuser}'";
            OleDbDataReader reader = cmd.ExecuteReader();
            string dbPassword = "";
            while (reader.Read()) dbPassword = reader.GetString(0);
            dbc.con.Close();
            if (dbPassword == cpass.Text)
            {
                npass.Enabled = true; npass2.Enabled = true;
                guna2Button3.Enabled = true;guna2Button4.Enabled = true;
                passmessage.Text = "";
                correct = true;
            }
            else
            {
                passmessage.Text = "Password mismatch!";
                npass.Enabled = false; npass2.Enabled = false;
                guna2Button3.Enabled = false; guna2Button4.Enabled = false;
                correct = false;
            }
        }

        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button2.Checked) cpass.PasswordChar = '\0';
            else cpass.PasswordChar = '*';
        }

        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button3.Checked) npass.PasswordChar = '\0';
            else npass.PasswordChar = '*';
        }

        private void guna2Button4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button4.Checked) npass2.PasswordChar = '\0';
            else npass2.PasswordChar = '*';
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            forgotpass fp = new forgotpass(this);
            this.Hide();
            fp.ShowDialog();
        }

        private void cpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbc.Connect();
                dbc.con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = dbc.con;
                cmd.CommandText = $"SELECT password FROM Users WHERE username = '{login.loginuser}'";
                OleDbDataReader reader = cmd.ExecuteReader();
                string dbPassword = "";
                while (reader.Read()) dbPassword = reader.GetString(0);
                dbc.con.Close();
                if (dbPassword == cpass.Text)
                {
                    npass.Enabled = true; npass2.Enabled = true;
                    guna2Button3.Enabled = true; guna2Button4.Enabled = true;
                    passmessage.Text = "";
                    correct = true;
                }
                else
                {
                    passmessage.Text = "Password mismatch!";
                    npass.Enabled = false; npass2.Enabled = false;
                    guna2Button3.Enabled = false; guna2Button4.Enabled = false;
                    correct = false;
                }
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == login.loginuser) return;
            if (AA.CheckUsername(username.Text) == true)
            {
                MessageBox.Show("Username already exists!");
            }
        }

        private void npass_Leave(object sender, EventArgs e)
        {
            if (AA.Strongpass(npass.Text) == false) return;
        }
    }
}
