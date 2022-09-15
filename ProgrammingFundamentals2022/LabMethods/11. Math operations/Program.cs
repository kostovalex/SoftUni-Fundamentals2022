using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(firstNumber, @operator, secondNumber));
        }
        static double Calculator(double firstNumber, string @operator, double secondNumber)
        {
            double result = 0;
            if (@operator == "/")
            {
                result = firstNumber / secondNumber;
                return result;
            }
            else if (@operator == "*")
            {
                result = firstNumber * secondNumber;
                return result;
            }
            else if (@operator == "+")
            {
                result = firstNumber + secondNumber;
                return result;
            }
            else
            {
                result = firstNumber - secondNumber;
                return result;
            }
        }
    }
}
