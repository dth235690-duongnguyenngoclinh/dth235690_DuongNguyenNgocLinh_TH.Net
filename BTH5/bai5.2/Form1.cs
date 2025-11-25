using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        private bool IsPerfectNumber(int n)
        {
            // 1. Số hoàn hảo phải là số nguyên dương và lớn hơn 1 (số hoàn hảo nhỏ nhất là 6)
            if (n <= 1) return false;

            // 2. Tính tổng các ước số thực sự
            int sumOfDivisors = 0;

            // Ước số thực sự nhỏ nhất là 1. Ước số lớn nhất không quá n/2.
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            // 3. Nếu tổng các ước số bằng chính nó, thì là số hoàn hảo
            return sumOfDivisors == n;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTraHoanHao_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (int.TryParse(txtNhapN.Text, out int N))
            {
                // Đảm bảo N là số dương
                if (N <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương.", "Lỗi Nhập Liệu");
                    return;
                }

                // 2. Gọi hàm kiểm tra và chuẩn bị thông báo
                string message;
                if (IsPerfectNumber(N))
                {
                    message = $"{N} là SỐ HOÀN HẢO. (Tổng các ước số thực sự = {N})";
                }
                else
                {
                    message = $"{N} không phải là số hoàn hảo.";
                }

                // 3. Hiển thị kết quả trên MessageBox
                MessageBox.Show(message, "Kiểm Tra Số Hoàn Hảo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.", "Lỗi Định Dạng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
