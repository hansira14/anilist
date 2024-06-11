using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

public class flowlayout2 : FlowLayoutPanel
{
    private const int WM_NCPAINT = 0x85;
    private const int WM_SETREDRAW = 0xB;

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_NCPAINT)
        {
            // Remove the scrollbars by disabling redrawing of the control
            SendMessage(Handle, WM_SETREDRAW, 0, 0);

            // Call the base WndProc method to paint the non-client area
            base.WndProc(ref m);

            // Re-enable redrawing and update the control's styles
            SendMessage(Handle, WM_SETREDRAW, 1, 0);
            UpdateStyles();
        }
        else
        {
            base.WndProc(ref m);
        }
    }

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
}
