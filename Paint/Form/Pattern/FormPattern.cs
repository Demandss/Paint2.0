using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Paint.Form.Pattern
{
    public partial class FormPattern : System.Windows.Forms.Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormPattern()
        {
            InitializeComponent();
            InitializeFormControlComponents();
        }

        void InitializeFormControlComponents()
        {
            //Removing the default window control panel
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Add drag the form logic
            this.MouseDown += (sender, args) =>
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            };
            //Adding close button logic
            this.closeButton.Click += (sender, args) => this.Hide();
            this.closeButton.MouseHover += (sender, args) => closeButton.Image = Properties.Resources.closeButtonHover;
            this.closeButton.MouseLeave += (sender, args) => closeButton.Image = Properties.Resources.closeButton;
            //Adding skip button logic
            this.skipButton.Click += (sender, e) => this.WindowState = FormWindowState.Minimized;
            this.skipButton.MouseHover += (sender, args) => skipButton.Image = Properties.Resources.skipButtonHover;
            this.skipButton.MouseLeave += (sender, args) => skipButton.Image = Properties.Resources.skipButton;
            //Adding scale button logic
            this.scaleButton.Click += (sender, e) =>
            {
                if (this.WindowState != FormWindowState.Maximized)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                } else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
            };
            this.scaleButton.MouseHover += (sender, args) => scaleButton.Image = Properties.Resources.scaleButtonHover;
            this.scaleButton.MouseLeave += (sender, args) => scaleButton.Image = Properties.Resources.scaleButton;
        }

        public void UpdateComponentsRenderLevel()
        {
            closeButton.BringToFront();
            skipButton.BringToFront();
            scaleButton.BringToFront();
        }
    }
}