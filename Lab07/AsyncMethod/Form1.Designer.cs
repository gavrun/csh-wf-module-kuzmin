namespace AsyncMethod
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(21, 21);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(44, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Value A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(198, 25);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(44, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Value B";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(71, 18);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(248, 22);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 3;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(24, 61);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(167, 115);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(75, 23);
            this.buttonWork.TabIndex = 5;
            this.buttonWork.Text = "Work";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(136, 66);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Label labelResult;
    }
}

