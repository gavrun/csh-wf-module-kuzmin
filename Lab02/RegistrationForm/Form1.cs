namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label label4 = new Label
                {
                    Location = new System.Drawing.Point(41, 102),
                    Size = new System.Drawing.Size(26, 25),
                    Name = "label4",
                    Text = "SEX"
                };
                groupBox1.Controls.Add(label4);

                TextBox textBox3 = new TextBox
                {
                    Location = new System.Drawing.Point(87, 102),
                    Size = new System.Drawing.Size(100, 25),
                    Name = "textBox3",
                    Text = ""
                };   
                groupBox1.Controls.Add(textBox3);

            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;

                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }
    }
}
