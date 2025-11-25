namespace Bai2._5
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
            btnTong = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTong
            // 
            btnTong.Location = new Point(210, 306);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 29);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(137, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(192, 62);
            label1.Name = "label1";
            label1.Size = new Size(146, 35);
            label1.TabIndex = 2;
            label1.Text = "PHEP TOAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 40);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhập a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Nhập b:";
            // 
            // txtA
            // 
            txtA.Location = new Point(105, 33);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(105, 83);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 425);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnTong);
            Name = "Form1";
            Text = "Bai2.5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTong;
        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
