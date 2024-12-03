namespace SinFuncForm
{
    partial class MainForm
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
            this.labelDescr = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.buttonSetInterval = new System.Windows.Forms.Button();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelDescr
            // 
            this.labelDescr.AutoSize = true;
            this.labelDescr.Location = new System.Drawing.Point(30, 30);
            this.labelDescr.Name = "labelDescr";
            this.labelDescr.Size = new System.Drawing.Size(151, 13);
            this.labelDescr.TabIndex = 0;
            this.labelDescr.Text = "Values of sin(x) on the interval:";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(33, 82);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(47, 13);
            this.labelInterval.TabIndex = 1;
            this.labelInterval.Text = "(interval)";
            // 
            // buttonSetInterval
            // 
            this.buttonSetInterval.AutoSize = true;
            this.buttonSetInterval.Location = new System.Drawing.Point(276, 72);
            this.buttonSetInterval.Name = "buttonSetInterval";
            this.buttonSetInterval.Size = new System.Drawing.Size(75, 23);
            this.buttonSetInterval.TabIndex = 2;
            this.buttonSetInterval.Text = "Set Interval";
            this.buttonSetInterval.UseVisualStyleBackColor = true;
            this.buttonSetInterval.Click += new System.EventHandler(this.buttonSetInterval_Click);
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(36, 132);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(315, 278);
            this.richTextBoxResults.TabIndex = 3;
            this.richTextBoxResults.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.buttonSetInterval);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Calculate sin(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescr;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Button buttonSetInterval;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
    }
}

