using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncEratS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GoButt()
        {
            int maxValue = 0;
            StringBuilder resultText = new StringBuilder();

            if (int.TryParse(textBoxMaxValue.Text, out maxValue))
            {
                bool[] isPrime = new bool[maxValue + 1];
                
                for (int i = 2; i <= maxValue; i++)
                {
                    isPrime[i] = true;
                }

                for (int p = 2; p * p <= maxValue; p++)
                {
                    if (isPrime[p])
                    {
                        for (int i = p * p; i <= maxValue; i += p)
                        {
                            isPrime[i] = false;
                        }
                    }
                }

                for (int i = 2; i <= maxValue; i++)
                {
                    if (isPrime[i])
                    {
                        resultText.AppendFormat("{0} ", i);
                    }
                }
            }
            else
            {
                resultText.Append("Error: Input integer");
            }

            return resultText.ToString();
        }

        private async void buttonCalc_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "Calculating...";

            string result = await Task.Run(() => GoButt());

            richTextBoxResult.Text = result;
        }

    }
}
