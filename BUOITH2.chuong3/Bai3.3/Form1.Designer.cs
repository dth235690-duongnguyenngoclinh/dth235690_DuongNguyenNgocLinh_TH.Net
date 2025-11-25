namespace Bai3._3
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
            btnKiemTra = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtNgay = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(231, 253);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(94, 29);
            btnKiemTra.TabIndex = 0;
            btnKiemTra.Text = "Kiem Tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 28);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 1;
            label1.Text = "KIEM TRA NGAY THANG HOP LE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 37);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 80);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "Thang:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 130);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Nam:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNam);
            groupBox1.Controls.Add(txtThang);
            groupBox1.Controls.Add(txtNgay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(174, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 168);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(75, 30);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(125, 27);
            txtNgay.TabIndex = 5;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(75, 77);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(125, 27);
            txtThang.TabIndex = 6;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(75, 123);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(125, 27);
            txtNam.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnKiemTra);
            Name = "Form1";
            Text = "Bai3.3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKiemTra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtNgay;
    }
}
