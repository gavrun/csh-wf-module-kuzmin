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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Child NewMdiChild = new Child();
            // Set the Parent Form of the Child window.
            NewMdiChild.MdiParent = this;
            // Display the new form.
            NewMdiChild.Show();

        }

        private void casToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.ActiveMdiChild.Text);
        }
    }
}
