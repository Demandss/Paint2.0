using System;
using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Tools;

namespace Paint.exact
{
    public class EraserTool : DrawTool
    {
        public EraserTool()
        {
            type = Tools.Tools.Eraser;
        }

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e)
        {
            canvas.prevPoint = canvas.currentPoint;
            canvas.currentPoint = e.Location;
            int pw2 = (int)Math.Max(1, canvas.pen.Width / 2);
            using (var brush = new SolidBrush(Color.White))
            {
                canvas.graphics.FillRectangle(brush, canvas.currentPoint.X - pw2, canvas.currentPoint.Y - pw2, canvas.pen.Width, canvas.pen.Width);
            }
        }

        public override void OnMouseDown(Canvas canvas, MouseEventArgs e) { }
        public override void OnMouseUp(Canvas canvas, MouseEventArgs e) { }
        public override void Paint(Canvas canvas, PaintEventArgs e) { }
    }
}