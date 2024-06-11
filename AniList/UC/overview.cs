using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniList.UC
{
    public partial class overview : UserControl
    {
        public overview(Anime x)
        {
            InitializeComponent();
            synopsiss.Text = x.Synopsis;
            review.Text = x.Review;
            if (x.RelatedAnime == null) return;
            string[] lines = x.RelatedAnime.Split('\n');
            related.Font = new Font("Segoe UI", 12); // Set the default font for the control
            foreach (string line in lines)
            {
                int colonIndex = line.IndexOf(':');
                if (colonIndex > -1)
                {
                    string beforeColon = line.Substring(0, colonIndex + 1);
                    string afterColon = line.Substring(colonIndex + 1);
                    related.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    related.AppendText(beforeColon);
                    related.SelectionFont = new Font("Segoe UI", 12);
                    related.AppendText(afterColon + "\n");
                }
                else
                {
                    related.AppendText(line + "\n");
                }
            }
        }
    }
}
