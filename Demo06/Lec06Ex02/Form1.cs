using System.Diagnostics;

namespace Lec06Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                Debug.WriteLine(i.ToString());
            }

        }
    }
}
