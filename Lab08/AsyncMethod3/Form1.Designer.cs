namespace AsyncMethod3
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
            this.components = new System.ComponentModel.Container();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonDiff = new System.Windows.Forms.Button();
            this.labelResultDiff = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(22, 47);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(44, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Value A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(199, 51);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(44, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Value B";
            // 
            // textBoxA
            // 
            this.helpProvider1.SetHelpString(this.textBoxA, "For inputting integer A");
            this.textBoxA.Location = new System.Drawing.Point(72, 44);
            this.textBoxA.Name = "textBoxA";
            this.helpProvider1.SetShowHelp(this.textBoxA, true);
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxA, "For inputting integer A");
            // 
            // textBoxB
            // 
            this.helpProvider1.SetHelpString(this.textBoxB, "For inputting integer B");
            this.textBoxB.Location = new System.Drawing.Point(249, 48);
            this.textBoxB.Name = "textBoxB";
            this.helpProvider1.SetShowHelp(this.textBoxB, true);
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxB, "For inputting integer B");
            // 
            // buttonRun
            // 
            this.helpProvider1.SetHelpString(this.buttonRun, "Press to Run");
            this.buttonRun.Location = new System.Drawing.Point(25, 87);
            this.buttonRun.Name = "buttonRun";
            this.helpProvider1.SetShowHelp(this.buttonRun, true);
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.toolTip1.SetToolTip(this.buttonRun, "Press to Run");
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonWork
            // 
            this.helpProvider1.SetHelpString(this.buttonWork, "Press to Work");
            this.buttonWork.Location = new System.Drawing.Point(274, 116);
            this.buttonWork.Name = "buttonWork";
            this.helpProvider1.SetShowHelp(this.buttonWork, true);
            this.buttonWork.Size = new System.Drawing.Size(75, 23);
            this.buttonWork.TabIndex = 5;
            this.buttonWork.Text = "Work";
            this.toolTip1.SetToolTip(this.buttonWork, "Press to Work");
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(127, 92);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 6;
            // 
            // buttonDiff
            // 
            this.buttonDiff.Location = new System.Drawing.Point(25, 116);
            this.buttonDiff.Name = "buttonDiff";
            this.buttonDiff.Size = new System.Drawing.Size(75, 23);
            this.buttonDiff.TabIndex = 7;
            this.buttonDiff.Text = "Diff";
            this.buttonDiff.UseVisualStyleBackColor = true;
            this.buttonDiff.Click += new System.EventHandler(this.buttonDiff_Click);
            // 
            // labelResultDiff
            // 
            this.labelResultDiff.AutoSize = true;
            this.labelResultDiff.Location = new System.Drawing.Point(127, 121);
            this.labelResultDiff.Name = "labelResultDiff";
            this.labelResultDiff.Size = new System.Drawing.Size(0, 13);
            this.labelResultDiff.TabIndex = 8;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\itmo\\04\\csh-wf-module-kuzmin\\Lab08\\AsyncMethod3\\HelpFile.txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "&Help";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem3.Text = "&Veiw Help";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 161);
            this.Controls.Add(this.labelResultDiff);
            this.Controls.Add(this.buttonDiff);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button buttonDiff;
        private System.Windows.Forms.Label labelResultDiff;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

