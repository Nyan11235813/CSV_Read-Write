namespace CSV読み書きアプリ2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridViewCsv = new DataGridView();
            saveFileDialogCsv = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            textBoxInputCSVFileName = new TextBox();
            buttonsansyou1 = new Button();
            buttonCsvRead = new Button();
            textBoxOutputCSVFileName = new TextBox();
            buttonsansyou2 = new Button();
            buttonCsvWrite = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(24, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "エンコード";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(531, 25);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(80, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Shift_JIS";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(361, 25);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "UTF-8";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(196, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "UTF-16";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "自動";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCsv
            // 
            dataGridViewCsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCsv.Location = new Point(24, 121);
            dataGridViewCsv.Name = "dataGridViewCsv";
            dataGridViewCsv.RowHeadersWidth = 49;
            dataGridViewCsv.Size = new Size(764, 285);
            dataGridViewCsv.TabIndex = 1;
            // 
            // saveFileDialogCsv
            // 
            saveFileDialogCsv.FileName = "*.csv";
            saveFileDialogCsv.InitialDirectory = ".\\";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogCsv";
            openFileDialog1.InitialDirectory = "CSVファイル|.*csv|すべてのファイル|*.*";
            // 
            // textBoxInputCSVFileName
            // 
            textBoxInputCSVFileName.Location = new Point(24, 89);
            textBoxInputCSVFileName.Name = "textBoxInputCSVFileName";
            textBoxInputCSVFileName.Size = new Size(585, 26);
            textBoxInputCSVFileName.TabIndex = 2;
            // 
            // buttonsansyou1
            // 
            buttonsansyou1.Location = new Point(615, 89);
            buttonsansyou1.Name = "buttonsansyou1";
            buttonsansyou1.Size = new Size(75, 26);
            buttonsansyou1.TabIndex = 3;
            buttonsansyou1.Text = "参照";
            buttonsansyou1.UseVisualStyleBackColor = true;
            buttonsansyou1.Click += buttonsansyou1_Click;
            // 
            // buttonCsvRead
            // 
            buttonCsvRead.Location = new Point(696, 89);
            buttonCsvRead.Name = "buttonCsvRead";
            buttonCsvRead.Size = new Size(92, 26);
            buttonCsvRead.TabIndex = 3;
            buttonCsvRead.Text = "CSV取得";
            buttonCsvRead.UseVisualStyleBackColor = true;
            buttonCsvRead.Click += buttonCsvRead_Click;
            // 
            // textBoxOutputCSVFileName
            // 
            textBoxOutputCSVFileName.Location = new Point(24, 412);
            textBoxOutputCSVFileName.Name = "textBoxOutputCSVFileName";
            textBoxOutputCSVFileName.Size = new Size(585, 26);
            textBoxOutputCSVFileName.TabIndex = 2;
            // 
            // buttonsansyou2
            // 
            buttonsansyou2.Location = new Point(617, 412);
            buttonsansyou2.Name = "buttonsansyou2";
            buttonsansyou2.Size = new Size(75, 26);
            buttonsansyou2.TabIndex = 3;
            buttonsansyou2.Text = "参照";
            buttonsansyou2.UseVisualStyleBackColor = true;
            buttonsansyou2.Click += buttonsansyou2_Click;
            // 
            // buttonCsvWrite
            // 
            buttonCsvWrite.Location = new Point(698, 411);
            buttonCsvWrite.Name = "buttonCsvWrite";
            buttonCsvWrite.Size = new Size(92, 26);
            buttonCsvWrite.TabIndex = 3;
            buttonCsvWrite.Text = "CSV出力";
            buttonCsvWrite.UseVisualStyleBackColor = true;
            buttonCsvWrite.Click += buttonCsvWrite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCsvWrite);
            Controls.Add(buttonCsvRead);
            Controls.Add(buttonsansyou2);
            Controls.Add(buttonsansyou1);
            Controls.Add(textBoxOutputCSVFileName);
            Controls.Add(textBoxInputCSVFileName);
            Controls.Add(dataGridViewCsv);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewCsv;
        private SaveFileDialog saveFileDialogCsv;
        private OpenFileDialog openFileDialog1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBoxInputCSVFileName;
        private Button buttonsansyou1;
        private Button buttonCsvRead;
        private TextBox textBoxOutputCSVFileName;
        private Button buttonsansyou2;
        private Button buttonCsvWrite;
    }
}