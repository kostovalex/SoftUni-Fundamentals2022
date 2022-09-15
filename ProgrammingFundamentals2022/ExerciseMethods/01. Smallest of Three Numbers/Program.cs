using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            NumberChecker(first, second, third);
        }

        static void NumberChecker(int first, int second, int third)
        {
            int currentSmallest = int.MaxValue;
            if (first <= currentSmallest)
            {
                currentSmallest = first;
            }
            if (second <= currentSmallest)
            {
                currentSmallest = second;
            }
            if (third <= currentSmallest)
            {
                currentSmallest = third;
            }
            Console.WriteLine(currentSmallest);
        }
    }
}
