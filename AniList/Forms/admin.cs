using AniList.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AForge.Imaging.Filters.HitAndMiss;

namespace AniList.Forms
{
    public partial class admin : Form
    {
        private Timer timer = new Timer();
        public List<Anime> searchresults = null;
        bool isclick = false;
        public static admin ad { get; private set; }
        public List<UserControl> pageHistory = new List<UserControl>();
        public int currentPageIndex = -1;
        public admin()
        {
            InitializeComponent();
            timer.Interval = 1500;
            timer.Tick += TimerElapsed;
            ad = this;
        }
        private void back_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                page.Controls.Clear();
                if(pageHistory[currentPageIndex] is userprofile)
                {
                   page.AutoScroll = false;
                }
                else page.AutoScroll = true;
                if (pageHistory[currentPageIndex] is tableFav) search.Visible = true;
                else search.Visible = false;
                page.Controls.Add(pageHistory[currentPageIndex]);
                //pageHistory[currentPageIndex].Dock = DockStyle.Fill;
            }
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < pageHistory.Count - 1)
            {
                currentPageIndex++;
                page.Controls.Clear();
                if (pageHistory[currentPageIndex] is userprofile)
                {
                    page.AutoScroll = false;
                }
                else page.AutoScroll = true;
                if (pageHistory[currentPageIndex] is tableFav) search.Visible = true;
                else search.Visible = false;
                page.Controls.Add(pageHistory[currentPageIndex]);
                //pageHistory[currentPageIndex].Dock = DockStyle.Fill;
            }
        }
        public void addUC(UserControl xx)
        {
            pageHistory.RemoveRange(currentPageIndex + 1, pageHistory.Count - currentPageIndex - 1);
            pageHistory.Add(xx);
            page.Controls.Clear();
            if(!(xx is userprofile)) page.AutoScroll = true;
            if (xx is tableFav) search.Visible = true;
            else search.Visible = false;
            page.Controls.Add(xx);
            //xx.Dock = DockStyle.Fill;
            currentPageIndex = pageHistory.Count - 1;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            adminhome adminhome = new adminhome();
            addUC(adminhome);
            home.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login account = new login();
            account.ShowDialog();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            adminhome adminhome = new adminhome();
            addUC(adminhome);
        }

        private void anime_Click(object sender, EventArgs e)
        {
            adminanime aa = new adminanime();
            addUC(aa);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }
        private void TimerElapsed(object sender, EventArgs e)
        {
            timer.Stop();
            this.Invoke(new Action(() =>
            {
                string stext = search.Text.Trim();
                if (string.IsNullOrEmpty(stext))
                {
                    if (isclick == true)
                    {
                        searchresults = retrieve.GetList(99, 0);
                        isclick = false;
                    }
                    else return;
                }
                else searchresults = retrieve.GetList(0, 0, stext);
                tableFav results = new tableFav(searchresults);
                results.table.Controls.Clear();
                results.panel3.Size = new Size(1060, 101);
                addUC(results);
            }));
        }
        int clicks = 0;
        private void search_Click(object sender, EventArgs e)
        {
            clicks++;
            if (clicks == 2)
            {
                TimerElapsed(null, null);
                isclick = true;
                clicks = 0;
            }
        }

        private void user_Click(object sender, EventArgs e)
        {
            adminuser us = new adminuser();
            addUC(us);
            user.Checked = true;
        }
        public void Message(string xx)
        {
            Label messageLabel = new Label();
            messageLabel.AutoSize = true;
            messageLabel.BackColor = Color.FromArgb(239, 147, 98);
            messageLabel.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            messageLabel.ForeColor = Color.FromArgb(18, 18, 18);
            messageLabel.Text = xx;
            int x = (this.ClientSize.Width - messageLabel.Width) / 2;
            messageLabel.Location = new Point(x, 60);
            this.Controls.Add(messageLabel);
            messageLabel.BringToFront();
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (sender, e) =>
            {
                this.Controls.Remove(messageLabel);
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}
