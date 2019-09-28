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

namespace TBPUnpack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseInputFile_button_Click(object sender, EventArgs e)
        {
            var dialResult = openFileDialog1.ShowDialog();
            if (dialResult.Equals(DialogResult.Cancel)) return;

            inputFile_textBox.Text = openFileDialog1.FileName;
        }

        private string GenerateOutputDirPath(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName));
        }

        private void BrowseOutputDir_button_Click(object sender, EventArgs e)
        {
            var dialResult = folderBrowserDialog1.ShowDialog();
            if (dialResult.Equals(DialogResult.Cancel)) return;

            outputDir_textBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void InputFile_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                outputDir_textBox.Text = GenerateOutputDirPath(inputFile_textBox.Text);
            }
            catch (Exception ex) { }
        }

        private void Unpack_button_Click(object sender, EventArgs e)
        {
            try
            {
                var tbpUnpack = new TBPUnpack();
                tbpUnpack.Unpack(inputFile_textBox.Text, outputDir_textBox.Text);

                System.Diagnostics.Process.Start(outputDir_textBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
