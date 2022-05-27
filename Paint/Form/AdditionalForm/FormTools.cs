using System;
using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.exact;
using Paint.Form.Pattern;
using Paint.Tools.exact;

namespace Paint.Form.AdditionalForm
{
    public partial class FormTools : FormPattern
    {
        #region Constructor Region
        
        public FormTools()
        {
            InitializeComponent();
            
            UpdateComponentsRenderLevel();
        }
        
        #endregion

        #region Events Handler Region

        private void FormTools_Load(object sender, EventArgs e)
        {
            this.closeButton.Location = new Point(115, 6);
            this.scaleButton.Hide();
            this.skipButton.Hide();
        }
        
        private void circleButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new CircleTool());
        }

        private void emptyTool_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(null);
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new TextTool());
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new PenTool());
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new FillTool());
        }

        private void selectionButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new SelectionTool());
        }

        private void pipetteButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new PipetteTool());
        }
        
        private void eraserButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new EraserTool());
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new LineTool());
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            FormMain.get().SetTool(new RectangleTool());
        }
        
        #endregion
    }
}