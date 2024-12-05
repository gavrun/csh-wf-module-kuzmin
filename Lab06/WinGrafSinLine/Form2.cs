using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrafSinLine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;

            try
            {
                form1.a = double.Parse(textBox1.Text);
                form1.b = double.Parse(textBox2.Text);
                form1.DataA = textBox1.Text;
                form1.DataB = textBox2.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:\n" + ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
            form1.Refresh();
        }
    }
}
