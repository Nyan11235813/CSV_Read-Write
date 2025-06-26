using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CSV読み書きアプリ2
{
    public partial class Form1 : Form
    {
        private DataTable csvDataTable;

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // Set default encoding to Auto
            radioButton1.Checked = true;

            // Set file dialog filters
            openFileDialog1.Filter = "CSVファイル|*.csv|すべてのファイル|*.*";
            openFileDialog1.InitialDirectory = ".\\";

            saveFileDialogCsv.Filter = "CSVファイル|*.csv|すべてのファイル|*.*";
            saveFileDialogCsv.InitialDirectory = ".\\";

            // Initialize DataTable
            csvDataTable = new DataTable();
        }

        // Browse button for input file
        private void buttonsansyou1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInputCSVFileName.Text = openFileDialog1.FileName;
            }
        }

        // Browse button for output file
        private void buttonsansyou2_Click(object sender, EventArgs e)
        {
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputCSVFileName.Text = saveFileDialogCsv.FileName;
            }
        }

        // CSV Read button
        private void buttonCsvRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInputCSVFileName.Text))
            {
                MessageBox.Show("CSVファイルを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(textBoxInputCSVFileName.Text))
            {
                MessageBox.Show("指定されたファイルが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ReadCsvFile(textBoxInputCSVFileName.Text);
                MessageBox.Show("CSVファイルを正常に読み込みました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSVファイルの読み込みに失敗しました。\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CSV Write button
        private void buttonCsvWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOutputCSVFileName.Text))
            {
                MessageBox.Show("出力先のCSVファイルを指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (csvDataTable == null || csvDataTable.Rows.Count == 0)
            {
                MessageBox.Show("出力するデータがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                WriteCsvFile(textBoxOutputCSVFileName.Text);
                MessageBox.Show("CSVファイルを正常に出力しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSVファイルの出力に失敗しました。\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadCsvFile(string fileName)
        {
            Encoding encoding = GetSelectedEncoding();

            // Clear existing data
            csvDataTable.Clear();
            csvDataTable.Columns.Clear();

            string[] lines = File.ReadAllLines(fileName, encoding);

            if (lines.Length == 0)
            {
                throw new Exception("ファイルが空です。");
            }

            // Parse header row
            string[] headers = ParseCsvLine(lines[0]);
            foreach (string header in headers)
            {
                csvDataTable.Columns.Add(header.Trim());
            }

            // Parse data rows
            for (int i = 1; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    string[] values = ParseCsvLine(lines[i]);
                    DataRow row = csvDataTable.NewRow();

                    for (int j = 0; j < Math.Min(values.Length, csvDataTable.Columns.Count); j++)
                    {
                        row[j] = values[j];
                    }

                    csvDataTable.Rows.Add(row);
                }
            }

            // Bind to DataGridView
            dataGridViewCsv.DataSource = csvDataTable;
        }

        private void WriteCsvFile(string fileName)
        {
            Encoding encoding = GetSelectedEncoding();

            using (StreamWriter writer = new StreamWriter(fileName, false, encoding))
            {
                // Write header
                string[] headers = new string[csvDataTable.Columns.Count];
                for (int i = 0; i < csvDataTable.Columns.Count; i++)
                {
                    headers[i] = EscapeCsvValue(csvDataTable.Columns[i].ColumnName);
                }
                writer.WriteLine(string.Join(",", headers));

                // Write data rows
                foreach (DataRow row in csvDataTable.Rows)
                {
                    string[] values = new string[csvDataTable.Columns.Count];
                    for (int i = 0; i < csvDataTable.Columns.Count; i++)
                    {
                        values[i] = EscapeCsvValue(row[i]?.ToString() ?? "");
                    }
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }

        private Encoding GetSelectedEncoding()
        {
            if (radioButton1.Checked) // Auto
            {
                return Encoding.UTF8;
            }
            else if (radioButton2.Checked) // UTF-16
            {
                return Encoding.Unicode;
            }
            else if (radioButton3.Checked) // UTF-8
            {
                return Encoding.UTF8;
            }
            else if (radioButton4.Checked) // Shift_JIS
            {
                try
                {
                    return Encoding.GetEncoding("Shift_JIS");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Shift_JIS encoding is not available. Using UTF-8 instead.",
                                  "Encoding Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return Encoding.UTF8;
                }
            }
            else
            {
                return Encoding.UTF8; // Default
            }
        }

        private string[] ParseCsvLine(string line)
        {
            var result = new System.Collections.Generic.List<string>();
            bool inQuotes = false;
            StringBuilder currentField = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        // Double quote escape
                        currentField.Append('"');
                        i++; // Skip next quote
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(currentField.ToString());
                    currentField.Clear();
                }
                else
                {
                    currentField.Append(c);
                }
            }

            result.Add(currentField.ToString());
            return result.ToArray();
        }

        private string EscapeCsvValue(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }
    }
}