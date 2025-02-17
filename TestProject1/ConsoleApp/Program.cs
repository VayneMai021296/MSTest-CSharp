// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using ConsoleApp.Utilities;
namespace program
{
    public class Program
    {
        public static void Main()
        {
           
        }
        private Calculator _cal = null!;
        private List<Student> students = new List<Student>();
        private Random random = new Random();

        public Program()
        { 
            /* Khởi tạo class Calcultor với các phương thức Add, Subtract, Multiply, Device */
            _cal = new Calculator();

            /*Khởi tạo List Student với 1000 phần tử, Id random từ 1 đến 1000, Name random từ A-Z */
            for (int i = 0; i < 1000; i++)
            {
                var student = new Student() { Id = random.Next(1, 1000), Name = ((char)random.Next('A', 'Z')).ToString() };
                students.Add(student);
            }
        }
        public int CalculatorAdd(int a, int b)
        {
            return _cal.Add(a, b);
        }
        public int CalculatorDivece(int a, int b)
        {
            return _cal.Divide(a, b);
        }
        public void GroupByStudent()
        {
            /*
                                    Kiểu trả về của kết quả GroupBy là IGrouping<TKey, TElement> trong đó TKey là key của Group, TElement là các phần tử trong Group     
                                    Cụ thể hơn kiểu trả về là kiểu dữ liệu IGrouping<string, Student> mỗi phần tử trong Group được đại diện bằng key là string và các phần tử trong Group là Student
                               */
            var groupedStudents = students.GroupBy(s =>
            {
                if (s.Id <= 200) return "0-200";
                if (s.Id <= 400) return "201-400";
                if (s.Id <= 600) return "401-600";
                if (s.Id <= 800) return "601-800";
                return "801-1000";
            });

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Group {group.Key}: {group.Count()} students");
            }
        }
    }
}
