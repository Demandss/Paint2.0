using System;
using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Tools;

namespace Paint.exact
{
    public class SelectionTool : DrawTool
    {
        #region Field Region

        private Point firstSelectionPoint, lastSelectionPoint;
        private Bitmap selectedImage;
        private Graphics selectedGraphics;
        private Rectangle selectedRectangle;

        #endregion

        #region Contructor Region

        public SelectionTool()
        {
            type = Tools.Tools.Selection;
        }

        #endregion
        
        #region Events Handler Region

        public override void OnMouseMove(Canvas canvas, MouseEventArgs e)
        {
            lastSelectionPoint = e.Location;

            selectedGraphics.DrawImage(canvas.bitmap, 0, 0);

            using (Pen pen = new Pen(Color.Red))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                Rectangle rectangle = new Rectangle(
                    Math.Min(firstSelectionPoint.X, lastSelectionPoint.X),
                    Math.Min(firstSelectionPoint.Y, lastSelectionPoint.Y),
                    Math.Abs(firstSelectionPoint.X - lastSelectionPoint.X),
                    Math.Abs(firstSelectionPoint.Y - lastSelectionPoint.Y));
                selectedGraphics.DrawRectangle(pen, rectangle);
            }
            canvas.pictureBox.Refresh();
        }

        public override void OnMouseDown(Canvas canvas, MouseEventArgs e)
        {
            firstSelectionPoint = e.Location;
                
            selectedImage = new Bitmap(canvas.bitmap);
            selectedGraphics = Graphics.FromImage(selectedImage);
            canvas.pictureBox.Image = selectedImage;
        }

        public override void OnMouseUp(Canvas canvas, MouseEventArgs e)
        {
            selectedImage = null;
            selectedGraphics = null;
            canvas.pictureBox.Image = canvas.bitmap;
            canvas.pictureBox.Refresh();

            Rectangle rectangle = new Rectangle(
                Math.Min(firstSelectionPoint.X, lastSelectionPoint.X),
                Math.Min(firstSelectionPoint.Y, lastSelectionPoint.Y),
                Math.Abs(firstSelectionPoint.X - lastSelectionPoint.X),
                Math.Abs(firstSelectionPoint.Y - lastSelectionPoint.Y));
            if ((rectangle.Width > 0) && (rectangle.Height > 0))
            {
                selectedRectangle = rectangle;
            }
        }

        public override void Paint(Canvas canvas, PaintEventArgs e) { }

        #endregion
        

        #region Metods Region
        
        private void CopyToClipboard(Canvas canvas,Rectangle src_rect)
        {
            Bitmap bm = new Bitmap(src_rect.Width, src_rect.Height);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                Rectangle dest_rect =
                    new Rectangle(0, 0, src_rect.Width, src_rect.Height);
                gr.DrawImage(canvas.bitmap, dest_rect, src_rect,
                    GraphicsUnit.Pixel);
            }
            Clipboard.SetImage(bm);
        }
        
        public void copy(Canvas canvas)
        {
            if ((selectedRectangle.Width < 1) && (selectedRectangle.Height < 1))
            {
                MessageBox.Show("Невозможно копировать, выделите область копирования!");
                return;
            }                
            CopyToClipboard(canvas,selectedRectangle);
            selectedRectangle.Width = 0;
            selectedRectangle.Height = 0;
            System.Media.SystemSounds.Beep.Play();
        }

        public void cut(Canvas canvas)
        {
            canvas.SaveDrawInHistory("Вырезка");
            if ((selectedRectangle.Width < 1) && (selectedRectangle.Height < 1))
            {
                MessageBox.Show("Невозможно вырезать, выделите область вырезания!");
                return;
            }  
            
            CopyToClipboard(canvas,selectedRectangle);

            using (Graphics gr = Graphics.FromImage(canvas.bitmap))
            {
                using (SolidBrush br = new SolidBrush(canvas.pictureBox.BackColor))
                {
                    gr.FillRectangle(br, selectedRectangle);
                }
            }

            selectedImage = new Bitmap(canvas.bitmap);
            canvas.pictureBox.Image = selectedImage;

            selectedImage = null;
            selectedGraphics = null;

            System.Media.SystemSounds.Beep.Play();
        }

        public void paste(Canvas canvas)
        {
            canvas.SaveDrawInHistory("Вставка");
            if (!Clipboard.ContainsImage()) return;

            Image clipboard_image = Clipboard.GetImage();

            int cx = selectedRectangle.X +
                     (selectedRectangle.Width - clipboard_image.Width) / 2;
            int cy = selectedRectangle.Y +
                     (selectedRectangle.Height - clipboard_image.Height) / 2;
            Rectangle dest_rect = new Rectangle(
                cx, cy,
                clipboard_image.Width,
                clipboard_image.Height);

            using (Graphics gr = Graphics.FromImage(canvas.bitmap))
            {
                gr.DrawImage(clipboard_image, dest_rect);
            }

            canvas.pictureBox.Image = canvas.bitmap;
            canvas.pictureBox.Refresh();

            selectedImage = null;
            selectedGraphics = null;
        }
        
        #endregion
    }
}