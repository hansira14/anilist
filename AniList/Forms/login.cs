using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Data.OleDb;
using AniList.Forms;
using AniList.UC;

namespace AniList
{
    public partial class login : Form
    {
        public static bool adminmode = false;
        public static string loginuser; 
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dbc.Connect();
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }


        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            if (admin.Checked == true)
            {
                label1.Text = "Admin Log-in";
                signup.Visible = false;
                forgot.Visible = false;
            }
            else
            {
                label1.Text = "Log-in";
                signup.Visible = true;
                forgot.Visible = true;
            }
        }

        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button3.Checked) pass.PasswordChar = '\0';
            else pass.PasswordChar = '*';
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text != "" && pass.Text != "") proceed.Enabled = true;
            else proceed.Enabled = false;
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (username.Text != "" && pass.Text != "") proceed.Enabled = true;
            else proceed.Enabled = false;
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            if (admin.Checked == true)
            {
                if(username.Text=="admin" && pass.Text == "1234")
                {

                    this.Hide();
                    adminmode = true;
                    admin ad = new admin();
                    ad.ShowDialog();
                    this.Close();
                }
                else status.Text = "Incorrent admin username or password!";
            }
            else
            {
                string selectQuery = "SELECT * FROM Users WHERE username=@username AND password=@password";
                OleDbCommand cmd = new OleDbCommand(selectQuery, dbc.con);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                dbc.con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && username.Text == reader["username"].ToString() && pass.Text == reader["password"].ToString())
                {
                    adminmode = false;
                    dbc.con.Close();
                    loginuser = username.Text;
                    status.Text = "";
                    this.Hide();
                    Checkpreferences();
                }
                else status.Text = "Incorrent username or password!";
                reader.Close();
                dbc.con.Close();
            }
        }
        void Checkpreferences()
        {
            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;

            cmd.CommandText = "SELECT preferences FROM Users WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", loginuser);

            var result = cmd.ExecuteScalar();
            dbc.con.Close();

            if (result == null || result.ToString() == "")
            {
                preferences pref = new preferences(this);
                pref.ShowDialog();
            }
            else
            {
                dashboard dash = new dashboard();
                dash.ShowDialog();
                this.Close();
                return;
            }

        }
        private void forgot_MouseEnter(object sender, EventArgs e)
        {
            Label lab = sender as Label;
            lab.ForeColor = Color.FromArgb(18,18,18);
        }

        private void forgot_MouseLeave(object sender, EventArgs e)
        {
            Label lab = sender as Label;
            lab.ForeColor = Color.FromArgb(178, 178, 178);
        }

        private void forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotpass ad = new forgotpass(this);
            ad.ShowDialog();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup ad = new signup(this);
            ad.ShowDialog();
        }
    }
}
