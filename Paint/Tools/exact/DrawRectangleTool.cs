using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Tools;
using Paint.Utils;

namespace Paint.exact
{
    public class RectangleTool : DrawTool
    {
        public RectangleTool()
        {
            type = Tools.Tools.Rectangle;
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
            canvas.graphics.DrawRectangle(canvas.pen, MathUtils.GetMRectangle(canvas.prevPoint, canvas.currentPoint));
        }

        public override void Paint(Canvas canvas, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(canvas.pen, MathUtils.GetMRectangle(canvas.prevPoint, canvas.currentPoint));
        }
    }
}