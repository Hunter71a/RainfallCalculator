namespace RainfallCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BtnProcessFile = new System.Windows.Forms.Button();
            this.TbxFileName = new System.Windows.Forms.TextBox();
            this.TbxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxOutputFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxRowsProcessed = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TbxGoodRows = new System.Windows.Forms.TextBox();
            this.TbxAverageRainfall = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbOutputPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxOutputFileName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnOpenFile);
            // 
            // BtnProcessFile
            // 
            this.BtnProcessFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcessFile.Location = new System.Drawing.Point(324, 188);
            this.BtnProcessFile.Name = "BtnProcessFile";
            this.BtnProcessFile.Size = new System.Drawing.Size(173, 44);
            this.BtnProcessFile.TabIndex = 1;
            this.BtnProcessFile.Text = "Process File";
            this.BtnProcessFile.UseVisualStyleBackColor = true;
            this.BtnProcessFile.Click += new System.EventHandler(this.BtnProcessFile_Click);
            // 
            // TbxFileName
            // 
            this.TbxFileName.Location = new System.Drawing.Point(106, 135);
            this.TbxFileName.Name = "TbxFileName";
            this.TbxFileName.Size = new System.Drawing.Size(226, 20);
            this.TbxFileName.TabIndex = 2;
            this.TbxFileName.Text = "rainfall.txt";
            // 
            // TbxFilePath
            // 
            this.TbxFilePath.Location = new System.Drawing.Point(106, 98);
            this.TbxFilePath.Name = "TbxFilePath";
            this.TbxFilePath.Size = new System.Drawing.Size(656, 20);
            this.TbxFilePath.TabIndex = 3;
            this.TbxFilePath.Text = "..\\..\\doc\\rainfall.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rainfall Analyzer";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(666, 189);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(96, 43);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select the data file for analysis:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.TxbOutputPath);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TbxOutputFile);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TbxRowsProcessed);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.TbxGoodRows);
            this.panel1.Controls.Add(this.TbxAverageRainfall);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(106, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 185);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Output File Path:";
            // 
            // TbxOutputFile
            // 
            this.TbxOutputFile.Location = new System.Drawing.Point(268, 107);
            this.TbxOutputFile.Name = "TbxOutputFile";
            this.TbxOutputFile.Size = new System.Drawing.Size(143, 20);
            this.TbxOutputFile.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Processed Data File Name:";
            // 
            // TbxRowsProcessed
            // 
            this.TbxRowsProcessed.Location = new System.Drawing.Point(268, 10);
            this.TbxRowsProcessed.Name = "TbxRowsProcessed";
            this.TbxRowsProcessed.Size = new System.Drawing.Size(143, 20);
            this.TbxRowsProcessed.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 185);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // TbxGoodRows
            // 
            this.TbxGoodRows.Location = new System.Drawing.Point(268, 43);
            this.TbxGoodRows.Name = "TbxGoodRows";
            this.TbxGoodRows.Size = new System.Drawing.Size(143, 20);
            this.TbxGoodRows.TabIndex = 4;
            // 
            // TbxAverageRainfall
            // 
            this.TbxAverageRainfall.Location = new System.Drawing.Point(268, 76);
            this.TbxAverageRainfall.Name = "TbxAverageRainfall";
            this.TbxAverageRainfall.Size = new System.Drawing.Size(143, 20);
            this.TbxAverageRainfall.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Average Daily Rainfall:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rows of Good Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rows of Data Processed:";
            // 
            // TxbOutputPath
            // 
            this.TxbOutputPath.Location = new System.Drawing.Point(268, 142);
            this.TxbOutputPath.Name = "TxbOutputPath";
            this.TxbOutputPath.Size = new System.Drawing.Size(143, 20);
            this.TxbOutputPath.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(406, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Output File:";
            // 
            // TbxOutputFileName
            // 
            this.TbxOutputFileName.Location = new System.Drawing.Point(506, 138);
            this.TbxOutputFileName.Name = "TbxOutputFileName";
            this.TbxOutputFileName.Size = new System.Drawing.Size(256, 20);
            this.TbxOutputFileName.TabIndex = 11;
            this.TbxOutputFileName.Text = "rainfall2.txt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::RainfallCalculator.Properties.Resources.sparkle;
            this.pictureBox1.Location = new System.Drawing.Point(79, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::RainfallCalculator.Properties.Resources.sparkle;
            this.pictureBox2.Location = new System.Drawing.Point(590, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Deluxe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbxOutputFileName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxFilePath);
            this.Controls.Add(this.TbxFileName);
            this.Controls.Add(this.BtnProcessFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rainfall Analyzer XL2000";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnProcessFile;
        private System.Windows.Forms.TextBox TbxFileName;
        private System.Windows.Forms.TextBox TbxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbxRowsProcessed;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox TbxGoodRows;
        private System.Windows.Forms.TextBox TbxAverageRainfall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxOutputFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxbOutputPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbxOutputFileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
    }
}

