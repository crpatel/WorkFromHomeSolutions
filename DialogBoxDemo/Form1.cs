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

namespace DialogBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = false;
            var result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                lblSelectedContent.Text = path;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Document|*.docx|Text|*.txt|pdf|*.pdf";
            
            openFileDialog1.DefaultExt = ".pdf";
            openFileDialog1.InitialDirectory = @"c:\";
            var result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filePath = openFileDialog1.SafeFileName;
                lblSelectedContent.Text = filePath;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                lblSelectedContent.Text = color.Name;
                lblSelectedContent.ForeColor = color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text|*.txt |Word|*.docx|PDF|*.pdf|PPT|*.pptx";
            saveFileDialog1.FileName = "newFile";
            saveFileDialog1.FilterIndex = 3;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtFile.Text);               
            }

        }
    }
}
