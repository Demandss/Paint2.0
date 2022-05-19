using System;
using Paint.Form.Pattern;

namespace Paint.Form.AdditionalForm
{
    public partial class FormDrawHistory : FormPattern
    {
        private static FormDrawHistory INSTANCE;
        
        public FormDrawHistory()
        {
            InitializeComponent();
            UpdateComponentsRenderLevel();

            INSTANCE = this;
        }

        public static FormDrawHistory Get()
        {
            return INSTANCE;
        }

        private void FormDrawHistory_Load(object sender, EventArgs e)
        {
            this.closeButton.Location = new System.Drawing.Point(140, 6);
            this.scaleButton.Hide();
            this.skipButton.Hide();
        }
    }
}