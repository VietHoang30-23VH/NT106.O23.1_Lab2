using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2_22520471
{
    public partial class Bai3 : Form
    {
        
        public Bai3()
        {
            InitializeComponent();
        }
        List<string> listline; 
        static double CalculateExpression(string expression)
        {
            NCalc.Expression exp = new NCalc.Expression(expression);
            return Convert.ToDouble(exp.Evaluate());
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            listline = new List<string>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                listline.Add(line.Trim());
            }
            sr.Close();
            fs.Close();
            StringBuilder richTextBoxContent = new StringBuilder();
            foreach (String tmp in listline)
            {
                richTextBoxContent.AppendLine(tmp);
            }
            richTextBox.Text = richTextBoxContent.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
 
        private void btnGhi_Click(object sender, EventArgs e)
        {
            int lineNumber=1;
            string storage = "";
            foreach (String tmp in listline)
            {
                string expression = tmp.Trim().Replace("–", "-").Replace("′", "'");
                string text = expression + "=";
                double result = CalculateExpression(expression);
                text += result.ToString();
                storage += text;
                if (lineNumber < listline.Count)
                {
                    storage += Environment.NewLine;
                }
                lineNumber++;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.ShowDialog();
            StreamWriter sw = new StreamWriter(sfd.FileName);
            sw.Write(storage);
            sw.Close();
            MessageBox.Show("Đã xuất ra output vào file: " + sfd.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}