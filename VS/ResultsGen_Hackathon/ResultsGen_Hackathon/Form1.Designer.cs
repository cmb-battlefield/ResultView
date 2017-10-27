namespace ResultsGen_Hackathon
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
            this.btn1stRndProcess = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn1stRoundResults = new System.Windows.Forms.Button();
            this.txt1stRoundResPath = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2ndRoundResPath = new System.Windows.Forms.TextBox();
            this.txt3rdRoundResPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn2ndRoundResults = new System.Windows.Forms.Button();
            this.btn2ndRndProcess = new System.Windows.Forms.Button();
            this.btn3rdRoundResults = new System.Windows.Forms.Button();
            this.btn3rdRndProcess = new System.Windows.Forms.Button();
            this.btnProcessFinalResults = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn1stRndProcess
            // 
            this.btn1stRndProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1stRndProcess.Location = new System.Drawing.Point(664, 16);
            this.btn1stRndProcess.Name = "btn1stRndProcess";
            this.btn1stRndProcess.Size = new System.Drawing.Size(75, 23);
            this.btn1stRndProcess.TabIndex = 0;
            this.btn1stRndProcess.Text = "Process";
            this.btn1stRndProcess.UseVisualStyleBackColor = true;
            this.btn1stRndProcess.Click += new System.EventHandler(this.btn1stRndProcess_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn1stRoundResults
            // 
            this.btn1stRoundResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1stRoundResults.Location = new System.Drawing.Point(631, 16);
            this.btn1stRoundResults.Name = "btn1stRoundResults";
            this.btn1stRoundResults.Size = new System.Drawing.Size(27, 23);
            this.btn1stRoundResults.TabIndex = 1;
            this.btn1stRoundResults.Text = "...";
            this.btn1stRoundResults.UseVisualStyleBackColor = true;
            this.btn1stRoundResults.Click += new System.EventHandler(this.btn1stRoundResults_Click);
            // 
            // txt1stRoundResPath
            // 
            this.txt1stRoundResPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1stRoundResPath.Location = new System.Drawing.Point(116, 18);
            this.txt1stRoundResPath.Name = "txt1stRoundResPath";
            this.txt1stRoundResPath.Size = new System.Drawing.Size(509, 20);
            this.txt1stRoundResPath.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 164);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(726, 241);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1st Round Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd Round Results";
            // 
            // txt2ndRoundResPath
            // 
            this.txt2ndRoundResPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2ndRoundResPath.Location = new System.Drawing.Point(116, 47);
            this.txt2ndRoundResPath.Name = "txt2ndRoundResPath";
            this.txt2ndRoundResPath.Size = new System.Drawing.Size(509, 20);
            this.txt2ndRoundResPath.TabIndex = 6;
            // 
            // txt3rdRoundResPath
            // 
            this.txt3rdRoundResPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt3rdRoundResPath.Location = new System.Drawing.Point(116, 76);
            this.txt3rdRoundResPath.Name = "txt3rdRoundResPath";
            this.txt3rdRoundResPath.Size = new System.Drawing.Size(509, 20);
            this.txt3rdRoundResPath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "3rd Round Results";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn2ndRoundResults
            // 
            this.btn2ndRoundResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2ndRoundResults.Location = new System.Drawing.Point(631, 45);
            this.btn2ndRoundResults.Name = "btn2ndRoundResults";
            this.btn2ndRoundResults.Size = new System.Drawing.Size(27, 23);
            this.btn2ndRoundResults.TabIndex = 9;
            this.btn2ndRoundResults.Text = "...";
            this.btn2ndRoundResults.UseVisualStyleBackColor = true;
            this.btn2ndRoundResults.Click += new System.EventHandler(this.btn2ndRoundResults_Click);
            // 
            // btn2ndRndProcess
            // 
            this.btn2ndRndProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2ndRndProcess.Location = new System.Drawing.Point(664, 45);
            this.btn2ndRndProcess.Name = "btn2ndRndProcess";
            this.btn2ndRndProcess.Size = new System.Drawing.Size(75, 23);
            this.btn2ndRndProcess.TabIndex = 10;
            this.btn2ndRndProcess.Text = "Process";
            this.btn2ndRndProcess.UseVisualStyleBackColor = true;
            this.btn2ndRndProcess.Click += new System.EventHandler(this.btn2ndRndProcess_Click);
            // 
            // btn3rdRoundResults
            // 
            this.btn3rdRoundResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3rdRoundResults.Location = new System.Drawing.Point(631, 74);
            this.btn3rdRoundResults.Name = "btn3rdRoundResults";
            this.btn3rdRoundResults.Size = new System.Drawing.Size(27, 23);
            this.btn3rdRoundResults.TabIndex = 11;
            this.btn3rdRoundResults.Text = "...";
            this.btn3rdRoundResults.UseVisualStyleBackColor = true;
            this.btn3rdRoundResults.Click += new System.EventHandler(this.btn3rdRoundResults_Click);
            // 
            // btn3rdRndProcess
            // 
            this.btn3rdRndProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3rdRndProcess.Location = new System.Drawing.Point(664, 74);
            this.btn3rdRndProcess.Name = "btn3rdRndProcess";
            this.btn3rdRndProcess.Size = new System.Drawing.Size(75, 23);
            this.btn3rdRndProcess.TabIndex = 12;
            this.btn3rdRndProcess.Text = "Process";
            this.btn3rdRndProcess.UseVisualStyleBackColor = true;
            this.btn3rdRndProcess.Click += new System.EventHandler(this.btn3rdRndProcess_Click);
            // 
            // btnProcessFinalResults
            // 
            this.btnProcessFinalResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessFinalResults.Location = new System.Drawing.Point(610, 135);
            this.btnProcessFinalResults.Name = "btnProcessFinalResults";
            this.btnProcessFinalResults.Size = new System.Drawing.Size(129, 23);
            this.btnProcessFinalResults.TabIndex = 13;
            this.btnProcessFinalResults.Text = "Process Final Results";
            this.btnProcessFinalResults.UseVisualStyleBackColor = true;
            this.btnProcessFinalResults.Click += new System.EventHandler(this.btnProcessFinalResults_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Output Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(116, 105);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(509, 20);
            this.txtOutputPath.TabIndex = 15;
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputPath.Location = new System.Drawing.Point(631, 103);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(27, 23);
            this.btnOutputPath.TabIndex = 16;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 417);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcessFinalResults);
            this.Controls.Add(this.btn3rdRndProcess);
            this.Controls.Add(this.btn3rdRoundResults);
            this.Controls.Add(this.btn2ndRndProcess);
            this.Controls.Add(this.btn2ndRoundResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt3rdRoundResPath);
            this.Controls.Add(this.txt2ndRoundResPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt1stRoundResPath);
            this.Controls.Add(this.btn1stRoundResults);
            this.Controls.Add(this.btn1stRndProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1stRndProcess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn1stRoundResults;
        private System.Windows.Forms.TextBox txt1stRoundResPath;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2ndRoundResPath;
        private System.Windows.Forms.TextBox txt3rdRoundResPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn2ndRoundResults;
        private System.Windows.Forms.Button btn2ndRndProcess;
        private System.Windows.Forms.Button btn3rdRoundResults;
        private System.Windows.Forms.Button btn3rdRndProcess;
        private System.Windows.Forms.Button btnProcessFinalResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}

