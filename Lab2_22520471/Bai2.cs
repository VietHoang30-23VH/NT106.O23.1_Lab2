using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab2_22520471
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text|*.txt|All|*.*";
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                richTextBox.Text = sr.ReadToEnd();
                // Xuat ten File
                txtFileName.Text = Path.GetFileName(ofd.FileName);
                // Xuat size
                FileInfo fileInfor = new FileInfo(ofd.FileName);
                txtSize.Text = fileInfor.Length.ToString() + " " + "bytes";
                // Xuat URL
                txtURL.Text = fs.Name;
                // Xuat so Ki tu
                fs.Position = 0;
                txtChaCount.Text = sr.ReadToEnd().Length.ToString();
                // Xuat so dong
                fs.Position = 0;
                int lineCount = 0;
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
                txtLineCount.Text = lineCount.ToString();
                // Xuat so tu
                fs.Position = 0;
                string content = sr.ReadToEnd();
                string[] words = content.Split(new char[] { ' ',',','\n','\t','\r' }, StringSplitOptions.RemoveEmptyEntries);
                int wordscount = words.Length;
                txtWordCount.Text = wordscount.ToString();
            
                sr.Close();
                fs.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
