using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AniList.Forms
{
    public partial class PremCheckout : Form
    {
        Form parentForm;
        public PremCheckout(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void PremCheckout_Load(object sender, EventArgs e)
        {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string url = "https://payments.gcash.com/gcash-cashier-web/1.2.1/index.html#/login";
            System.Diagnostics.Process.Start(url);
            Thread.Sleep(5000);
            this.Hide();
            PremWelcome welcome = new PremWelcome(dashboard.Dash);
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.com/signin";
            System.Diagnostics.Process.Start(url);
            Thread.Sleep(5000);
            this.Hide();
            PremWelcome welcome = new PremWelcome(dashboard.Dash);
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PremWelcome welcome = new PremWelcome(dashboard.Dash);
            welcome.ShowDialog();
            this.Close();
        }
    }
}
