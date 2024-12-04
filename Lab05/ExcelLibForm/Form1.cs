using System;
using System.Data;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;


namespace ExcelLibForm
{
    public partial class Form1 : Form
    {
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // open Excel file
                    textBox1.Text = openFileDialog1.FileName;
                    workbook = app.Workbooks.Open(openFileDialog1.FileName);
                    //string selectedFile = openFileDialog1.FileName;
                    MessageBox.Show("Selected file: $ {selectedFile}");

                    // get 1st sheet
                    NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);

                    // load all cells
                    ShtRange = NwSheet.UsedRange;

                    // load headers from 1st row
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        dt.Columns.Add(new DataColumn(
                            (ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString())
                            );
                    }
                    dt.AcceptChanges();

                    // load names of columns to array
                    string[] columnNames = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columnNames[i] = dt.Columns[i].ColumnName;
                    }

                    // load data from other rows
                    for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                            {
                                dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                            }
                        }
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                    }

                    // show data
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Loaded data successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Loading failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    workbook.Close(false);
                    app.Quit();
                }
            }
            else
            {
                MessageBox.Show("You did not chose a file", "Loading data...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
