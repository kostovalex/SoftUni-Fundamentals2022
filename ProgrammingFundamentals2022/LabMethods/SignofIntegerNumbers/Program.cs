using System;

namespace SignofIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NumberChecker(n);
        }

        static void NumberChecker(int n)
        {
            if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n>0)   
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n==0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }

    }
}
