using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

           OrdersCalculator(product, quantity);
        }

        static void OrdersCalculator(string product, int quantity)
        {
            if (product=="coffee")
            {
                Console.WriteLine($"{quantity * 1.50:f2}");
            }
            if (product == "water")
            {
                Console.WriteLine($"{quantity * 1.00:f2}");
            }
            if (product == "coke")
            {
                Console.WriteLine($"{quantity * 1.40:f2}");
            }
            if (product == "snacks")
            {
                Console.WriteLine($"{quantity * 2.00:f2}");
            }
        }
    }
}
