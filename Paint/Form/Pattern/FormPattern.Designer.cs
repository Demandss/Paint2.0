namespace Paint.Form.Pattern
{
    partial class FormPattern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.closeButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.scaleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Paint.Properties.Resources.closeButton;
            this.closeButton.Location = new System.Drawing.Point(775, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(13, 13);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // skipButton
            // 
            this.skipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skipButton.FlatAppearance.BorderSize = 0;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipButton.Image = global::Paint.Properties.Resources.skipButton;
            this.skipButton.Location = new System.Drawing.Point(737, 6);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(13, 13);
            this.skipButton.TabIndex = 1;
            this.skipButton.UseVisualStyleBackColor = true;
            // 
            // scaleButton
            // 
            this.scaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleButton.FlatAppearance.BorderSize = 0;
            this.scaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scaleButton.Image = global::Paint.Properties.Resources.scaleButton;
            this.scaleButton.Location = new System.Drawing.Point(756, 6);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(13, 13);
            this.scaleButton.TabIndex = 2;
            this.scaleButton.UseVisualStyleBackColor = true;
            // 
            // FormPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scaleButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.closeButton);
            this.Name = "FormPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.ResumeLayout(false);
        }

        protected System.Windows.Forms.Button scaleButton;

        protected System.Windows.Forms.Button skipButton;

        protected System.Windows.Forms.Button closeButton;

        #endregion
    }
}