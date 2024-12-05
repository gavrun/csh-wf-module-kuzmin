﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrafSinLine
{
    public partial class Form1 : Form
    {
        public double a, b;

        public string DataA
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string DataB
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point p1, p2;
            int w = (int)panel1.Width;
            int h = (int)panel1.Height;
            int y = h / 2;

            for (int x = 0; x < w; x++)
            {
                p1 = new Point(x, y);

                t = Operation.SummSin(x, a, b);

                y = (int)(t * h / 5);
                y = y + h / 2;

                p2 = new Point(x, y);

                // here
                Graphics dc = e.Graphics;
                Pen p = new Pen(Color.Red, 1);

                dc.DrawLine(p, p1, p2);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(DataA);
                b = double.Parse(DataB);
                panel1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }

        public Form1()
        {
            InitializeComponent();

            a = 0.1;
            b = 0.04;
        }
    }
}