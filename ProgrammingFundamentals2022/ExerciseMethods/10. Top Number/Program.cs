using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());

            for (int i = 1; i < endValue; i++)
            {
                int currentNumber = i;
                bool isItDivisible = IsItDivisible(endValue,currentNumber);
                bool isThereOddDigit = IsThereOddDigit(endValue, currentNumber);
                if (isItDivisible&& isThereOddDigit)
                {
                    Console.WriteLine(currentNumber);
                }
            }

        }

        static bool IsThereOddDigit(int endValue, int currentNumber)
        {
            int currentDigit = 0;
            while (currentNumber != 0)
            {
                currentDigit = currentNumber % 10;
                if (currentDigit%2!=0)
                {
                    return true;
                }
                currentNumber /= 10;
            }
            return false;
        }

        static bool IsItDivisible(int endValue, int currentNumber)
        {
            int currentSum = 0;
            while (currentNumber != 0)
            {
                currentSum += currentNumber % 10;
                currentNumber /= 10;
            }
            if (currentSum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
