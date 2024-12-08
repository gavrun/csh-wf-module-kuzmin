using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lec04Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Regex validateEmailregex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
            if (!validateEmailregex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Ivalid email enetered");
            }

        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            Regex validateEmailregex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
            lstEmails.Items.Clear();
            foreach (var item in validateEmailregex.Matches(txtText.Text)
                       .Cast<Match>()
                       .Where(m => m.Success)
                       .ToArray())
            {
                //Console.WriteLine(item);
                lstEmails.Items.Add(item);
            }




        }
    }
}
