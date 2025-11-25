using System;
using Bai8;  // namespace chứa class PhuongTrinhBac2

namespace Bai8Program
{
    class Program
    {
        static void Main()
        {
            // Cau hinh console hien thi tieng Viet khong loi font
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bai 8: PhuongTrinhBac2 ===");

            // Tao doi tuong PhuongTrinhBac2 (có the nhap tu ban phim)
            PhuongTrinhBac2 pt = new PhuongTrinhBac2();

            Console.Write("Nhap he so A: ");
            pt.SoA = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so B: ");
            pt.SoB = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so C: ");
            pt.SoC = int.Parse(Console.ReadLine());

            // Tinh nghiem
            pt.TinhNghiem();

            Console.WriteLine("\nDa xong Bai 8!");
            Console.ReadLine(); // giu console
        }
    }
}
