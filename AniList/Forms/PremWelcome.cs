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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace AniList.Forms
{
    public partial class PremWelcome : Form
    {
        Form parentForm;
        public PremWelcome(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void PremWelcome_Load(object sender, EventArgs e)
        {

dbc.Connect();

            dbc.con.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = dbc.con;
            cmd.Connection = dbc.con;
            
            cmd.CommandText = $"UPDATE Users SET plan='premium' WHERE username='{login.loginuser}'";


           


            cmd.ExecuteNonQuery();

            dbc.con.Close();

          

            dashboard.Dash.UserCredentials();

            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();
            Form popupForm = this;
            popupForm.TopMost = true;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
            };
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
