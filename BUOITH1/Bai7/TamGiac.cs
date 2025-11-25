using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class TamGiac
    {
        private int canh1, canh2, canh3;

        public int Canh1 { get => canh1; set => canh1 = value; }
        public int Canh2 { get => canh2; set => canh2 = value; }
        public int Canh3 { get => canh3; set => canh3 = value; }

        public int ChuVi { get; private set; }
        public float DienTich { get; private set; }

        // Constructor không tham số
        public TamGiac() { canh1 = 2; canh2 = 3; canh3 = 4; }

        // Constructor 3 tham số
        public TamGiac(int a, int b, int c)
        {
            canh1 = a; canh2 = b; canh3 = c;
        }

        // Tính chu vi
        public void TinhChuVi() => ChuVi = canh1 + canh2 + canh3;

        // Tính diện tích theo công thức Heron
        public void TinhDienTich()
        {
            float p = ChuVi / 2f;
            DienTich = (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }

        // Hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine($"Cạnh: {canh1}, {canh2}, {canh3}");
            Console.WriteLine($"Chu vi: {ChuVi}, Diện tích: {DienTich}");
        }
    }
}
