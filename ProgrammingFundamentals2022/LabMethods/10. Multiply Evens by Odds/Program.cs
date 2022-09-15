using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdd);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvenAndOdds(int sumOfEven, int sumOfOdd)
        {
            int result = 0;
            result = sumOfEven * sumOfOdd;
            return result;

        }
        static int GetSumOfEvenDigits(int number)
        {

            int sumOfEven = 0;
            int currentNumber = 0;
            while (number != 0)
            {
                currentNumber = number % 10;
                if (currentNumber % 2 == 0)
                {
                    sumOfEven += currentNumber;
                }
                number /= 10;
            }
            return sumOfEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdd = 0;
            int currentNumber = 0;
            while (number != 0)
            {
                currentNumber = number % 10;
                if (currentNumber % 2 != 0)
                {
                    sumOfOdd += currentNumber;
                }
                number /= 10;
            }
            return sumOfOdd;
        }

    }
}
