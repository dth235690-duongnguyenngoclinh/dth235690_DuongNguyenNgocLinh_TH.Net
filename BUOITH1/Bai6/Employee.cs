using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Employee

    {
        // Thuộc tính dữ liệu
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;

        // Lương cơ bản dùng chung cho tất cả nhân viên
        public static double basicSalary;

        // Getter
        public int GetId() => id;
        public string GetName() => name;
        public int GetYearOfBirth() => yearOfBirth;

        // Tính thu nhập
        public double GetIncome() => salaryLevel * basicSalary;

        // Nhập dữ liệu
        public void Input()
        {
            Console.Write("Nhập ID: "); id = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên: "); name = Console.ReadLine();
            Console.Write("Nhập năm sinh: "); yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Nhập bậc lương: "); salaryLevel = double.Parse(Console.ReadLine());
        }

        // Hiển thị dữ liệu
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Tên: {name}, Năm sinh: {yearOfBirth}, Lương cơ bản: {basicSalary}, Thu nhập: {GetIncome()}");
        }

        // Thiết lập bậc lương
        public void SetSalaryLevel(double level) => salaryLevel = level;

        // Thiết lập lương cơ bản (static)
        public static void SetBasicSalary(double salary) => basicSalary = salary;
    }
}
