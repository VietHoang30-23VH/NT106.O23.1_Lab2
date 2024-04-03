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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_22520471
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            treeView.AfterSelect += treeView_AfterSelect;
        }
        private void Bai7_Load(object sender, EventArgs e)
        {
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            treeView.Nodes.Clear();

            // Truy xuẩt các ổ đĩa 
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Thêm các ổ
            foreach (DriveInfo drive in drives)
            {
                // Loạt trừ ổ C vì cần quyền administator
                if (drive.Name != @"C:\")
                {
                    TreeNode rootNode = new TreeNode(drive.Name);
                    rootNode.Tag = drive.RootDirectory;
                    treeView.Nodes.Add(rootNode);

                    // Truy hồi để thêm các folder con
                    AddSubDirectories(rootNode, drive.RootDirectory);
                }
            }
        }
        private void AddSubDirectories(TreeNode node, DirectoryInfo dir)
        {
            DirectoryInfo[] subDirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in subDirs)
            {
                try
                {
                    TreeNode subNode = new TreeNode(subDir.Name);
                    subNode.Tag = subDir.FullName;
                    AddSubDirectories(subNode, subDir);
                    node.Nodes.Add(subNode);
                    AddFiles(subNode, subDir);
                }
                // Để bỏ qua các folder bị lỗi hoăc không truy cập được
                catch (UnauthorizedAccessException ex){}
            }
        }
        private void AddFiles(TreeNode node, DirectoryInfo dir)
        {
            // Thêm các file
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                try
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file.FullName;
                    node.Nodes.Add(fileNode);
                }
                catch (UnauthorizedAccessException ex) { }
            }
        }
        private void DisplayFileContent(string filePath)
        {
            // Lấy đuôi của file vd như .txt 
            string extension = Path.GetExtension(filePath).ToLowerInvariant();
            if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".bmp" || extension == ".gif")
            {
                try
                {
                    Image image = Image.FromFile(filePath);
                    // Điều chỉnh độ rộng của ảnh để phù hợp với pictrueBox
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = image;
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Không hỗ trợ!!!.");
                }
            }
            else if (extension == ".txt")
            {
                string fileContent = File.ReadAllText(filePath);
                richTextBox.Text = fileContent;
            }
            else
            {
                MessageBox.Show("Không đủ phương tiện hỗ trợ để trình bày!");
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Kiểm tra xem có folder đó chưa, có thì mới trình bày
            if (e.Node.Tag != null && File.Exists(e.Node.Tag.ToString()))
            {
                DisplayFileContent(e.Node.Tag.ToString());
            }
        }
    }
}