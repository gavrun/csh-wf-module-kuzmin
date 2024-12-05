using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncMethod
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumma(int a, int b);

        delegate void PrintLabel(string str);

        private PrintLabel PrintDlegateFunc;

        public Form1()
        {
            InitializeComponent();

            PrintDlegateFunc = new PrintLabel(PrintFunc);
        }


        private int Summa(int a, int b)
        {
            System.Threading.Thread.Sleep(7000);

            return a + b;
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumma summaDelegate = (AsyncSumma)ar.AsyncState;

            str = String.Format("Sum of values equals {0}", summaDelegate.EndInvoke(ar));

            MessageBox.Show(str, "Operation result");

            labelResult.Invoke(PrintDlegateFunc, new object[] { str });
        }

        void PrintFunc(string str)
        {
            labelResult.Text = str;
        }



        private void buttonRun_Click(object sender, EventArgs e)
        {
            int a, b;

            //if (!int.TryParse(textBoxA.Text, out a) || !int.TryParse(textBoxB.Text, out b))
            //{
            //    MessageBox.Show("Only integers");
            //    return;
            //}

            try
            {
                a = Int32.Parse(textBoxA.Text);
                b = Int32.Parse(textBoxB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                //throw;
                return;
            }

            AsyncSumma asyncSummaDelegate = new AsyncSumma(Summa);

            AsyncCallback cb = new AsyncCallback(CallBackMethod);

            asyncSummaDelegate.BeginInvoke(a, b, cb, asyncSummaDelegate);
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            string str = "Task completed";

            MessageBox.Show(str, "Task");
        }
    }
}
