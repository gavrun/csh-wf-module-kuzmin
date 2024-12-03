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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSetInterval_Click(object sender, EventArgs e)
        {
            RangeForm rangeForm = new RangeForm();

            if (rangeForm.ShowDialog() == DialogResult.OK)
            {
                double left = rangeForm.LeftBoundary;
                double right = rangeForm.RightBoundary;

                CalculateSinValue(left, right);

                labelInterval.Text = $"Left: {left}, Right: {right}";

            }
        }

        private void CalculateSinValue(double left, double right)
        {
            //throw new NotImplementedException();
            richTextBoxResults.Clear();

            double step = 0.1;

            for (double i = left; i <= right; i += step)
            {
                double j = Math.Sin(i);

                richTextBoxResults.AppendText($"{i:F2}: {j:F2}\n");
            }
        }
    }
}
