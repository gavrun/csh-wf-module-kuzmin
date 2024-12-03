namespace SinFuncForm
{
    partial class RangeForm
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
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textBoxLeftBoundary = new System.Windows.Forms.TextBox();
            this.textBoxRightBoundary = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(36, 36);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(100, 13);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Interval boundaries:";
            // 
            // textBoxLeftBoundary
            // 
            this.textBoxLeftBoundary.Location = new System.Drawing.Point(39, 77);
            this.textBoxLeftBoundary.Name = "textBoxLeftBoundary";
            this.textBoxLeftBoundary.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeftBoundary.TabIndex = 1;
            // 
            // textBoxRightBoundary
            // 
            this.textBoxRightBoundary.Location = new System.Drawing.Point(170, 77);
            this.textBoxRightBoundary.Name = "textBoxRightBoundary";
            this.textBoxRightBoundary.Size = new System.Drawing.Size(100, 20);
            this.textBoxRightBoundary.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(58, 136);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(170, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // RangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 236);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxRightBoundary);
            this.Controls.Add(this.textBoxLeftBoundary);
            this.Controls.Add(this.labelPrompt);
            this.Name = "RangeForm";
            this.Text = "RangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxLeftBoundary;
        private System.Windows.Forms.TextBox textBoxRightBoundary;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}