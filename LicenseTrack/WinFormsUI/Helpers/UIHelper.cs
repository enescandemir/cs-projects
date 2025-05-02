using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsUI.Helpers
{
    public static class UIHelper
    {
        public static void ApplyRoundedCorners(Control control, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
