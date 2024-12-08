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
    public class Coords
    {
        public Coords(int a, int b, int c ) {
            x = a;
            y = b; 
            radius = c;
        }
        public int x { get; set; }
        public int y { get; set; }
        public int radius { get; set; }
    }
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
            lstShapes.Add(new Coords(1, 1, 50));
        }


        public List<Coords> lstShapes = new List<Coords>();

        private int val;
        public int Value { get { return val; }
            set
            {
                val = value;
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);

            Pen pen = new Pen(Color.Red, 2);

            foreach (Coords coords in lstShapes)
            {
                g.DrawEllipse(pen, coords.x, coords.y, coords.x + 2 * coords.radius, coords.y + 2 * coords.radius);
            }

            string drawString = Value.ToString();
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 5.0F;
            float y = 50.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }
    }
}
