using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Paint.Utils;

namespace Paint.CustomUI
{
    public class Canvas : PictureBox
    {
        #region Field Region

        public IDrawTool DrawTool { get; set; }
        
        public Pen pen = new Pen(Color.Black,10);
        
        public List<Canvas> layers { get; set; } = new List<Canvas>();
        public Stack<Bitmap> history { get; } = new Stack<Bitmap>();
        public Point currentPoint { get; set; } 
        public Point prevPoint { get; set; }
        public bool isMousePressed { get; set; }

        public Bitmap bitmap = default(Bitmap);
        public Graphics graphics { get; } = default(Graphics);
        
        #endregion

        #region Constructor Region

        public Canvas()
        {
            bitmap = new Bitmap(this.Width, this.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            
            this.Image = bitmap;
            graphics.Clear(Color.White);
            
            saveDrawInHistory();
        }

        #endregion

        #region CustomMetods

        public void saveDrawInHistory()
        {
            history.Push(new Bitmap(bitmap));
        }

        public void drawEllipse(Rectangle rectangle)
        {
            graphics.DrawEllipse(pen, rectangle);
        }

        #endregion

        #region Event Handler Region

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //if (tool == null) return;
            
            if (isMousePressed)
            {
                //tool.OnMouseMove(this, e);
                Refresh();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            //if (tool == null) return;
            
            prevPoint = e.Location;
            currentPoint = e.Location;
            isMousePressed = true;
            //tool.OnMouseDown(this,e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            //if (tool == null) return;
            
            isMousePressed = false;
            prevPoint = e.Location;
            //tool.OnMouseUp(this,e);
            drawEllipse(MathUtils.GetMRectangle(prevPoint, currentPoint));
            saveDrawInHistory();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            //if (tool == null) return;
            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            drawEllipse(MathUtils.GetMRectangle(prevPoint, currentPoint));
            //tool.Paint(this,e);
        }

        #endregion
    }
}