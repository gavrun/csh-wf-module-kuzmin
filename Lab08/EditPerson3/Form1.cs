using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson3
{
    public partial class Form1 : Form
    {
        List<Person> pers = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            //Form2 editForm = new Form2();
            Form2 editForm = new Form2(p);

            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            pers.Add(p);

            listView1.VirtualListSize = pers.Count;
            listView1.Invalidate();

            //ListViewItem newItem = listView1.Items.Add(editForm.FirstName);

            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //    return;
            if (listView1.SelectedIndices.Count == 0)
                return;

            Person p = pers[listView1.SelectedIndices[0]];

            Form2 editForm = new Form2(p);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listView1.Invalidate();
            }

            //ListViewItem item = listView1.SelectedItems[0];

            //Form2 editForm = new Form2();

            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;

            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Person item in pers)
            {
                sb.Append("Employee: \n" + item.ToString());
            }

            richTextBox1.Text = sb.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            using (FileStream fStream = new FileStream("person.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, pers);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            try
            {
                using (FileStream fStream = new FileStream("person.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<Person>)binFormat.Deserialize(fStream));
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}
