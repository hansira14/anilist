using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public class CustomProgressBar : ProgressBar
{
    private Color progressColor = Color.Red;
    private Color barColor = Color.LightGray;

    public Color ProgressColor
    {
        get { return progressColor; }
        set { progressColor = value; Invalidate(); }
    }

    public Color BarColor
    {
        get { return barColor; }
        set { barColor = value; Invalidate(); }
    }

    public CustomProgressBar()
    {
        SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = ClientRectangle;
        Graphics graphics = e.Graphics;

        // Draw the bar with the desired color
        using (SolidBrush brush = new SolidBrush(barColor))
        {
            graphics.FillRectangle(brush, rect);
        }

        // Calculate the width of the progress based on the Value and Maximum properties
        int progressWidth = (int)((Value / (double)Maximum) * rect.Width);

        // Draw the progress portion with the desired color
        using (SolidBrush brush = new SolidBrush(progressColor))
        {
            graphics.FillRectangle(brush, 0, 0, progressWidth, rect.Height);
        }
    }
}

