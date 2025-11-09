namespace Bai2._8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnTong = new Button();
            btnHieu = new Button();
            btnTich = new Button();
            btnThuong = new Button();
            label5 = new Label();
            txtKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 53);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "PHEP TOAN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(272, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 120);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // txtB
            // 
            txtB.Location = new Point(101, 81);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 8;
            // 
            // txtA
            // 
            txtA.Location = new Point(101, 41);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 44);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Nhập a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 81);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhập b:";
            // 
            // btnTong
            // 
            btnTong.Location = new Point(144, 342);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 29);
            btnTong.TabIndex = 9;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnHieu
            // 
            btnHieu.Location = new Point(261, 342);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(94, 29);
            btnHieu.TabIndex = 10;
            btnHieu.Text = "Hieu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnTich
            // 
            btnTich.Location = new Point(361, 342);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(94, 29);
            btnTich.TabIndex = 11;
            btnTich.Text = "Tich";
            btnTich.UseVisualStyleBackColor = true;
            btnTich.Click += btnTich_Click;
            // 
            // btnThuong
            // 
            btnThuong.Location = new Point(476, 342);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(94, 29);
            btnThuong.TabIndex = 12;
            btnThuong.Text = "Thuong";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 291);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(361, 291);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnThuong);
            Controls.Add(txtKetQua);
            Controls.Add(btnTich);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label2;
        private Label label3;
        private Button btnTong;
        private Button btnHieu;
        private Button btnTich;
        private Button btnThuong;
        private Label label5;
        private TextBox txtKetQua;
    }
}
