using static System.Net.Mime.MediaTypeNames;

namespace RegistrationForm2
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
                    Size = new System.Drawing.Size(28, 25),
                    Name = "label4",
                    AutoSize = true,
                    Text = "PIN2"
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

                textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Except digits");

                errorProvider1.SetError(textBox1, "Must be letter");
            } 
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Except letters");
            //}
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Except letters");
            }
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Except letters");
                }
            }
        }
    }
}
