using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddMethod(a, b);
                    break;
                case "multiply":
                    MultiplyMethod(a, b);
                    break;
                case "subtract":
                    SubtractMethod(a, b);
                    break;
                case "divide":
                    DivideMethod(a, b);
                    break;
            }
        }

        static void AddMethod(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void MultiplyMethod(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void SubtractMethod(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void DivideMethod(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
