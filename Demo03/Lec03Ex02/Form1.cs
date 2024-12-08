using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lec03Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddHandler_Click(object sender, EventArgs e)
        {
            this.txtValue.TextChanged += txtValue_TextChanged;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            lblValue.Text = txtValue.Text;
        }

        private void btnRemoveHandler_Click(object sender, EventArgs e)
        {
            this.txtValue.TextChanged -= txtValue_TextChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Selected index: " + listBox1.Items[listBox1.SelectedIndex]);
            toolStripStatusLabel1.Text = "Selected index: " + lstMakers.Items[lstMakers.SelectedIndex];
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("listBox1 obtained focus");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstMakers.Items.Add(txtValue.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstMakers.Items.Clear();
        }

        private void lstMakers_DoubleClick(object sender, EventArgs e)
        {
            lstMakers.Items.Remove(lstMakers.Items[lstMakers.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult res = openFileDialog.ShowDialog(this);
            Console.WriteLine(openFileDialog.FileName);
            Console.WriteLine(res.ToString());
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog(this);
        }

        private void txtAddLabel_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "Label " + num;
            lbl.Location = new Point(10, 400 + num * 10);
            this.Controls.Add(lbl);
            num++;
            labels.Add(lbl);
        }

        private static int num = 0;
        private ArrayList labels = new ArrayList();

        private void txtRemoveLabel_Click(object sender, EventArgs e)
        {
            this.Controls.Remove((Label)labels[0]);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!double.TryParse(txtPrice.Text, out a))
            {
                lblPriceError.Text = "Поле должно содержать цифры";
                txtPrice.Focus();
                return;
            }
            b = a * 0.13;
            lblPriceError.Text = "";
            Console.WriteLine(b.ToString());
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(txtPrice.Text, out a))
            {
                txtPrice.Text = "";
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                errorProvider1.SetError(textBox1, "Must contain at least 5 characters");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }
    }
}
