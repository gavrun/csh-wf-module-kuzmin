using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp25
{
    public partial class nForm2 : Form
    {
        private bool nclose = false;

        public nForm2()
        {
            InitializeComponent();
        }

        //overriding base class method
        public new void Close() 
        {
            nclose = true;
            base.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void nForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (checkBoxClose.Checked)
            //    return;

            if (nclose) return;

            e.Cancel = true;
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
