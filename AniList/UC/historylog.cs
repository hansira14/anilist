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
    public partial class historylog : UserControl
    {
        public historylog(string user=null)
        {
            InitializeComponent();
            List<Userlogs>  temp = retrieve.GetUserlogs(null, user);
            foreach (Userlogs log in temp)
            {
                log ll = new log(log);
                here.Controls.Add(ll);
            }
        }
    }
}
