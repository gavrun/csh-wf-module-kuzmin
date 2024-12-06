using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncEratS
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
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;

                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Error: Input integer");
            }

            return resultText.ToString();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "Calculating..";

            Thread secondaryThread = new Thread(() =>
            {
                string result = GoButt();

                this.Invoke(new Action( () =>
                                        {
                                            richTextBoxResult.Text = result;
                                        })
                                    );
            }
            );

            secondaryThread.IsBackground = true; 
            secondaryThread.Start();
        }

    }
}
