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
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.historyControl = new System.Windows.Forms.Control();
            darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.SuspendLayout();
            // 
            // scaleButton
            // 
            this.scaleButton.FlatAppearance.BorderSize = 0;
            // 
            // skipButton
            // 
            this.skipButton.FlatAppearance.BorderSize = 0;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
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
            this.historyControlScrollBar.Location = new System.Drawing.Point(149, 26);
            this.historyControlScrollBar.Name = "historyControlScrollBar";
            this.historyControlScrollBar.Size = new System.Drawing.Size(16, 127);
            this.historyControlScrollBar.TabIndex = 3;
            this.historyControlScrollBar.Text = "darkScrollBar1";
            // 
            // darkLabel1
            // 
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
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
            // undoButton
            // 
            this.undoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.undoButton.BackgroundImage = global::Paint.Properties.Resources.undo;
            this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.ForeColor = System.Drawing.Color.White;
            this.undoButton.Location = new System.Drawing.Point(48, 154);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(28, 28);
            this.undoButton.TabIndex = 7;
            this.undoButton.UseVisualStyleBackColor = true;
            // 
            // redoButton
            // 
            this.redoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.redoButton.BackgroundImage = global::Paint.Properties.Resources.redo;
            this.redoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Location = new System.Drawing.Point(86, 154);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(28, 28);
            this.redoButton.TabIndex = 8;
            this.redoButton.UseVisualStyleBackColor = true;
            // 
            // historyControl
            // 
            this.historyControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.historyControl.Location = new System.Drawing.Point(2, 31);
            this.historyControl.Name = "historyControl";
            this.historyControl.Size = new System.Drawing.Size(147, 121);
            this.historyControl.TabIndex = 9;
            // 
            // FormDrawHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(160, 180);
            this.Controls.Add(this.historyControl);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.darkSeparator2);
            this.Controls.Add(darkSeparator1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.historyControlScrollBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDrawHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormDrawHistory_Load);
            this.Controls.SetChildIndex(this.closeButton, 0);
            this.Controls.SetChildIndex(this.skipButton, 0);
            this.Controls.SetChildIndex(this.scaleButton, 0);
            this.Controls.SetChildIndex(this.historyControlScrollBar, 0);
            this.Controls.SetChildIndex(this.darkLabel1, 0);
            this.Controls.SetChildIndex(darkSeparator1, 0);
            this.Controls.SetChildIndex(this.darkSeparator2, 0);
            this.Controls.SetChildIndex(this.undoButton, 0);
            this.Controls.SetChildIndex(this.redoButton, 0);
            this.Controls.SetChildIndex(this.historyControl, 0);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Control historyControl;

        private System.Windows.Forms.Button undoButton;

        private System.Windows.Forms.Button redoButton;

        private DarkUI.Controls.DarkSeparator darkSeparator2;

        private DarkUI.Controls.DarkScrollBar historyControlScrollBar;

        private DarkUI.Controls.DarkLabel darkLabel1;

        #endregion
    }
}