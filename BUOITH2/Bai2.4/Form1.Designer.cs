namespace Bai2._4
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
            btnHienThi = new Button();
            label1 = new Label();
            txtNhapHoTen = new TextBox();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(172, 224);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 81);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập Họ Tên:";
            // 
            // txtNhapHoTen
            // 
            txtNhapHoTen.Location = new Point(220, 78);
            txtNhapHoTen.Name = "txtNhapHoTen";
            txtNhapHoTen.Size = new Size(125, 27);
            txtNhapHoTen.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 392);
            Controls.Add(txtNhapHoTen);
            Controls.Add(label1);
            Controls.Add(btnHienThi);
            Name = "Form1";
            Text = "Bai2.4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHienThi;
        private Label label1;
        private TextBox txtNhapHoTen;
    }
}
