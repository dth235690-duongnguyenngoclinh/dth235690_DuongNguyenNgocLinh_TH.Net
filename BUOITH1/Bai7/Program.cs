using System;
using Bai7;  // namespace chứa class TamGiac

namespace Bai7Program
{
    class Program
    {
        static void Main()
        {
            // Cau hinh console de hien thi tieng Viet khong loi font
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bai 7: TamGiac ===");

            // Tao doi tuong TamGiac (3 canh tu nhap)
            TamGiac tg = new TamGiac();

            // Nhap canh tu ban phim (khong bat buoc)
            Console.Write("Nhap canh 1: ");
            tg.Canh1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh 2: ");
            tg.Canh2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh 3: ");
            tg.Canh3 = int.Parse(Console.ReadLine());

            // Tinh chu vi va dien tich
            tg.TinhChuVi();
            tg.TinhDienTich();

            // Hien thi thong tin
            tg.HienThi();

            Console.WriteLine("\nDa xong Bai 7!");
            Console.ReadLine(); // giu console
        }
    }
}
