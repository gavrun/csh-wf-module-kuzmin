using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLang2
{
    public partial class Form1 : Form
    {
        private ResourceManager resM;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            InitializeComponent();

            comboBox1.Items.Add("en-US");
            comboBox1.Items.Add("ru-RU");

            comboBox1.SelectedIndex = 0; // default en-US
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chosenCulture = comboBox1.SelectedItem.ToString();

            Thread.CurrentThread.CurrentCulture = new CultureInfo(chosenCulture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(chosenCulture);

            // update app ui
            ApplyCulture();

            // close and render new culture
            this.Hide();
            Form1 newForm = new Form1();
            newForm.ShowDialog();
            this.Close();
        }

        private void ApplyCulture()
        {
            //resM = new ResourceManager("WinLang2.Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            resM = new ResourceManager("WinLang2.Form1", System.Reflection.Assembly.GetExecutingAssembly());

            MessageBox.Show(resM.GetString("TextString"));
        }
    }
}
