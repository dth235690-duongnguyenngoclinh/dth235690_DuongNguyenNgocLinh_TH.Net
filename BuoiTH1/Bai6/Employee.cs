using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private int _yearOfBirth;
        private double _salaryLevel;
        private static double _basicSalary;

        //phuong thuc khoi tao khong tham so
        public Employee()
        {
            _id = 0;
            _name = "";
            _yearOfBirth = 1900;
            _salaryLevel = 1;
        }

        //property
        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetYearOfBirth()
        {
            return _yearOfBirth;
        }
        public double GetIncome()
        {
            return _salaryLevel * _basicSalary;
        }

        //nhap, xuat
        public void Input()
        {
            Console.Write("Nhập ID: ");
            _id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tên nhân viên: ");
            string? inputName = Console.ReadLine();
            _name = inputName ?? string.Empty;

            Console.Write("Nhập năm sinh: ");
            _yearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập bậc lương: ");
            _salaryLevel = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("\n=== Thông tin nhân viên ===");
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Tên: {0}", _name);
            Console.WriteLine("Năm sinh: {0}", _yearOfBirth);
            Console.WriteLine("Bậc lương: {0}", _salaryLevel);
            Console.WriteLine("Lương cơ bản: {0}", _basicSalary);
            Console.WriteLine("Thu nhập: {0}", GetIncome());
            Console.WriteLine("===========================");
        }

        //
        public void SetSalaryLevel(double level)
        {
            _salaryLevel = level;
        }

        public static void SetBasicSalary(double basic)
        {
            _basicSalary = basic;
        }
    }
}
