using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class Form2 : Form
    {
        public string FirstName
        {
            get { return textBoxFirstName.Text; }
            set { textBoxFirstName.Text = value; }
        }
        public string LastName
        {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }
        public int Age
        {
            get { return (int)numericUpDownAge.Value; }
            set { numericUpDownAge.Value = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
