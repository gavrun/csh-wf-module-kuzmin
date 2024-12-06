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
            // set max value and create stringbuilder to collect results
            int maxValue = 0;
            StringBuilder resultText = new StringBuilder();

            if (int.TryParse(textBoxMaxValue.Text, out maxValue)) //verify if conversion worked
            {
                // use array to find prime numbers
                bool[] isPrime = new bool[maxValue + 1]; // maxValue + 1 human readable match to a number

                // initially populate with pseudo-prime numbers
                for (int i = 2; i <= maxValue; i++)
                {
                    isPrime[i] = true; // assume that all numbers are prime
                }

                // sieve of eratosthenes
                for (int p = 2; p * p <= maxValue; p++)
                {
                    if (isPrime[p]) // take marked number
                    {
                        // find compound numbers by condition
                        for (int i = p * p; i <= maxValue; i += p) 
                        {
                            isPrime[i] = false; // and unmark it 
                        }
                    }
                }

                //push results from array to string builder
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

        public string GoButtParallel()
        {
            int maxValue = 0;
            int primeCount = 0; // for large values

            StringBuilder resultText = new StringBuilder();

            if (int.TryParse(textBoxMaxValue.Text, out maxValue))
            {
                bool[] isPrime = new bool[maxValue + 1];

                for (int i = 2; i <= maxValue; i++)
                {
                    isPrime[i] = true;
                }

                // use Parallel cycle to process numbers separately
                Parallel.For(
                        2, 
                        (int)Math.Sqrt(maxValue) + 1, // range between 2 and sqrt(max) + 1
                        p =>
                        {
                            if (isPrime[p])
                            {
                                for (int i = p * p; i <= maxValue; i += p)
                                {
                                    isPrime[i] = false;
                                }
                            }
                        }
                        );

                for (int i = 2; i <= maxValue; i++)
                {
                    if (isPrime[i])
                    {
                        primeCount++; // let's count

                        resultText.AppendFormat("{0} ", i);
                    }
                }
            }
            else
            {
                resultText.Append("Error: Input integer");
            }

            //return resultText.ToString();

            if (primeCount < 10000000)
            {
                return $"Found {primeCount} primes.\n\n" + resultText.ToString();
            }
            return $"Found {primeCount} primes.";
        }

        private async void buttonCalc_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "Calculating...";

            //string result = await Task.Run(() => GoButt());
            string result = await Task.Run(() => GoButtParallel());

            richTextBoxResult.Text = result;
        }

    }
}
