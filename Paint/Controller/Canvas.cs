using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Paint.exact;
using Paint.Form;
using Paint.Form.AdditionalForm;
using Paint.Tools;

namespace Paint.CustomUI
{
    public class Canvas
    {
        #region Field Region

        public DrawTool tool { get; set; }
        public Pen pen = new Pen(Color.Black);
        public List<PictureBox> layers { get; set; } = new List<PictureBox>();
        public Point currentPoint { get; set; }
        public Point prevPoint { get; set; }
        public bool isMousePressed { get; set; }
        public Bitmap bitmap = default(Bitmap);
        public Graphics graphics { get; set; } = default(Graphics);
        public PictureBox pictureBox { get; private set; } = default(PictureBox);
        
        #endregion

        #region Constructor Region

        public Canvas(PictureBox box)
        {
            pictureBox = box;
            bitmap = new Bitmap(800, 600);

            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            
            graphics.Clear(Color.White);
            pictureBox.Image = bitmap;
            
            SaveDrawInHistory("Изначальный");
        }

        #endregion

        #region Metods

        public void SaveDrawInHistory(string text)
        {
            FormDrawHistory.Get().SaveInHistory(bitmap,text);
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
            pictureBox.Refresh();
        }

        public void OpenFile(OpenFileDialog dialog)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveDrawInHistory("Открытие файла");
                bitmap = Bitmap.FromFile(dialog.FileName) as Bitmap;
                pictureBox.Image = bitmap;
                graphics = Graphics.FromImage(bitmap);
            }
        }

        public void SaveFile(SaveFileDialog dialog)
        {
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            dialog.Title = "Save an Image File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)dialog.OpenFile();
                switch (dialog.FilterIndex)
                {
                    case 1:
                        bitmap.Save(fs,
                            ImageFormat.Jpeg);
                        break;

                    case 2:
                        bitmap.Save(fs,
                            ImageFormat.Bmp);
                        break;

                    case 3:
                        bitmap.Save(fs,
                            ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }

        public void Undo()
        {
            Bitmap _bitmap = FormDrawHistory.Get().Undo();
            if (_bitmap == null) return;
            bitmap = _bitmap;
            graphics = Graphics.FromImage(bitmap);
            pictureBox.Image = bitmap;
            pictureBox.Refresh();
        }

        public void Redo()
        {
            Bitmap _bitmap = FormDrawHistory.Get().Redo();
            if (_bitmap == null) return;
            bitmap = _bitmap; 
            graphics = Graphics.FromImage(bitmap);
            pictureBox.Image = bitmap;
            pictureBox.Refresh();
        }

        public void Resize(PictureBox box)
        {
            pictureBox = box;
            bitmap = new Bitmap(bitmap, pictureBox.Width, pictureBox.Height);
            
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            
            pictureBox.Image = bitmap;
        }

        public void CopySelection()
        {
            ((SelectionTool)tool).copy(this); 
        }
        
        public void CutSelection()
        {
            ((SelectionTool)tool).cut(this); 
        }
        
        public void PasteSelection()
        {
            ((SelectionTool)tool).paste(this); 
        }

        #endregion

        #region Event Handler Region

        public void OnMouseMove(MouseEventArgs e)
        {
            if (tool == null) return;

            if (isMousePressed)
            {
                tool.OnMouseMove(this, e);
                pictureBox.Refresh();
            }
        }

        public void OnMouseDown(MouseEventArgs e)
        {
            if (tool == null) return;
            
            pen.Color = FormSelectColor.Get().SelectedColor;
            
            prevPoint = e.Location;
            currentPoint = e.Location;
            isMousePressed = true;
            
            tool.OnMouseDown(this,e);
            
            if (tool.type != Tools.Tools.Pipette && tool.type != Tools.Tools.Selection)
            {
                SaveDrawInHistory("Рисунок");
            }
        }

        public void OnMouseUp(MouseEventArgs e)
        {
            if (tool == null) return;
            
            isMousePressed = false;
            
            tool.OnMouseUp(this,e);
            
            prevPoint = e.Location;
        }
        
        public void OnPaint(PaintEventArgs e)
        {
            if (tool == null) return;
            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            
            tool.Paint(this,e);
        }

        #endregion
    }
}