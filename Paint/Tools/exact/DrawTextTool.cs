using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Form;
using Paint.Tools;

namespace Paint.exact
{
    public class TextTool : DrawTool
    {
        public TextTool()
        {
            type = Tools.Tools.Text;
        }

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e) { }

        public override void OnMouseDown(Canvas canvas, MouseEventArgs e) { }

        public override void OnMouseUp(Canvas canvas, MouseEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Location = canvas.currentPoint;
            textBox.Size = new Size(50, (int)canvas.pen.Width * 2);
            textBox.Font = new Font("Microsoft Sans Serif", canvas.pen.Width, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Multiline = true;
            textBox.KeyDown += (o, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    canvas.graphics.DrawString(textBox.Text, textBox.Font, new SolidBrush(canvas.pen.Color),
                        new RectangleF(textBox.Location.X, textBox.Location.Y, textBox.Right * (int)canvas.pen.Width * 2, textBox.Height));
                    canvas.pictureBox.Refresh();
                    FormMain.get().Controls.Remove(textBox);
                }
            };
            textBox.Leave += (o, args) =>
            {
                canvas.graphics.DrawString(textBox.Text, textBox.Font, new SolidBrush(canvas.pen.Color),
                    new RectangleF(textBox.Location.X, textBox.Location.Y, textBox.Right * (int)canvas.pen.Width * 2, textBox.Height));
                canvas.pictureBox.Refresh();
                FormMain.get().Controls.Remove(textBox);
            };
            FormMain.get().Controls.Add(textBox);
            textBox.Select();
            textBox.BringToFront();
        }

        public override void Paint(Canvas canvas, PaintEventArgs e)
        {
            
        }
    }
}