using System.ComponentModel;

namespace Paint.Form.AdditionalForm
{
    partial class FormTools
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
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.emptyTool = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.selectionButton = new System.Windows.Forms.Button();
            this.pipetteButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
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
            darkSeparator1.Location = new System.Drawing.Point(-23, 25);
            darkSeparator1.Name = "darkSeparator1";
            darkSeparator1.Size = new System.Drawing.Size(183, 2);
            darkSeparator1.TabIndex = 7;
            // 
            // darkLabel1
            // 
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(-23, -1);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(164, 23);
            this.darkLabel1.TabIndex = 6;
            this.darkLabel1.Text = "Инструменты";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emptyTool
            // 
            this.emptyTool.BackgroundImage = global::Paint.Properties.Resources.cursor;
            this.emptyTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emptyTool.FlatAppearance.BorderSize = 0;
            this.emptyTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyTool.Location = new System.Drawing.Point(38, 33);
            this.emptyTool.Name = "emptyTool";
            this.emptyTool.Size = new System.Drawing.Size(28, 28);
            this.emptyTool.TabIndex = 18;
            this.emptyTool.UseVisualStyleBackColor = true;
            this.emptyTool.Click += new System.EventHandler(this.emptyTool_Click);
            // 
            // textButton
            // 
            this.textButton.BackgroundImage = global::Paint.Properties.Resources.text;
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textButton.FlatAppearance.BorderSize = 0;
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textButton.Location = new System.Drawing.Point(72, 33);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(28, 27);
            this.textButton.TabIndex = 19;
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // penButton
            // 
            this.penButton.BackgroundImage = global::Paint.Properties.Resources.pen;
            this.penButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.penButton.FlatAppearance.BorderSize = 0;
            this.penButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penButton.Location = new System.Drawing.Point(38, 66);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(28, 27);
            this.penButton.TabIndex = 20;
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.BackgroundImage = global::Paint.Properties.Resources.fill;
            this.fillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillButton.FlatAppearance.BorderSize = 0;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Location = new System.Drawing.Point(72, 66);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(28, 27);
            this.fillButton.TabIndex = 21;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // selectionButton
            // 
            this.selectionButton.BackgroundImage = global::Paint.Properties.Resources.selection;
            this.selectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectionButton.FlatAppearance.BorderSize = 0;
            this.selectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionButton.Location = new System.Drawing.Point(38, 99);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(28, 26);
            this.selectionButton.TabIndex = 22;
            this.selectionButton.UseVisualStyleBackColor = true;
            this.selectionButton.Click += new System.EventHandler(this.selectionButton_Click);
            // 
            // pipetteButton
            // 
            this.pipetteButton.BackgroundImage = global::Paint.Properties.Resources.pipette;
            this.pipetteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipetteButton.FlatAppearance.BorderSize = 0;
            this.pipetteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipetteButton.Location = new System.Drawing.Point(72, 98);
            this.pipetteButton.Name = "pipetteButton";
            this.pipetteButton.Size = new System.Drawing.Size(28, 27);
            this.pipetteButton.TabIndex = 23;
            this.pipetteButton.UseVisualStyleBackColor = true;
            this.pipetteButton.Click += new System.EventHandler(this.pipetteButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraserButton.FlatAppearance.BorderSize = 0;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Location = new System.Drawing.Point(38, 131);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(28, 26);
            this.eraserButton.TabIndex = 24;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackgroundImage = global::Paint.Properties.Resources.line;
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Location = new System.Drawing.Point(72, 131);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(28, 28);
            this.lineButton.TabIndex = 25;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.BackgroundImage = global::Paint.Properties.Resources.circle;
            this.circleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButton.FlatAppearance.BorderSize = 0;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Location = new System.Drawing.Point(38, 163);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(28, 27);
            this.circleButton.TabIndex = 26;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.rectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Location = new System.Drawing.Point(72, 162);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(28, 29);
            this.rectangleButton.TabIndex = 27;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 204);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.eraserButton);
            this.Controls.Add(this.pipetteButton);
            this.Controls.Add(this.selectionButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.penButton);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.emptyTool);
            this.Controls.Add(darkSeparator1);
            this.Controls.Add(this.darkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTools";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTools_Load);
            this.Controls.SetChildIndex(this.closeButton, 0);
            this.Controls.SetChildIndex(this.skipButton, 0);
            this.Controls.SetChildIndex(this.scaleButton, 0);
            this.Controls.SetChildIndex(this.darkLabel1, 0);
            this.Controls.SetChildIndex(darkSeparator1, 0);
            this.Controls.SetChildIndex(this.emptyTool, 0);
            this.Controls.SetChildIndex(this.textButton, 0);
            this.Controls.SetChildIndex(this.penButton, 0);
            this.Controls.SetChildIndex(this.fillButton, 0);
            this.Controls.SetChildIndex(this.selectionButton, 0);
            this.Controls.SetChildIndex(this.pipetteButton, 0);
            this.Controls.SetChildIndex(this.eraserButton, 0);
            this.Controls.SetChildIndex(this.lineButton, 0);
            this.Controls.SetChildIndex(this.circleButton, 0);
            this.Controls.SetChildIndex(this.rectangleButton, 0);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button circleButton;

        private System.Windows.Forms.Button lineButton;

        private System.Windows.Forms.Button pipetteButton;

        private System.Windows.Forms.Button fillButton;

        private System.Windows.Forms.Button penButton;

        private System.Windows.Forms.Button emptyTool;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button selectionButton;
        private System.Windows.Forms.Button textButton;
        private DarkUI.Controls.DarkLabel darkLabel1;

        #endregion
    }
}