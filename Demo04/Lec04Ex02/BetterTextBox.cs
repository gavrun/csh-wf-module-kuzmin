using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec04Ex02
{
    internal class BetterTextBox : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);
            //this.Text = "djhaksjdhaskjd";
        }
    }

}
