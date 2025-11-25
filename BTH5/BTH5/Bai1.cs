using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5 { 
    public partial class Bai1 : Form
    {
        private bool IsPrime(int n)
        {
            if (n < 2)
                return false; // Số nguyên tố phải >= 2

            // Chỉ cần lặp đến căn bậc hai của n
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false; // Có ước số, không phải số nguyên tố
            }
            return true; // Là số nguyên tố
        }
        public Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng có nhập số nguyên hợp lệ không
            if (int.TryParse(txtNhapN.Text, out int N))
            {
                // 2. Kiểm tra N có phải là SNT không
                if (IsPrime(N))
                {
                    txtKetQuaKT.Text = N + " là số nguyên tố"; // Ví dụ: 7 là số nguyên tố 
                }
                else
                {
                    txtKetQuaKT.Text = N + " không phải là số nguyên tố";
                }

                // 3. Tìm các SNT nhỏ hơn N
                string sntNhoHon = "";
                for (int i = 2; i < N; i++)
                {
                    if (IsPrime(i))
                    {
                        sntNhoHon += i + " ";
                    }
                }
                txtKetQuaTim.Text = sntNhoHon.Trim(); // Ví dụ: 2 3 5 
            }
            else
            {
                // Hiển thị thông báo nếu nhập không hợp lệ
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ cho N.", "Lỗi Nhập Liệu");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapN.Text = "";
            txtKetQuaKT.Text = "";
            txtKetQuaTim.Text = "";
            txtNhapN.Focus(); // Đặt con trỏ về ô nhập liệu
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form hiện tại
        }
    }
}
