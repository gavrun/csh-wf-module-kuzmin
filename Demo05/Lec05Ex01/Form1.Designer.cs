namespace Lec05Ex01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMove = new Button();
            btnSelectAudio = new Button();
            txtFileName = new TextBox();
            SuspendLayout();
            // 
            // btnMove
            // 
            btnMove.Location = new Point(46, 42);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(75, 23);
            btnMove.TabIndex = 0;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnSelectAudio
            // 
            btnSelectAudio.Location = new Point(574, 55);
            btnSelectAudio.Name = "btnSelectAudio";
            btnSelectAudio.Size = new Size(144, 23);
            btnSelectAudio.TabIndex = 1;
            btnSelectAudio.Text = "Select audio file";
            btnSelectAudio.UseVisualStyleBackColor = true;
            btnSelectAudio.Click += btnSelectAudio_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(53, 111);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(706, 23);
            txtFileName.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 230);
            Controls.Add(txtFileName);
            Controls.Add(btnSelectAudio);
            Controls.Add(btnMove);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMove;
        private Button btnSelectAudio;
        private TextBox txtFileName;
    }
}
