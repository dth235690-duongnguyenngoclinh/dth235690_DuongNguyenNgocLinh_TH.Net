namespace Bai3._1
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
            btnTinh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtX = new TextBox();
            txtF = new TextBox();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(239, 259);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 0;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 67);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 1;
            label1.Text = "TINH GIA TRI HAM SO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 113);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 2;
            label2.Text = "x=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 192);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 3;
            label3.Text = "f=";
            // 
            // txtX
            // 
            txtX.Location = new Point(300, 110);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 4;
            // 
            // txtF
            // 
            txtF.Location = new Point(300, 189);
            txtF.Name = "txtF";
            txtF.Size = new Size(125, 27);
            txtF.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtF);
            Controls.Add(txtX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTinh);
            Name = "Form1";
            Text = "bai3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtX;
        private TextBox txtF;
    }
}
