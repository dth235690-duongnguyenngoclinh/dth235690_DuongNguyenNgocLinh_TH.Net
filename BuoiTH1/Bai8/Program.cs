namespace Bai8
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Sử dụng constructor mặc định
            PTBacHai pt1 = new PTBacHai();
            pt1.HienThiKetQua();
            pt1.TinhNghiem();

            Console.WriteLine();

            // Constructor có nghiệm phân biệt
            PTBacHai pt2 = new PTBacHai(1, -3, 2);
            pt2.HienThiKetQua();
            pt2.TinhNghiem();

            Console.WriteLine();

            // Constructor có nghiệm phức
            PTBacHai pt3 = new PTBacHai(1, 2, 5);
            pt3.HienThiKetQua();
            pt3.TinhNghiem();
        }
    }
}