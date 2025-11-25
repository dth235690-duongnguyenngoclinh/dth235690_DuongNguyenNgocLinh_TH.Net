using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class TamGiac
    {
        //thuoc tinh
        private int canh1;
        private int canh2;
        private int canh3;
        private string loaiTamGiac;
        private float dienTich;
        private int chuVi;

        //property
        public int Canh1
        {
            get { return canh1; }
            set { canh1 = value; }
        }
        public int Canh2
        {
            get { return canh2; }
            set { canh2 = value; }
        }
        public int Canh3
        {
            get { return canh3; }
            set { canh3 = value; }
        }
        public int ChuVi
        {
            get { return chuVi; }
        }

        public float DienTich
        {
            get { return dienTich; }
        }

        public string LoaiTamGiac
        {
            get { return loaiTamGiac; }
        }

        //phuong thuc khoi tao khong tham so
        public TamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = -5;
            TinhChuVi();
            TinhDienTich();
            XacDinhLoaiTamGiac();
        }

        //phuong thuc khoi tao co tham so
        public TamGiac(int a, int b, int c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
            TinhChuVi();
            TinhDienTich();
            XacDinhLoaiTamGiac();
        }

        //kiem tra tam giac hop le
        public bool LaTamGiac()
        {
            return (canh1 + canh2 > canh3) &&
                    (canh1 + canh3 > canh2) &&
                    (canh2 + canh3 > canh1);
        }

        //tinh chu vi
        public void TinhChuVi()
        {
            if (LaTamGiac())
            {
                chuVi = canh1 + canh2 + canh3;
            }
            else
            {
                chuVi = 0;
            }
        }

        //tinh dien tich
        public void TinhDienTich()
        {
            if (LaTamGiac())
            {
                float p = chuVi / 2.0f;
                dienTich = (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
            }
            else
            {
                dienTich = 0;
            }
        }

        //xac dinh loai tam giac
        public void XacDinhLoaiTamGiac()
        {
            if (!LaTamGiac())
            {
                loaiTamGiac = "Khong phai tam giac";
            }
            else if (canh1 == canh2 && canh2 == canh3)
            {
                loaiTamGiac = "Tam giác đều";
            }
            else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
            {
                loaiTamGiac = "Tam giác cân";
            }
            else if (canh1 * canh1 + canh2 * canh2 == canh3 * canh3 ||
                     canh1 * canh1 + canh3 * canh3 == canh2 * canh2 ||
                     canh2 * canh2 + canh3 * canh3 == canh1 * canh1)
            {
                loaiTamGiac = "Tam giác vuông";
            }
            else
            {
                loaiTamGiac = "Tam giác thường";
            }
        }

        //hien thi thong tin tam giac
        public void HienThiThongTin()
        {
            Console.Write("\n=== Thông tin tam giác ===\n");
            Console.WriteLine("Canh 1: {0}", canh1);
            Console.WriteLine("Canh 2: {0}", canh2);
            Console.WriteLine("Canh 3: {0}", canh3);

            if (LaTamGiac())
            {
                Console.WriteLine("Chu vi: {0}", chuVi);
                Console.WriteLine("Dien tich: {0}", dienTich);
                Console.WriteLine("Loai tam giac: {0}", loaiTamGiac);
            }
            else
            {
                Console.WriteLine("Loai tam giac: {0}", loaiTamGiac);
            }
            Console.WriteLine("--------------------------");
        }
    }
}
