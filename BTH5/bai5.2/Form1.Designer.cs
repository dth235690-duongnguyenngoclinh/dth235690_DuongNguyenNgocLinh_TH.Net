namespace bai5._2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.btnKiemTraHoanHao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(585, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM TRA SHH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập N:";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(492, 187);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(492, 26);
            this.txtNhapN.TabIndex = 2;
            // 
            // btnKiemTraHoanHao
            // 
            this.btnKiemTraHoanHao.Location = new System.Drawing.Point(372, 342);
            this.btnKiemTraHoanHao.Name = "btnKiemTraHoanHao";
            this.btnKiemTraHoanHao.Size = new System.Drawing.Size(205, 36);
            this.btnKiemTraHoanHao.TabIndex = 3;
            this.btnKiemTraHoanHao.Text = "Kiểm tra hoàn hảo";
            this.btnKiemTraHoanHao.UseVisualStyleBackColor = true;
            this.btnKiemTraHoanHao.Click += new System.EventHandler(this.btnKiemTraHoanHao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(781, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(205, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 845);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKiemTraHoanHao);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KT SHH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.Button btnKiemTraHoanHao;
        private System.Windows.Forms.Button btnThoat;
    }
}

