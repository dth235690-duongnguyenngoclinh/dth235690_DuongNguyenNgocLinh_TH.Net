using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN sln = new TimSLN();
            int n;
            Console.Write("Nhap n = ");
            n = sln.NhapMotSo();
            Console.WriteLine("So lon nhat trong {0} so vua nhap la {1}", n, sln.TimMax(n));
            Console.ReadLine();
        }
    }
}