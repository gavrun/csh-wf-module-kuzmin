using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson2
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

        Person p;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Person p)
        {
            InitializeComponent();

            this.p = p;

            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Age = p.Age;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName;
            p.LastName = this.LastName;
            p.Age = this.Age;

            MessageBox.Show("Employee: " + p.ToString());
        }
    }
}
