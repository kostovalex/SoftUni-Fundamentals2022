using System;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeesCount = int.Parse(Console.ReadLine());
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
