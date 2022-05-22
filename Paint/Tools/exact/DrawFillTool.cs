using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Tools;

namespace Paint.exact
{
    public class FillTool : DrawTool
    {
        public FillTool()
        {
            type = Tools.Tools.Fill;
        }

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e) { }
        public override void OnMouseDown(Canvas canvas, MouseEventArgs e) { }

        public override void OnMouseUp(Canvas canvas, MouseEventArgs e)
        {
            MapFill mf = new MapFill();
            mf.Fill(canvas.graphics, canvas.currentPoint, canvas.pen.Color, ref canvas.bitmap);
            canvas.graphics = Graphics.FromImage(canvas.bitmap);
            canvas.pictureBox.Image = canvas.bitmap;
            canvas.pictureBox.Refresh();
        }

        public override void Paint(Canvas canvas, PaintEventArgs e) { }
    }
}