using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenStandart_Click(object sender, EventArgs e)
        {
            string path = "C:/data.txt";
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            string s;
            textBoxFileData.Text = "";
            while ((s = sr.ReadLine()) != null)
            {
                textBoxFileData.Text += s + System.Environment.NewLine;
            }
            sr.Close();
        }

        private void buttonSelectOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (d.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(d.FileName, System.Text.Encoding.Default);
                string s;
                textBoxFileData.Text = "";
                while ((s = sr.ReadLine()) != null)
                {
                    textBoxFileData.Text += s + System.Environment.NewLine;
                }
                sr.Close();
            }
            d.Dispose();
        }

        private void buttonSelectAndSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (d.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(d.FileName, false, System.Text.Encoding.Default);

                sw.WriteLine(textBoxFileData.Text);

                sw.Close();
            }
            d.Dispose();
        }
    }
}
