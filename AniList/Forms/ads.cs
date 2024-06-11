using System;
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
    public partial class ads : Form
    {
        Form parentForm;
        private int countdownSeconds = 20;
        public ads(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void about_Load(object sender, EventArgs e)
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
        private void PlayYouTubeVideo()
        {
            // List of YouTube video IDs
            List<string> videoIds = new List<string>
            {
                "pBk4NYhWNMM",
                "uYPbbksJxIg",
                "fC5MKJDW6sc",
                "SDJSFWWfHZ4",
                "5V2psjur6H8",
                "-AwqHDEeiog"
            };

            // Generate a random index to select a video ID from the list
            Random random = new Random();
            int randomIndex = random.Next(0, videoIds.Count);

            // Get the randomly selected video ID
            string yt = videoIds[randomIndex];

            // Construct the URL with the randomly selected video ID
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&playlist={0}&controls=0&vq=hd1080&rel=0&mute=1", yt);

            // Load the URL in the ChromiumWebBrowser control
            chromiumWebBrowser1.Load(url);
        }

        private void ChromiumWebBrowser1_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            PlayYouTubeVideo();
            timer1.Start();
        }
       

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            PremIntro intro = new PremIntro(dashboard.Dash);
            intro.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownSeconds--;

            if (countdownSeconds == 0)
            {
                // Timer reached 0, set the final text and enable the "Skip" button
                UpdateButtonProperties("SKIP AD", true);
                timer1.Stop(); // Stop the timer since we don't need it anymore
            }
            else
            {
                // Update the button text with the current countdown value
                UpdateButtonProperties(countdownSeconds.ToString(), false);
            }
        }
        private void UpdateButtonProperties(string text, bool isEnabled)
        {
            if (skip.InvokeRequired)
            {
                skip.Invoke((MethodInvoker)delegate
                {
                    skip.Text = text;
                    skip.Enabled = isEnabled;
                });
            }
            else
            {
                skip.Text = text;
                skip.Enabled = isEnabled;
            }
        }
        private void skip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
