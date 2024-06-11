using CefSharp.WinForms;
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
    public partial class Ad : Form
    {
        Form parentForm;
        public Ad(Form parentForm)
        {
            InitializeComponent();
            chromiumWebBrowser1.IsBrowserInitializedChanged += ChromiumWebBrowser1_IsBrowserInitializedChanged;
            this.parentForm = parentForm;
        }

        private void Ad_Load(object sender, EventArgs e)
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
        private void ChromiumWebBrowser1_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            PlayYouTubeVideo();
        }
        private void PlayYouTubeVideo()
        {
            string yt = "xrDR5ozJ0YQ";
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&playlist={0}&controls=0&vq=hd1080&rel=0&mute=1", yt);
            chromiumWebBrowser1.Load(url);
        }
    }
}
