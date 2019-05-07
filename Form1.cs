using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainfallCalculator
{
    public partial class Form1 : Form
    {

        public const double _END = 99999;

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnOpenFile(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            string filePath;
                       
            /*
             * Use Windows OpenFileDialog to select file
             */
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.Title = "Find Rainfall Text";
                fileChooser.Filter = "Text Files|*.txt";
                fileChooser.InitialDirectory = @"C:\";
                result = fileChooser.ShowDialog();
                filePath = fileChooser.FileName;
                fileName = fileChooser.SafeFileName;
            }
            if (result != DialogResult.OK || string.IsNullOrEmpty(filePath))
            {          
                  MessageBox.Show("Error: Filename Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            TbxFileName.Text = fileName;
            TbxFilePath.Text = filePath;
        }    

        private void GetDataFile()
        {
            List<double> processedData = new List<double>();
            string filePath = TbxFilePath.Text;
            string fileName = TbxFileName.Text;
            if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                using (FileStream inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {     
                    StreamReader reader = new StreamReader(inputStream);
                    string input;
                    double rainfall;
                    int count = 0;
                    bool sentinalValue = false;          
                    input = reader.ReadLine();
                    while (reader != null && sentinalValue != true)
                    {
                        rainfall = Convert.ToDouble(input);
                        if (rainfall < 0)               // filter out bad data that is less than Zero
                        {
                            //  method does nothing with bad data and it is eliminated
                        }
                        else if (rainfall == _END)      //end of data sentinal value
                        {
                            sentinalValue = true;
                        }
                        else
                        {
                            processedData.Add(rainfall);
                        }
                        input = reader.ReadLine();
                        count++;
                    }
                    TbxAverageRainfall.Text = processedData.Average().ToString();
                    TbxGoodRows.Text = processedData.Count.ToString();
                    TbxRowsProcessed.Text = (count).ToString();
                    reader.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File could not be opened\nCheck the filename or path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            WriteProcessedData(processedData);
        }


        /*
         * Write output of processed data to .txt file
         * This method worns the user if they are going to overwrite an
         * existing file and gives the user the option to enter a new file name
         * before writing the file. It writes the file into a "doc" folder relative
         * to the executable program
         *
         */

        private void WriteProcessedData(List<double> data)
        {
           
            string outputFile = TbxOutputFileName.Text;
            if (outputFile == "")
            {
                MessageBox.Show("The output file must not be left blank.\nPlease enter a filename.", "Output File Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            string outputFilePath = "..\\..\\doc\\" + outputFile + ".txt";

            if (File.Exists(outputFilePath))
            {
                DialogResult result = MessageBox.Show("The output file already exists,\nThe old data will be lost." +
                    "\nProceed and overwrite the file?", "File already exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Please enter the desired output file name", "Action needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {
                using (FileStream file = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))

                {
                    StreamWriter writer = new StreamWriter(file);
                    foreach (var datum in data)
                    {
                        writer.WriteLine(datum);
                    }
                    writer.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Data output error, file not generated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TbxOutputFile.Text = outputFile;
            TxbOutputPath.Text = outputFilePath;
        }

        /*
         * Button to close application
         */
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Calls method to open and read a data file and then that method 
         * calls a second method to write the processed data into a .txt file
         */
        private void BtnProcessFile_Click(object sender, EventArgs e)
        {
            GetDataFile();
        }
    }
}

