using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec03Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();

            // Добавление эллипса, вписанного в прямоугольную форму заданной ширины и высоты
            myPath.AddEllipse(0, 0, this.Width, this.Height);

            // Создание нового класса Region из GraphicsPath
            Region myRegion = new Region(myPath);

            // Присвоение свойству Region формы нового региона
            this.Region = myRegion;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            //int Size = 9;
            /*
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
             */
            this.Size = new System.Drawing.Size(screenWidth / 4, screenHeight / 4);
        }
    }
}
