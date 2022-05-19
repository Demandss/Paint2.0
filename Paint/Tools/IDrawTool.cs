
using System.Windows.Forms;
using Paint.CustomUI;

namespace Paint
{
    public interface IDrawTool
    {
        void OnMouseMove(Canvas canvas, MouseEventArgs e);
        void OnMouseDown(Canvas canvas, MouseEventArgs e);
        void OnMouseUp(Canvas canvas, MouseEventArgs e);
        void Paint(Canvas canvas, PaintEventArgs e);
    }
}