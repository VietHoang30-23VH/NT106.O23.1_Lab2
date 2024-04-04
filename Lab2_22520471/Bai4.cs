using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_22520471
{
    public partial class Bai4 : Form
    {
        public class Student
        {
            private double diem1;
            private double diem2;
            private double diem3;

            public string Ten { get; set; }
            public int ID { get; set; }
            public string SDT { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double DTB { get; set; }
            public Student(string _ten, int _id,string _sdt, double _diem1, double _diem2, double _diem3)
            {
                Ten = _ten;
                ID = _id;
                SDT = _sdt;
                Course1 = _diem1;
                Course2 = _diem2;
                Course3 = _diem3;        
            }
            public Student(double diem1, double diem2, double diem3, string ten, int iD)
            {
                this.diem1 = diem1;
                this.diem2 = diem2;
                this.diem3 = diem3;
                Ten = ten;
                ID = iD;
            }
            public double Average()
            {
                return (this.Course1 + this.Course2 + this.Course3) / 3;
            }
        }
        List<Student> students = new List<Student>();
        List<Student> DScuoi = new List<Student>();
        int count = 0;
        string  FromRichTextBox = null;
        int index = 0;
        public Bai4()
        {
            InitializeComponent();
        }
        static void Serialize(String filePath, List<Student> students)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Student student in students)
                    {
                        sw.WriteLine($"{student.Ten},{student.ID},{student.SDT},{student.Course1},{student.Course2},{student.Course3}");
                    }
                }
                MessageBox.Show("Xuất ra file thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        static List<Student> Deserialize(string filePath)
        {
            List<Student> students = new List<Student>();
            try
            {
                StreamReader sr = new StreamReader(filePath);
      
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split(',');
                        if (lines.Length == 6)
                        {
                            string name = lines[0];
                            int id = int.Parse(lines[1]);
                            string phone = lines[2];
                            double d1 = double.Parse(lines[3]);
                            double d2 = double.Parse(lines[4]);
                            double d3 = double.Parse(lines[5]);;
                            if (name != null && phone != null) students.Add(new Student(name, id, phone, d1, d2, d3));
                            else
                            {
                                MessageBox.Show("Vui lòng nhập Tên và Số điện thoại");
                            }
                        }
                    }
                MessageBox.Show("Thành công.");
            }
            catch
            {
                MessageBox.Show("Bị lỗi.");
            }
            return students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length != 8)
            {
                MessageBox.Show("Nhập sai ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPhone.Text.Trim().Length != 10 || txtPhone.Text.Trim()[0] != '0')
                {
                    MessageBox.Show("Nhập sai Số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (double.Parse(txtC1.Text) < 0 || double.Parse(txtC1.Text) > 10
                        || double.Parse(txtC2.Text) < 0 || double.Parse(txtC2.Text) > 10
                        || double.Parse(txtC3.Text) < 0 || double.Parse(txtC3.Text) > 10)
                    {
                        MessageBox.Show("Nhập sai điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Student hocsinh = new Student(txtName.Text.Trim(), Int32.Parse(txtPhone.Text.Trim()), txtPhone.Text.Trim(), double.Parse(txtC1.Text.Trim()), double.Parse(txtC2.Text.Trim()), double.Parse(txtC3.Text.Trim()));
                        students.Add(hocsinh);
                        FromRichTextBox += students[count].Ten + "\n" + students[count].ID + '\n' + students[count].SDT + '\n' + students[count].Course1 + '\n' + students[count].Course2 + "\n" + students[count].Course3 + '\n';
                        richTextBox.Text = FromRichTextBox;
                        count++;
                    }

                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            Serialize(ofd.FileName, students);
        }
        private void ShowStudent(int index)
        {
            Student student = DScuoi[index];
            txtName_2.Text = student.Ten;
            txtID_2.Text = student.ID.ToString();
            txtPhone_2.Text = student.SDT.ToString();
            txtC1_2.Text = student.Course1.ToString();
            txtC2_2.Text = student.Course2.ToString();
            txtC3_2.Text = student.Course3.ToString();
            student.DTB = student.Average();
            txtAver_2.Text = student.DTB.ToString();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            DScuoi = Deserialize(ofd.FileName);
            if (DScuoi.Count > 0)
            {
                ShowStudent(0);
                index = 1;
                txtPage.Text = index.ToString();          
            }
            else
            {
                MessageBox.Show("Hãy thêm sinh viên.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 1 && index <= DScuoi.Count)
            {
                index--;
                txtPage.Text = index.ToString();
                ShowStudent(index - 1);
            }
            else
            {
                MessageBox.Show("First student");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

                if (index < DScuoi.Count)
                {
                    index++;
                    txtPage.Text = index.ToString();
                    ShowStudent(index - 1);
                }
                else
                {
                    MessageBox.Show("Last student");
                }
            
        }
    }
}