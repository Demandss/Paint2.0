using System;
using System.Collections.Generic;
using System.Drawing;
using DarkUI.Controls;
using Paint.Form.Pattern;

namespace Paint.Form.AdditionalForm
{
    public partial class FormDrawHistory : FormPattern
    {
        #region Field Region
        
        public Stack<Bitmap> history { get; } = new Stack<Bitmap>();
        public Stack<Bitmap> historyUnded { get; } = new Stack<Bitmap>();

        public int buttonID = 0;
        
        public int buttonUndetID;
        
        private static FormDrawHistory INSTANCE;
        
        #endregion
        
        #region Contructor Region
        
        public FormDrawHistory()
        {
            InitializeComponent();
            UpdateComponentsRenderLevel();
            
            INSTANCE = this;
        }
        
        #endregion
        
        #region Metods Region

        public static FormDrawHistory Get()
        {
            return INSTANCE;
        }

        public void SaveInHistory(Bitmap bitmap, String text)
        {
            history.Push(new Bitmap(bitmap));
            
            foreach (DarkLabel data in historyControl.Controls )
            {
                if (data.ForeColor == Color.Gray)
                {
                    historyControl.Controls.Remove(data);
                }
            }

            DarkLabel label = new DarkLabel();

            DarkLabel topLabel = historyControl.Controls.Count > 1 && buttonID < historyControl.Controls.Count  ? (DarkLabel) historyControl.Controls[buttonID] : null;
            
            label.Text = text;
            label.Size = new Size(140,20);
            if (topLabel != null)
            {
                buttonID++;
                label.Location = new Point(0,topLabel.Location.Y + 20);
            }
            else
            {
                label.Location = new Point(0,0);
            }
            
            historyControl.Controls.Add(label);

            buttonUndetID = historyControl.Controls.Count - 1;
        }

        public Bitmap Undo()
        {
            if (history.Count < 1) return null;

            if (historyControl.Controls.Count > 1 &&
                (buttonUndetID > 1 && buttonUndetID < historyControl.Controls.Count))
            {
                DarkLabel text = (DarkLabel) historyControl.Controls[buttonUndetID];
                text.ForeColor = Color.Gray;
                buttonUndetID--;
            }

            historyUnded.Push(history.Peek());
            return history.Pop();
        }

        public Bitmap Redo()
        {
            if (historyUnded.Count < 1) return null;
            
            if (historyControl.Controls.Count > 1 &&
                (buttonUndetID > 1 && buttonUndetID < historyControl.Controls.Count))
            {
                DarkLabel text = (DarkLabel) historyControl.Controls[buttonUndetID];
                text.ForeColor = Color.Gainsboro;
                buttonUndetID++;
            }
            
            history.Push(historyUnded.Peek());
            return historyUnded.Pop();
        }

        #endregion

        #region Events Handler Region

        private void FormDrawHistory_Load(object sender, EventArgs e)
        {
            this.closeButton.Location = new Point(140, 6);
            this.scaleButton.Hide();
            this.skipButton.Hide();
        }
        
        private void historyControlScrollBar_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            this.historyControl.VerticalScroll.Value = e.Value;
        }
        
        private void undoButton_Click(object sender, EventArgs e)
        {
            FormMain.get().canvas.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            FormMain.get().canvas.Redo();
        }

        #endregion
    }
}