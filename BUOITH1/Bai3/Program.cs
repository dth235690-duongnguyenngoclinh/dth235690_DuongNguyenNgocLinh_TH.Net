using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            GiaiThuaN gtn = new GiaiThuaN();
            Console.Write("Nhap so n = ");
            n = gtn.NhapMotSo();
            Console.WriteLine("Gai thua cua {0} la {1}", n, gtn.TinhGiaiThuaN(n));
            Console.ReadLine();
        }
    }
}