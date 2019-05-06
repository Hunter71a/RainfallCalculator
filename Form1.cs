using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainfallCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
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
            if (result == DialogResult.OK)
            {
                // clearTextBoxes();
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Error: Filename Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }                                          
            TbxFileName.Text = fileName;
            TbxFilePath.Text = filePath;
        }
    }
}
