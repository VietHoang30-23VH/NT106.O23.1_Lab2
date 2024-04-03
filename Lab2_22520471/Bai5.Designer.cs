namespace Lab2_22520471
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhapGhi = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.process1 = new System.Diagnostics.Process();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhapGhi
            // 
            this.btnNhapGhi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNhapGhi.Location = new System.Drawing.Point(136, 43);
            this.btnNhapGhi.Name = "btnNhapGhi";
            this.btnNhapGhi.Size = new System.Drawing.Size(190, 66);
            this.btnNhapGhi.TabIndex = 0;
            this.btnNhapGhi.Text = "Nhập File";
            this.btnNhapGhi.UseVisualStyleBackColor = true;
            this.btnNhapGhi.Click += new System.EventHandler(this.btnNhapGhi_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(136, 152);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(190, 66);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Thực hiện tính toán";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(136, 261);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 66);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 155);
            this.panel1.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar.Location = new System.Drawing.Point(25, 71);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1139, 23);
            this.progressBar.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(744, 398);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNhapGhi);
            this.panel2.Controls.Add(this.btnTinh);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 398);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(432, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 398);
            this.panel3.TabIndex = 6;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhapGhi;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Diagnostics.Process process1;
    }
}