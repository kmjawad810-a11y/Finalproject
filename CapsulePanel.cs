using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CapsulePanel : Panel
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int radius = this.Height / 2; // capsule effect
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 90, 180);
        path.AddArc(this.Width - radius, 0, radius, radius, 270, 180);
        path.CloseAllFigures();

        this.Region = new Region(path); // applies capsule shape
    }
}