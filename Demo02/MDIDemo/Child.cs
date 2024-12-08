using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
            this.Text = "Child" + num;
            num++;
        }

        private void Child_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Child activated");
        }
        private static int num = 0;
    }
}
