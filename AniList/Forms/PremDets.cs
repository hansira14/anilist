﻿using System;
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
    public partial class PremDets : Form
    {
        Form parentForm;
        public PremDets(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void PremDets_Load(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PremCheckout premCheckout = new PremCheckout(dashboard.Dash);
            this.Hide();
            premCheckout.ShowDialog();
            this.Close();
        }
    }
}
