using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Form.AdditionalForm;
using Paint.Tools;

namespace Paint.exact
{
    public class PipetteTool : DrawTool
    {
        public PipetteTool()
        {
            type = Tools.Tools.Pipette;
        }

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e)
        {
            
        }

        public override void OnMouseDown(Canvas canvas, MouseEventArgs e)
        {
            
        }

        public override void OnMouseUp(Canvas canvas, MouseEventArgs e)
        {
            canvas.currentPoint = e.Location;
            Color pixelColor = canvas.bitmap.GetPixel(canvas.currentPoint.X, canvas.currentPoint.Y);
            canvas.pen.Color = pixelColor;
            FormSelectColor.Get().SelectedColor = pixelColor;
        }

        public override void Paint(Canvas canvas, PaintEventArgs e)
        {
            
        }
    }
}