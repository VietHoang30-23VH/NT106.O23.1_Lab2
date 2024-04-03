namespace Lab2_22520471
{
    partial class Bai2
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
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChaCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.BackColor = System.Drawing.Color.Chartreuse;
            this.btnReadFromFile.Location = new System.Drawing.Point(13, 13);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(319, 50);
            this.btnReadFromFile.TabIndex = 0;
            this.btnReadFromFile.Text = "Read From File";
            this.btnReadFromFile.UseVisualStyleBackColor = false;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFileName.Location = new System.Drawing.Point(11, 85);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(319, 22);
            this.txtFileName.TabIndex = 2;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSize.Location = new System.Drawing.Point(11, 142);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(319, 22);
            this.txtSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtURL.Location = new System.Drawing.Point(11, 198);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(319, 22);
            this.txtURL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL";
            // 
            // txtLineCount
            // 
            this.txtLineCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLineCount.Location = new System.Drawing.Point(11, 255);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.ReadOnly = true;
            this.txtLineCount.Size = new System.Drawing.Size(319, 22);
            this.txtLineCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Line Count";
            // 
            // txtChaCount
            // 
            this.txtChaCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChaCount.Location = new System.Drawing.Point(13, 379);
            this.txtChaCount.Name = "txtChaCount";
            this.txtChaCount.ReadOnly = true;
            this.txtChaCount.Size = new System.Drawing.Size(319, 22);
            this.txtChaCount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = " Character Count";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.BurlyWood;
            this.btnThoat.Location = new System.Drawing.Point(11, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(319, 69);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(362, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(504, 477);
            this.richTextBox.TabIndex = 12;
            this.richTextBox.Text = "";
            // 
            // txtWordCount
            // 
            this.txtWordCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWordCount.Location = new System.Drawing.Point(11, 320);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.ReadOnly = true;
            this.txtWordCount.Size = new System.Drawing.Size(319, 22);
            this.txtWordCount.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Word Count";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtChaCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadFromFile);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChaCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.Label label6;
    }
}