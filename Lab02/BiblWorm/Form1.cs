using BiblWorm.Bibl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;
using System.Text;

namespace BiblWorm
{
    internal partial class Form1 : Form
    {
        public string title
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string publishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int pages
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int invNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public int periodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public bool available
        {
            get { return (bool)checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool returnTime
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool sortInvNumber
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }

        List<Item> items = new List<Item>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //debug
            Book bookDebug = new Book("War and Peace", "Tolstoy L.N.", "Science and Life", 1234, 2000, 1, false);
            items.Add(bookDebug);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book(title, author, publishHouse, pages, year, invNumber, available);
            //if (returnTime)
            //    book.ReturnSrok();
            //book.PriceBook(periodUse);
            items.Add(book);

            author = "A";
            title = "B";
            publishHouse = "C";
            pages = invNumber = periodUse = 1;
            year = 2000;
            available = returnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sortInvNumber)
                items.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in items)
            {
                sb.Append(item.DisplayInfo() + "\n");
            }

            richTextBox1.Text = sb.ToString();
        }

    }
}
