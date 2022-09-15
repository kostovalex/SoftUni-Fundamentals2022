using System;

namespace demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
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
        }
    }
}
