using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class ScrollableTextBox : TextBox
{
    // Importing the SendMessage function from user32.dll
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

    // Constants for the messages we'll be sending to the TextBox control
    private const int WM_VSCROLL = 0x0115;
    private const int SB_LINEUP = 0;
    private const int SB_LINEDOWN = 1;

    public ScrollableTextBox()
    {
        // Set the TextBox to multiline and disable the scrollbars
        this.Multiline = true;
        this.ScrollBars = ScrollBars.None;

        // Attach the MouseWheel event to our custom event handler
        this.MouseWheel += ScrollableTextBox_MouseWheel;
    }

    private void ScrollableTextBox_MouseWheel(object sender, MouseEventArgs e)
    {
        // Determine the direction of the scrolling based on the delta value
        int scrollDirection = e.Delta > 0 ? SB_LINEUP : SB_LINEDOWN;

        // Scroll the TextBox
        for (int i = 0; i < Math.Abs(e.Delta / 120); i++)
        {
            SendMessage(this.Handle, WM_VSCROLL, (IntPtr)scrollDirection, IntPtr.Zero);
        }
    }
}
