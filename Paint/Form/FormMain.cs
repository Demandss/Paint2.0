using System;
using System.Drawing;
using System.Windows.Forms;
using Paint.CustomUI;
using Paint.Form.AdditionalForm;
using Paint.Form.Pattern;
using Paint.Tools;

namespace Paint.Form
{
    public partial class FormMain : FormPattern
    {
        #region Field Region
        public Canvas canvas;
        
        private readonly FormDrawHistory _fDrawHistory = new FormDrawHistory();
        private readonly FormSelectColor _fSelectColor = new FormSelectColor();
        private readonly FormTools _fTools = new FormTools();
        
        private static FormMain INSTANCE;

        #endregion
        
        #region Constructor Region
        
        public FormMain()
        {
            InitializeComponent();
            UpdateComponentsRenderLevel();
            canvas = new Canvas(pictureBox1);
            INSTANCE = this;
        }
        
        #endregion

        #region Custom Metods

        public static FormMain get()
        {
            return INSTANCE;
        }
        
        public void SetTool(DrawTool _tool)
        {
            canvas.tool = _tool;
            if (canvas.tool == null)
            {
                toolStripComboBox1.SelectedIndex = -1;
                return;
            }
            toolStripComboBox1.SelectedIndex = (int) canvas.tool.type;
        }

        #endregion
        
        #region Event Handler Region
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.closeButton.Click += (s, a) => Application.Exit();
            _fDrawHistory.Show();
            _fSelectColor.Show();
            _fTools.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitMessageResult = MessageBox.Show(
                "Вы уверены что хотите закрыть приложение, не сохранив изображение",
                "Внимание",
                MessageBoxButtons.YesNo);
            if (exitMessageResult == DialogResult.No)
            {
                e.Cancel = true;
                Show();
            }
        }
        
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitMessageResult = MessageBox.Show(
                "Вы уверены что хотите пересоздать полотно, не сохранив предыдущее ?",
                "Внимание",
                MessageBoxButtons.YesNo);
            if (exitMessageResult == DialogResult.No)
            {
                this.Show();
                return;
            }
            canvas.Clear();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.SaveFile(saveFileDialog1);
        }
        
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.OpenFile(openFileDialog1);
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (журналToolStripMenuItem.Checked)
            {
                _fDrawHistory.Hide();
                журналToolStripMenuItem.CheckState = CheckState.Unchecked;
                return;
            }
            _fDrawHistory.Show();
            журналToolStripMenuItem.CheckState = CheckState.Checked;
        }
        
        private void инструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (инструментыToolStripMenuItem.Checked)
            {
                _fTools.Hide();
                инструментыToolStripMenuItem.CheckState = CheckState.Unchecked;
                return;
            }
            _fTools.Show();
            инструментыToolStripMenuItem.CheckState = CheckState.Checked;
        }
        
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (цветToolStripMenuItem.Checked)
            {
                _fSelectColor.Hide();
                цветToolStripMenuItem.CheckState = CheckState.Unchecked;
                return;
            }
            _fSelectColor.Show();
            цветToolStripMenuItem.CheckState = CheckState.Checked;
        }
        
        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Undo();
        }

        private void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Redo();
        }
        
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }
        
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.CutSelection();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.CopySelection();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.PasteSelection();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                canvas.Resize(pictureBox1);
        }
        
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            canvas.tool = ToolFactory.GetTool((Tools.Tools)toolStripComboBox1.SelectedIndex);
        }
        
        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            canvas.pen.Width = Int64.Parse(toolStripComboBox3.Text);
        }
        
        private void toolStripComboBox3_TextUpdate(object sender, EventArgs e)
        {
            canvas.pen.Width = Int64.Parse(toolStripComboBox3.Text);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            inPicturCoodinats.Text = $"{e.Location.X}.{e.Location.Y}";
            pictureSize.Text = $"{pictureBox1.Image.Size.Height}x{pictureBox1.Image.Size.Width}";
            canvas.OnMouseMove(e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            canvas.OnMouseUp(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            canvas.OnMouseDown(e);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            canvas.OnPaint(e);
        }
        
        #endregion
    }
}