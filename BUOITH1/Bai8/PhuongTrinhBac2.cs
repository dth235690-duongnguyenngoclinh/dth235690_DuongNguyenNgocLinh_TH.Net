using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class PhuongTrinhBac2
    {
        public int SoA { get; set; }
        public int SoB { get; set; }
        public int SoC { get; set; }

        // Constructor không tham số
        public PhuongTrinhBac2() { }

        // Constructor 3 tham số
        public PhuongTrinhBac2(int a, int b, int c)
        {
            SoA = a; SoB = b; SoC = c;
        }

        // Tính nghiệm
        public void TinhNghiem()
        {
            if (SoA == 0)
            {
                Console.WriteLine("Không phải phương trình bậc 2");
                return;
            }

            double delta = SoB * SoB - 4 * SoA * SoC;

            if (delta < 0) Console.WriteLine("Phương trình vô nghiệm");
            else if (delta == 0)
            {
                double x = -SoB / (2.0 * SoA);
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
            }
            else
            {
                double x1 = (-SoB + Math.Sqrt(delta)) / (2.0 * SoA);
                double x2 = (-SoB - Math.Sqrt(delta)) / (2.0 * SoA);
                Console.WriteLine($"Phương trình có 2 nghiệm: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
