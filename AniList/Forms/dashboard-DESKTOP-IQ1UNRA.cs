using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;
using AniList.UC;

namespace AniList
{
    public partial class dashboard : Form
    {
        public class TransparentPanel : Panel
        {
            public TransparentPanel()
            {
                this.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Black)), this.ClientRectangle);
            }
        }
        bool menuexpand, userexpand, mouseover;
        public static int animeID;
        public static bool isadd;
        home1 h1 = new home1();
        public dashboard()
        {
            InitializeComponent();

        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            AA.SetRoundedRegion(profile, 40);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (menuexpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    menuexpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    menuexpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void usertimer_Tick(object sender, EventArgs e)
        {
            if (userexpand)
            {
                userpanel.Height -= 10;
                if (userpanel.Height == userpanel.MinimumSize.Height)
                {
                    userexpand = false;
                    usertimer.Stop();
                }
            }
            else
            {
                userpanel.Height += 10;
                if (userpanel.Height == userpanel.MaximumSize.Height)
                {
                    userexpand = true;
                    usertimer.Stop();
                }                
            }
        }
        private void user_Click(object sender, EventArgs e)
        {
            usertimer.Start();
        }

        private void sidebar_MouseEnter(object sender, EventArgs e)
        {
            if (menuexpand) return;
            sidebarTimer.Start();
        }

        private void sidebar_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            if (!sidebar.ClientRectangle.Contains(mousePos))
            {
                if (mouseover) return;
                if (menuexpand == false) return;
                sidebarTimer.Start();
                if(userexpand) usertimer.Start();
            }
        }

        private void buttonleave(object sender, EventArgs e)
        {
            mouseover = false;
            sidebar_MouseLeave(null, null);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void urlist_Click(object sender, EventArgs e)
        {
            urlist urlist = new urlist();
            urlist.Show();
        }

        private void home_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button radioButton = (Guna.UI2.WinForms.Guna2Button)sender;
            radioButton.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            page.Controls.Add(h1);
            h1.Dock = DockStyle.Left;
        }

        private void home_Click(object sender, EventArgs e)
        {
            page.Controls.Add(h1);
            h1.Dock = DockStyle.Left;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Add the transparent panel to disable the controls behind it
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            this.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();
            
            // Create the popup window
            test2 popupForm = new test2();
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();

            popupForm.FormClosed += (s, args) =>
            {
                // Remove the transparent panel to enable the controls behind it
                this.Controls.Remove(transparentPanel);
            };
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonenter(object sender, EventArgs e)
        {
            mouseover = true;
            sidebar_MouseEnter(null, null);
        }
    }
    public static class AA
    {
        public static void SetRoundedRegion(Control control, int radius)
        {
            Rectangle rectangle = new Rectangle(0, 0, control.Width, control.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }
    }
}