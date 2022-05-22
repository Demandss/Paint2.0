using System.ComponentModel;

namespace Paint.Form.AdditionalForm
{
    partial class FormDrawHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DarkUI.Controls.DarkSeparator darkSeparator1;
            this.historyControlScrollBar = new DarkUI.Controls.DarkScrollBar();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkSeparator2 = new DarkUI.Controls.DarkSeparator();
            this.redoButton = new System.Windows.Forms.Button();
            this.historyControl = new System.Windows.Forms.ContainerControl();
            this.undoButton = new System.Windows.Forms.Button();
            darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.SuspendLayout();
            // 
            // darkSeparator1
            // 
            darkSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            darkSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            darkSeparator1.ForeColor = System.Drawing.Color.Black;
            darkSeparator1.Location = new System.Drawing.Point(1, 26);
            darkSeparator1.Name = "darkSeparator1";
            darkSeparator1.Size = new System.Drawing.Size(164, 2);
            darkSeparator1.TabIndex = 5;
            // 
            // historyControlScrollBar
            // 
            this.historyControlScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.historyControlScrollBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.historyControlScrollBar.Location = new System.Drawing.Point(147, 26);
            this.historyControlScrollBar.Name = "historyControlScrollBar";
            this.historyControlScrollBar.Size = new System.Drawing.Size(16, 127);
            this.historyControlScrollBar.TabIndex = 3;
            this.historyControlScrollBar.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.historyControlScrollBar_ValueChanged);
            // 
            // darkLabel1
            // 
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.darkLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkLabel1.Location = new System.Drawing.Point(1, 0);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(164, 23);
            this.darkLabel1.TabIndex = 4;
            this.darkLabel1.Text = "Журнал";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkSeparator2
            // 
            this.darkSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSeparator2.Location = new System.Drawing.Point(1, 152);
            this.darkSeparator2.Name = "darkSeparator2";
            this.darkSeparator2.Size = new System.Drawing.Size(164, 2);
            this.darkSeparator2.TabIndex = 6;
            this.darkSeparator2.Text = "darkSeparator2";
            // 
            // redoButton
            // 
            this.redoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.redoButton.BackgroundImage = global::Paint.Properties.Resources.redo;
            this.redoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Location = new System.Drawing.Point(82, 154);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(33, 33);
            this.redoButton.TabIndex = 10;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // historyControl
            // 
            this.historyControl.Location = new System.Drawing.Point(1, 34);
            this.historyControl.Name = "historyControl";
            this.historyControl.Size = new System.Drawing.Size(150, 114);
            this.historyControl.TabIndex = 9;
            this.historyControl.Text = "containerControl1";
            // 
            // undoButton
            // 
            this.undoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.undoButton.BackgroundImage = global::Paint.Properties.Resources.undo;
            this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Location = new System.Drawing.Point(43, 154);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(33, 33);
            this.undoButton.TabIndex = 11;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // FormDrawHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(160, 180);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.historyControl);
            this.Controls.Add(this.darkSeparator2);
            this.Controls.Add(darkSeparator1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.historyControlScrollBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDrawHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormDrawHistory_Load);
            this.Controls.SetChildIndex(this.historyControlScrollBar, 0);
            this.Controls.SetChildIndex(this.darkLabel1, 0);
            this.Controls.SetChildIndex(darkSeparator1, 0);
            this.Controls.SetChildIndex(this.darkSeparator2, 0);
            this.Controls.SetChildIndex(this.historyControl, 0);
            this.Controls.SetChildIndex(this.redoButton, 0);
            this.Controls.SetChildIndex(this.undoButton, 0);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContainerControl historyControl;

        private System.Windows.Forms.Button undoButton;

        private System.Windows.Forms.Button redoButton;

        private DarkUI.Controls.DarkSeparator darkSeparator2;

        private DarkUI.Controls.DarkScrollBar historyControlScrollBar;

        private DarkUI.Controls.DarkLabel darkLabel1;

        #endregion
    }
}