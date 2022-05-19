using System;
using System.Windows.Forms;
using Paint.Form.AdditionalForm;
using Paint.Form.Pattern;
using Paint.Tools.exact;

namespace Paint.Form
{
    public partial class FormMain : FormPattern
    {
        private readonly FormDrawHistory _fDrawHistory = new FormDrawHistory();
        
        public FormMain()
        {
            InitializeComponent();
            UpdateComponentsRenderLevel();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.closeButton.Click += (s, a) => Application.Exit();
            _fDrawHistory.Show();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fDrawHistory.Show();
        }
        
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            canvas.DrawTool = new CircleDrawTool();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            inPicturCoodinats.Text = e.Location.ToString();
        }
    }
}