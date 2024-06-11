using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AniList.UC
{
    public partial class statsanime : UserControl
    {
        public statsanime(Anime z)
        {
            InitializeComponent();
            if(z.R1>0) chart1.Series[0].Points.AddXY("1    -", z.R1);
            if (z.R2 > 0) chart1.Series[0].Points.AddXY("2    -", z.R2);
            if (z.R3 > 0) chart1.Series[0].Points.AddXY("3    -", z.R3);
            if (z.R4 > 0) chart1.Series[0].Points.AddXY("4    -", z.R4);
            if (z.R5 > 0) chart1.Series[0].Points.AddXY("5    -", z.R5);
            if (z.R6 > 0) chart1.Series[0].Points.AddXY("6    -", z.R6);
            if (z.R7 > 0) chart1.Series[0].Points.AddXY("7    -", z.R7);
            if (z.R8 > 0) chart1.Series[0].Points.AddXY("8    -", z.R8);
            if (z.R9 > 0) chart1.Series[0].Points.AddXY("9    -", z.R9);
            if (z.R10 > 0) chart1.Series[0].Points.AddXY("10    -", z.R10);
            chart2.Series[0].Points.Add(new DataPoint() { AxisLabel = "Completed", YValues = new double[] { z.Completedcount }, Label = $"Completed ({z.Completedcount.ToString("#,#")})" });
            chart2.Series[0].Points.Add(new DataPoint() { AxisLabel = "Watching", YValues = new double[] { z.Watchingcount }, Label = $"Watching ({z.Watchingcount.ToString("#,#")})" });
            chart2.Series[0].Points.Add(new DataPoint() { AxisLabel = "Plans to watch", YValues = new double[] { z.Planscount }, Label = $"Plans to watch ({z.Planscount.ToString("#,#")})" });
            chart2.Series[0].Points.Add(new DataPoint() { AxisLabel = "Paused", YValues = new double[] { z.Pausedcount }, Label = $"Paused ({z.Pausedcount.ToString("#,#")})" });
            chart2.Series[0].Points.Add(new DataPoint() { AxisLabel = "Dropped", YValues = new double[] { z.Droppedcount }, Label = $"Dropped ({z.Droppedcount.ToString("#,#")})" });

            chart2.Series[0].LegendText = "#LABEL";

        }
    }
}
