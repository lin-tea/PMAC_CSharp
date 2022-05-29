using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace UpComputer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void readfile(string filepath)
        {
            if(File.Exists(filepath))
            {
                form2Text.Clear();
                this.form2Text.AppendText(File.ReadAllText(filepath, Encoding.UTF8));
            }
        }

        private void form2SaveFile_Click(object sender, EventArgs e) //form2保存文件
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "ACLII文件(*.txt,*.pmc)|*.txt;*.pmc";
            saveFileDialog1.FileName = "Utitled.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8);
                sw.Write(this.form2Text.Text);
                sw.Close();
                MessageBox.Show("保存成功");
            }
        }
    }
}
