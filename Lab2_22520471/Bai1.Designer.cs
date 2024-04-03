namespace Lab2_22520471
{
    partial class Bai1
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(147, 46);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(110, 53);
            this.btnDoc.TabIndex = 0;
            this.btnDoc.Text = "Đọc File";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(401, 46);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(110, 53);
            this.btnGhi.TabIndex = 1;
            this.btnGhi.Text = "Ghi File";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(147, 118);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(625, 310);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(662, 46);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 53);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnDoc);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnThoat;
    }
}