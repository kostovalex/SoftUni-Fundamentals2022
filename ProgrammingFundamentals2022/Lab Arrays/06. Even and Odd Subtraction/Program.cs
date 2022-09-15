using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumEven=0;
            int sumOdd=0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==0)
                {
                    sumEven += number[i];

                }
                else
                {
                    sumOdd+=number[i];
                }
            }
            Console.WriteLine($"{Math.Abs(sumEven) - (sumOdd)}");





        }
    }
}
