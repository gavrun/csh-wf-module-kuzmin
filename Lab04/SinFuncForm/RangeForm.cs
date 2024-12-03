using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinFuncForm
{
    public partial class RangeForm : Form
    {
        public double LeftBoundary { get; private set; }
        public double RightBoundary { get; private set; }


        public RangeForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LeftBoundary = double.Parse(textBoxLeftBoundary.Text);
                RightBoundary = double.Parse(textBoxRightBoundary.Text);

                if (LeftBoundary >= RightBoundary)
                {
                    MessageBox.Show("Left boundary must be less than the right boundary");
                    return;
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid numeric values");
                throw;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
