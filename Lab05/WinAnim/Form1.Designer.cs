namespace WinAnim
{
    partial class Form1
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
            this.btnAW_BLEND = new System.Windows.Forms.Button();
            this.btnHOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnCenter_AW_SLIDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAW_BLEND
            // 
            this.btnAW_BLEND.AutoSize = true;
            this.btnAW_BLEND.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAW_BLEND.Location = new System.Drawing.Point(30, 34);
            this.btnAW_BLEND.Name = "btnAW_BLEND";
            this.btnAW_BLEND.Size = new System.Drawing.Size(75, 23);
            this.btnAW_BLEND.TabIndex = 0;
            this.btnAW_BLEND.Text = "Appearance";
            this.btnAW_BLEND.UseVisualStyleBackColor = true;
            this.btnAW_BLEND.Click += new System.EventHandler(this.btnAW_BLEND_Click);
            // 
            // btnHOR_AW_SLIDE
            // 
            this.btnHOR_AW_SLIDE.AutoSize = true;
            this.btnHOR_AW_SLIDE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHOR_AW_SLIDE.Location = new System.Drawing.Point(30, 97);
            this.btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            this.btnHOR_AW_SLIDE.Size = new System.Drawing.Size(124, 23);
            this.btnHOR_AW_SLIDE.TabIndex = 1;
            this.btnHOR_AW_SLIDE.Text = "HorizSlide appearance";
            this.btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnHOR_AW_SLIDE.Click += new System.EventHandler(this.btnHOR_AW_SLIDE_Click);
            // 
            // btnCenter_AW_SLIDE
            // 
            this.btnCenter_AW_SLIDE.AutoSize = true;
            this.btnCenter_AW_SLIDE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCenter_AW_SLIDE.Location = new System.Drawing.Point(30, 163);
            this.btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            this.btnCenter_AW_SLIDE.Size = new System.Drawing.Size(133, 23);
            this.btnCenter_AW_SLIDE.TabIndex = 2;
            this.btnCenter_AW_SLIDE.Text = "CentralSlide appearance";
            this.btnCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnCenter_AW_SLIDE.Click += new System.EventHandler(this.btnCenter_AW_SLIDE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 232);
            this.Controls.Add(this.btnCenter_AW_SLIDE);
            this.Controls.Add(this.btnHOR_AW_SLIDE);
            this.Controls.Add(this.btnAW_BLEND);
            this.Name = "Form1";
            this.Text = "Animation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAW_BLEND;
        private System.Windows.Forms.Button btnHOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCenter_AW_SLIDE;
    }
}

