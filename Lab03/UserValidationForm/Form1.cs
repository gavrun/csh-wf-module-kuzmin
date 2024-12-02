using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserValidationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!validTextBoxName.ValidateName())
            {
                MessageBox.Show("ERROR");
                return;
            }
            if (!validTextBoxEmail.ValidateEmail())
            {
                MessageBox.Show("ERROR");
                return;
            }

            User user = new User
            {
                Name = validTextBoxName.InputText,
                Email = validTextBoxEmail.InputText
            };

            validTextBoxName.InputText = string.Empty;
            validTextBoxEmail.InputText = string.Empty;

            DisplayUserData(user);
        }

        private void DisplayUserData(User user)
        {
            richTextBox1.Text = $"Name: {user.Name}\nEmail: {user.Email}";
        }

    }
}
