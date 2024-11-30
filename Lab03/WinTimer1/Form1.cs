namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (userControl11.TimeEnabled)
            {
                userControl11.TimeEnabled = false;
            }
            else
            {
                userControl11.TimeEnabled = true;
            }
        }

       
    }
}
