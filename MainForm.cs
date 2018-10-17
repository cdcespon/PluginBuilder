using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PluginBuilder
{
    public partial class MainForm : Form
    {
        private string ConvertedLines = string.Empty;
        private string TemplateCode = string.Empty;
        DialogForm dialogForm = new DialogForm();
        public MainForm()
        {
            InitializeComponent();
        }
        private void ConvertLinesToolStripButton_Click(object sender, EventArgs e)
        {
            ConvertLines();
            ResultTextBox.Text = ConvertedLines;
        }

        private void ConvertLines()
        {
            ResultTextBox.Clear();
            foreach (string line in sourceTextBox.Lines)
            {
                string lineToConvert = line.Replace(((char)34).ToString(), "\" + System.Convert.ToChar(34) + \"");
                string convertedLine = "output.AppendLine(\"" + lineToConvert + "\") ;" + Environment.NewLine;
                ConvertedLines += convertedLine;
            }
        }
        private void ConvertToolStripButton_Click(object sender, EventArgs e)
        {
            dialogForm.ShowDialog();
            if (dialogForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                ConvertLines();
                LoadTemplate();
                TemplateCode = TemplateCode.
                    Replace("@@PLUGIN_CLASS_NAME@@", dialogForm.PluginClassNameTextBox.Text.Trim())
                    .Replace("@@PLUGIN_NAME@@", dialogForm.PluginNameTextBox.Text.Trim())
                    .Replace("@@PLUGIN_DESCRIPTION@@", dialogForm.PluginDescriptionTextBox.Text.Trim())
                    .Replace("@@TEMPLATE_NAME@@", dialogForm.TemplateNameTextBox.Text.Trim())
                    .Replace("@@TEMPLATE_DESCRIPTION@@", dialogForm.TemplateDescriptionTextBox.Text.Trim())
                    .Replace("@@TEMPLATE_OUTPUT_LANGUAGE@@", dialogForm.TemplateOutputLangTextBox.Text.Trim())
                    .Replace("@@GUID@@", dialogForm.GUIDValueLabel.Text.Trim());

                ResultTextBox.Text = TemplateCode.Replace("@@TEMPLATE_CODE@@", ConvertedLines);
            }
        }

        private void ClearSourceToolStripButton_Click(object sender, EventArgs e)
        {
            sourceTextBox.Clear();
        }

        private void PasteSourceToolStripButton_Click(object sender, EventArgs e)
        {
            sourceTextBox.Text = Clipboard.GetText();
        }

        private void ClearDestinyToolStripButton_Click(object sender, EventArgs e)
        {
            ConvertedLines = String.Empty;
            ResultTextBox.Clear();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length > 0)
                Clipboard.SetText(ResultTextBox.Text);
        }

        private void SaveFileToolStripButton_Click(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\" + dialogForm.PluginFilenameTextBox.Text.Trim();
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath);
                sw.Write(ResultTextBox.Text);
                sw.Flush();
                sw.Close();
            }
            else
            {
                MessageBox.Show("File " + filePath + " already exists!", "File already exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LoadTemplate()
        {
            TemplateCode = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Template.txt");
        }
    }
}
