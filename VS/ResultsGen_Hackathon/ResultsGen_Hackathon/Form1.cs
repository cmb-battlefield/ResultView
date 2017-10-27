using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResultsGen_Hackathon_Class;

namespace ResultsGen_Hackathon
{
    public partial class Form1 : Form
    {
        List<CsvRow> results;

        public Form1()
        {
            InitializeComponent();
        }

        void WriteTest()
        {
            // Write sample data to CSV file
            using (CsvFileWriter writer = new CsvFileWriter("WriteTest.csv"))
            {
                for (int i = 0; i < 100; i++)
                {
                    CsvRow row = new CsvRow();
                    for (int j = 0; j < 5; j++)
                        row.Add(String.Format("Column{0}", j));
                    writer.WriteRow(row);
                }
            }
        }

        void appentToRichTextBox(string fileName)
        {
            // Read sample data from CSV file
            richTextBox1.Clear();
            using (CsvFileReader reader = new CsvFileReader(txtOutputPath.Text + @"\" + fileName))
            {
                CsvRow row = new CsvRow();
                int counter = 0;

                while (reader.ReadRow(row))
                {
                    if (counter == 0 || row.Contains("$"))
                    {
                        counter++;
                        continue;
                    } 

                    foreach (string s in row)
                    {
                        richTextBox1.AppendText(s);
                        richTextBox1.AppendText("\t");
                    }
                    richTextBox1.AppendText("\n"); ;
                    counter++;
                }
            }
        }


        private void openFileDialog(TextBox filePath)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                filePath.Text = openFileDialog1.FileName;
            }
        }

        private void btn1stRoundResults_Click(object sender, EventArgs e)
        {
            openFileDialog(txt1stRoundResPath);
        }

        private void btn2ndRoundResults_Click(object sender, EventArgs e)
        {
            openFileDialog(txt2ndRoundResPath);
        }

        private void btn3rdRoundResults_Click(object sender, EventArgs e)
        {
            openFileDialog(txt3rdRoundResPath);
        }

        private void btn1stRndProcess_Click(object sender, EventArgs e)
        {
            try
            {
                new ProcessCsv().ProcessCsvFile(txt1stRoundResPath.Text, txtOutputPath.Text, "1st");
                appentToRichTextBox("1stRoundResults_final.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2ndRndProcess_Click(object sender, EventArgs e)
        {
            try
            {
                new ProcessCsv().ProcessCsvFile(txt2ndRoundResPath.Text, txtOutputPath.Text, "2nd");
                appentToRichTextBox("2ndRoundResults_final.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3rdRndProcess_Click(object sender, EventArgs e)
        {
            try
            {
                new ProcessCsv().ProcessCsvFile(txt3rdRoundResPath.Text, txtOutputPath.Text, "3rd");
                appentToRichTextBox("3rdRoundResults_final.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtOutputPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcessFinalResults_Click(object sender, EventArgs e)
        {
            try
            {
                new ProcessCsv().ProcessFinalResults(txtOutputPath.Text);
                appentToRichTextBox("FinalResults.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
