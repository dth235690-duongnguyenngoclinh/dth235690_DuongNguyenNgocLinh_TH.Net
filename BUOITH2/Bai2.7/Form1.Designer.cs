namespace Bai2._7
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
            label1 = new Label();
            btnTong = new Button();
            label4 = new Label();
            txtKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(192, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 9;
            label1.Text = "PHEP TOAN";
            // 
            // btnTong
            // 
            btnTong.Location = new Point(263, 357);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 29);
            btnTong.TabIndex = 10;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 280);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 11;
            label4.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(293, 280);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(btnTong);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bai2.7";
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
        private Label label1;
        private Button btnTong;
        private Label label4;
        private TextBox txtKetQua;
    }
}
