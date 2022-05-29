  using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;
            for (int i = 1; i <= n; i++)
            {
                int waterTransh = int.Parse(Console.ReadLine());
                capacity += waterTransh;
                if (capacity>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity -= waterTransh;
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
