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

namespace UserValidationForm
{
    public partial class ValidTextBox : UserControl
    {
        public ValidTextBox()
        {
            InitializeComponent();
        }
        public string InputText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(InputText))
            {
                errorProvider1.SetError(textBox1, "Cannot be empty");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }
        public bool ValidateName() 
        {
            if (!ValidateInput())
            {
                return false;
            }
            if (Regex.IsMatch(InputText, @"\d"))
            {
                errorProvider1.SetError(textBox1, "Must be letters");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }
        public bool ValidateEmail()
        {
            if (!ValidateInput())
            {
                return false;
            }
            if (!(Regex.IsMatch(InputText, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")))
            {
                errorProvider1.SetError(textBox1, "Must be email");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }
    }
}
