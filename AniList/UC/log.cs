using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AniList.UC
{
    public partial class log : UserControl
    {
        Anime aa;
        public log(Userlogs us)
        {
            InitializeComponent();
            AA.SetRoundedRegion(this, 10);
            title.Text = $"{us.Username} {us.Dt.ToString()} : {us.Action}";
            aa = us.Anime;
            if (login.adminmode == true)
            {
                title.Click -= title_Click;
            }
        }

        private void title_Click(object sender, EventArgs e)
        {
            animepage anip = new animepage(aa);
            dashboard.Dash.addUC(anip);
        }

        private void log_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(239, 147, 98);
            title.ForeColor = Color.FromArgb(25, 25, 25);
        }

        private void log_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                title.ForeColor = Color.LightGray;
            }
        }
    }
}
