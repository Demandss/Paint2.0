using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Tools;

namespace Paint.exact
{
    public class LineTool : DrawTool
    {
        public LineTool()
        {
            type = Tools.Tools.Line;
        }

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e)
        {
            canvas.currentPoint = e.Location;
        }

        public override void OnMouseDown(Canvas canvas, MouseEventArgs e) { }

        public override void OnMouseUp(Canvas canvas, MouseEventArgs e)
        {
            canvas.graphics.DrawLine(canvas.pen, canvas.prevPoint, canvas.currentPoint);
        }

        public override void Paint(Canvas canvas, PaintEventArgs e)
        {
            e.Graphics.DrawLine(canvas.pen, canvas.prevPoint, canvas.currentPoint);
        }
    }
}