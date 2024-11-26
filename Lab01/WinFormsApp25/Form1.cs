using System.Windows.Forms;

namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        nForm2 myF2;

        public Form1()
        {
            InitializeComponent();
            myF2 = new nForm2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form2 myF2 = new Form2();
            //myF2.Show();

            //nForm2 myF2 = new nForm2();
            //myF2.StartPosition = FormStartPosition.Manual;
            //myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //myF2.Show();

            try
            {
                myF2.Show();
                myF2.Activate();
            }
            catch (ObjectDisposedException ex)
            {

                myF2 = new nForm2();
                myF2.Text = "Recreated form";
                myF2.Show();
                myF2.Activate();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
