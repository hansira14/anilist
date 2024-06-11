using System;
using System.Windows.Forms;

namespace AniList
{
    public partial class video : UserControl
    {
        public video()
        {
            InitializeComponent();
            //webView21.CreationProperties = new CoreWebView2CreationProperties()
            //{
            //    BrowserExecutableFolder = @"C:\Program Files (x86)\Microsoft\Edge\Application\92.0.902.55",
            //    UserDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\MyApp"
            //};

        }

        private void video_Load(object sender, EventArgs e)
        {
            string videoId = "LHtdKWJdif4"; // replace with the YouTube video ID you want to play
            string url = string.Format("https://www.youtube.com/embed/{0}?autoplay=1&loop=1&playlist={0}&controls=0&vq=hd1080&rel=0", videoId);
            //string url = "https://123anime.to/watch/shingeki-no-kyojin-the-final-season-episode-1";
            this.Controls.Add(chromiumWebBrowser1);
            chromiumWebBrowser1.Load(url);
            //await webView21.EnsureCoreWebView2Async(); //i async ni nga method
            //webView21.CoreWebView2.Navigate("https://mplayer.me/player.php?id=MTAzMzg3 ");
        }

    }
}
