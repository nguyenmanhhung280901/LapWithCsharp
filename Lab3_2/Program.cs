using System;

namespace Lab3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Nguyen", "Hung", "Aptech", 20, 30000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculateTheBonus(2));
        }
    }
}