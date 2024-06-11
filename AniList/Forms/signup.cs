using AniList.Forms;
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
    public partial class signup : Form
    {
        Form F;
        public signup(Form f)
        {
            F = f;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button3.Checked) pass.PasswordChar = '\0';
            else pass.PasswordChar = '*';
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button3.Checked) pass2.PasswordChar = '\0';
            else pass2.PasswordChar = '*';
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            F.Show();
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || fname.Text == "" ||lname.Text == "" ||email.Text == "" ||question1.Text == "" ||question2.Text == "" ||answer1.Text == "" ||answer2.Text == "" ||pass.Text == "" ||pass2.Text == "" )
            {
                MessageBox.Show("Fill-up all fields!"); return;
            }
            if(pass.Text != pass2.Text)
            {
                MessageBox.Show("Passwords do not match"); return;
            }
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
            if (AA.CheckUsername(username.Text) == true)
            {
                MessageBox.Show("Username already exists!"); return;
            }
            if (AA.Strongpass(pass.Text) == false) return;

            dbc.Connect();
            dbc.con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = dbc.con;
            cmd.CommandText = "INSERT INTO Users (username, [password], fname, lname, email, securityquestion1, securityanswer1, securityquestion2, securityanswer2, joined, pic) VALUES (@username, @password, @fname, @lname, @email, @securityquestion1, @securityanswer1, @securityquestion2, @securityanswer2, @joined, @pic)";
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", pass.Text);
            cmd.Parameters.AddWithValue("@fname", fname.Text);
            cmd.Parameters.AddWithValue("@lname", lname.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@securityquestion1", question1.Text);
            cmd.Parameters.AddWithValue("@securityanswer1", answer1.Text);
            cmd.Parameters.AddWithValue("@securityquestion2", question2.Text);
            cmd.Parameters.AddWithValue("@securityanswer2", answer2.Text);
            cmd.Parameters.AddWithValue("@joined", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@pic", picData);
            cmd.ExecuteNonQuery();
            dbc.con.Close();
            MessageBox.Show("Sign-up successful!");
            this.Close();
            F.Show();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (AA.CheckUsername(username.Text) == true)
            {
                MessageBox.Show("Username already exists!");
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (AA.Strongpass(pass.Text) == false) return;
        }
    }
}
