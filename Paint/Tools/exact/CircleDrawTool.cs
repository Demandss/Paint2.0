using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Utils;

namespace Paint.Tools.exact
{
    public class CircleDrawTool : DrawTool
    {
        public CircleDrawTool()
        {
            type = Tools.Circle;
        }

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e)
        {
            canvas.currentPoint = e.Location;
        }

        public override void OnMouseDown(Canvas canvas, MouseEventArgs e)
        {
        }

        public override void OnMouseUp(Canvas canvas, MouseEventArgs e)
        {
            canvas.drawEllipse(MathUtils.GetMRectangle(canvas.prevPoint, canvas.currentPoint));
        }

        public override void Paint(Canvas canvas, PaintEventArgs e)
        {
            canvas.drawEllipse(MathUtils.GetMRectangle(canvas.prevPoint, canvas.currentPoint));
        }
    }
}