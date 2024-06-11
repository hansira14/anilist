using AniList.Forms;
using AniList.UC;
using System.Windows.Forms;

namespace AniList
{
    public static class add
    {
        public static void tolist(Form parentForm, string type, Anime ani, anime anime = null)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();

            addanime popupForm = new addanime(ani, type, anime);
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
            };
        }
        public static void tolist(Form parentForm, string type, Anime ani, animePic anime)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();

            addanime popupForm = new addanime(ani, type, anime);
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
            };
        }
        public static void tolist(Form parentForm, string type, Anime ani, animepage ap)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();

            addanime popupForm = new addanime(ani, type);
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
                ap.LoadData();
            };
        }
        public static void tolist(Form parentForm, string type, Anime ani, animeTop anime)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();

            addanime popupForm = new addanime(ani, type, anime);
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
            };
        }
        public static void tolist(Form parentForm, string type, Anime ani, animeRecom anime)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();

            addanime popupForm = new addanime(ani, type, anime);
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
            };
        }
        public static void tolist(Form parentForm, string type, Anime ani, UC.tableMylist t)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();

            addanime popupForm = new addanime(ani, type);
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
                if(t!= null) t.RefreshList();
            };
        }
        public static void tolist(Form parentForm, newanime nw=null)
        {
            TransparentPanel transparentPanel = new TransparentPanel();
            transparentPanel.Enabled = true;
            transparentPanel.Dock = DockStyle.Fill;
            parentForm.Controls.Add(transparentPanel);
            transparentPanel.BringToFront();
            Form popupForm = null;
            if (nw ==null) popupForm= new accountsettings();
            else popupForm = nw;
            popupForm.TopMost = true;
            //popupForm.Opacity = 0.5;
            popupForm.Show();
            popupForm.TopMost = false;

            popupForm.FormClosed += (s, args) =>
            {
                parentForm.Controls.Remove(transparentPanel);
            };
        }
    }
}
