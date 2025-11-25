using System.Text;

namespace Bai6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập lương căn bản: ");
            double basic = Convert.ToDouble(Console.ReadLine());
            Employee.SetBasicSalary(basic);
            //Employee.SetBasicSalary(2000000);
            Employee emp = new Employee();
            emp.Input();
            emp.Display();
        }
    }
}