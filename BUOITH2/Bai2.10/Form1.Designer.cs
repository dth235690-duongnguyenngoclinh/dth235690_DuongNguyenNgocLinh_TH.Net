namespace Bai2._10
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
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnChuVi = new Button();
            btnDienTich = new Button();
            btnDuongCheo = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(244, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 10;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 80);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 13;
            label4.Text = "HINH CHU NHAT";
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(89, 342);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(94, 29);
            btnChuVi.TabIndex = 14;
            btnChuVi.Text = "Chu Vi";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(216, 342);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(94, 29);
            btnDienTich.TabIndex = 15;
            btnDienTich.Text = "Dien Tich";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Location = new Point(352, 342);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(118, 29);
            btnDuongCheo.TabIndex = 16;
            btnDuongCheo.Text = "Duong Cheo";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(527, 342);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDuongCheo);
            Controls.Add(btnDienTich);
            Controls.Add(btnChuVi);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bai2.10";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChuVi;
        private Button btnDienTich;
        private Button btnDuongCheo;
        private Button btnThoat;
    }
}
