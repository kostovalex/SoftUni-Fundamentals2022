using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Read two integers.Calculate the factorial of each number. 
            //    Divide the first result by the second and print the result
            //    of the division formatted to the second decimal point.
            decimal firstInt = decimal.Parse(Console.ReadLine());
            decimal secondInt = decimal.Parse(Console.ReadLine());

            decimal firstFactorial = FactorialCalculator(firstInt);
            decimal secondFactorial = FactorialCalculator(secondInt);

            if (firstInt == 0)
            {
                firstFactorial = 1;
            }
            if (secondInt == 0)
            {
                secondFactorial = 1;
            }
            Console.WriteLine($"{firstFactorial/secondFactorial:f2}");
            

        }

        private static decimal FactorialCalculator(decimal number)
        {
            decimal factorial = number;
            for (int i = (int)number; i > 1; i--)
            {
                factorial *= (i - 1);
            }
            return factorial;
        }
    }
}
