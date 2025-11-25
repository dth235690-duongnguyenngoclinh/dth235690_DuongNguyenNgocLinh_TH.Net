using Bai6;

class Program
{
    static void Main()
    {
        // Cau hinh console UTF-8 de hien thi tieng Viet co dau
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Bài 6: Employee ==="); // giữ nguyên chữ Bài
        Employee.SetBasicSalary(5000); // thiết lập lương cơ bản
        Employee emp = new Employee();
        emp.Input();
        emp.Display();
    }
}
