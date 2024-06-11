using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList
{
    public partial class loading : Form
    {
        int X;
        public loading(int x=1)
        {
            X = x;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        protected override async void OnLoad(EventArgs e)
        {
            if (X == 0) return;
            base.OnLoad(e);
            await Task.Delay(5000);
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
