using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec04Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myControl1_DoubleClick(object sender, EventArgs e)
        {
            myControl1.Value++;
        }

        private void myControl1_Click(object sender, EventArgs e)
        {
            myControl1.lstShapes.Add(new Coords(myControl1.lstShapes[myControl1.lstShapes.Count - 1].x - 4,
                myControl1.lstShapes[myControl1.lstShapes.Count - 1].y - 4,
                myControl1.lstShapes[myControl1.lstShapes.Count - 1].radius - 6));
            myControl1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lbltxtEmail.txtEmail);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(betterlblLabel.Text);
        }
    }
}
