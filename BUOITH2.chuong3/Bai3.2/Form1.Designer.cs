namespace Bai3._2
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
            btnThongBao = new Button();
            label1 = new Label();
            txtThang = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(313, 174);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(94, 29);
            btnThongBao.TabIndex = 0;
            btnThongBao.Text = "Thong Bao";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 47);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "MUA TRONG NAM";
            // 
            // txtThang
            // 
            txtThang.Location = new Point(344, 116);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(125, 27);
            txtThang.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 116);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Thang:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtThang);
            Controls.Add(label1);
            Controls.Add(btnThongBao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThongBao;
        private Label label1;
        private TextBox txtThang;
        private Label label2;
    }
}
