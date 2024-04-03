namespace Lab2_22520471
{
    partial class Bai3
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
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(83, 50);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(168, 54);
            this.btnDoc.TabIndex = 0;
            this.btnDoc.Text = "Đọc File Tình Toán";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(312, 50);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(168, 54);
            this.btnGhi.TabIndex = 1;
            this.btnGhi.Text = "Ghi File Kết Quả";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 50);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 54);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(83, 127);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(626, 311);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tính toán trong File";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnDoc);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
    }
}