namespace UserValidationForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.validTextBoxEmail = new UserValidationForm.ValidTextBox();
            this.validTextBoxName = new UserValidationForm.ValidTextBox();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(19, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.validTextBoxEmail);
            this.groupBoxUser.Controls.Add(this.validTextBoxName);
            this.groupBoxUser.Controls.Add(this.labelName);
            this.groupBoxUser.Controls.Add(this.labelEmail);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(324, 193);
            this.groupBoxUser.TabIndex = 2;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Validate User";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(342, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(253, 193);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(167, 227);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // validTextBoxEmail
            // 
            this.validTextBoxEmail.InputText = "";
            this.validTextBoxEmail.Location = new System.Drawing.Point(93, 95);
            this.validTextBoxEmail.Name = "validTextBoxEmail";
            this.validTextBoxEmail.Size = new System.Drawing.Size(196, 51);
            this.validTextBoxEmail.TabIndex = 3;
            // 
            // validTextBoxName
            // 
            this.validTextBoxName.InputText = "";
            this.validTextBoxName.Location = new System.Drawing.Point(93, 28);
            this.validTextBoxName.Name = "validTextBoxName";
            this.validTextBoxName.Size = new System.Drawing.Size(196, 51);
            this.validTextBoxName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 268);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private ValidTextBox validTextBoxEmail;
        private ValidTextBox validTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSend;
    }
}

