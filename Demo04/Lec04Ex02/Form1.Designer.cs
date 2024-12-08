namespace Lec04Ex02
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.betterlblLabel = new Lec04Ex02.BetterTextBox();
            this.lbltxtEmail = new Lec04Ex02.LabelTextbox();
            this.myControl1 = new Lec04Ex02.MyControl();
            this.ctlClock1 = new Lec04Ex02CL.ctlClock();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(803, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 483);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // betterlblLabel
            // 
            this.betterlblLabel.Location = new System.Drawing.Point(198, 489);
            this.betterlblLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betterlblLabel.Name = "betterlblLabel";
            this.betterlblLabel.Size = new System.Drawing.Size(150, 31);
            this.betterlblLabel.TabIndex = 3;
            this.betterlblLabel.Text = "My Label";
            // 
            // lbltxtEmail
            // 
            this.lbltxtEmail.Location = new System.Drawing.Point(420, 26);
            this.lbltxtEmail.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lbltxtEmail.Name = "lbltxtEmail";
            this.lbltxtEmail.Size = new System.Drawing.Size(468, 142);
            this.lbltxtEmail.TabIndex = 1;
            // 
            // myControl1
            // 
            this.myControl1.Location = new System.Drawing.Point(124, 85);
            this.myControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(225, 231);
            this.myControl1.TabIndex = 0;
            this.myControl1.Value = 10;
            this.myControl1.Click += new System.EventHandler(this.myControl1_Click);
            this.myControl1.DoubleClick += new System.EventHandler(this.myControl1_DoubleClick);
            // 
            // ctlClock1
            // 
            this.ctlClock1.ClockBackColor = System.Drawing.Color.Green;
            this.ctlClock1.ClockForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ctlClock1.Location = new System.Drawing.Point(477, 196);
            this.ctlClock1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlClock1.Name = "ctlClock1";
            this.ctlClock1.Size = new System.Drawing.Size(188, 83);
            this.ctlClock1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ctlClock1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.betterlblLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltxtEmail);
            this.Controls.Add(this.myControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl myControl1;
        private LabelTextbox lbltxtEmail;
        private System.Windows.Forms.Button button1;
        private BetterTextBox betterlblLabel;
        private System.Windows.Forms.Button button2;
        private Lec04Ex02CL.ctlClock ctlClock1;
    }
}

