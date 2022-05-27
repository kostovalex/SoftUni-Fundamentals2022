using System;

namespace PoundstoDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());

            double dollar = pound * 1.31;

            Console.WriteLine($"{dollar:f3}");
        }
    }
}
