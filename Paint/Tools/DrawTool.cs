using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;

namespace Paint.Tools
{
    public abstract class DrawTool : IDrawTool
    {
        public Tools type { get; set; }
        
        public abstract void OnMouseMove(Canvas canvas, MouseEventArgs e);
        public abstract void OnMouseDown(Canvas canvas, MouseEventArgs e);
        public abstract void OnMouseUp(Canvas canvas, MouseEventArgs e);
        public abstract void Paint(Canvas canvas, PaintEventArgs e);
    }
}