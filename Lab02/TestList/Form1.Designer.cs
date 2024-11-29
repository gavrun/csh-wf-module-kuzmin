namespace TestList
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
            groupBox1 = new GroupBox();
            memberList = new CheckedListBox();
            peopleList = new ComboBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSort = new Button();
            buttonImport = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(memberList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of participants";
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.Location = new Point(6, 22);
            memberList.Name = "memberList";
            memberList.Size = new Size(187, 202);
            memberList.TabIndex = 0;
            // 
            // peopleList
            // 
            peopleList.FormattingEnabled = true;
            //peopleList.Items.AddRange(new object[] { "John Smith", "Emily Brown", "Oliver Johnson", "Sophie Williams", "James Taylor" });
            peopleList.Location = new Point(247, 12);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(121, 23);
            peopleList.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(293, 111);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(293, 149);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(293, 222);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(75, 23);
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(293, 51);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(75, 23);
            buttonImport.TabIndex = 5;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 257);
            Controls.Add(buttonImport);
            Controls.Add(buttonSort);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(peopleList);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Working with lists";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox memberList;
        private ComboBox peopleList;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSort;
        private Button buttonImport;
    }
}
