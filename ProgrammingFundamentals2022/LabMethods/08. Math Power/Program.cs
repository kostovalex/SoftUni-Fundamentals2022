using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basis = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(PowerCalculator(basis,power));
        }
        static double PowerCalculator(double basis, double power)
        {
            double result = basis;
            for (int i = 0; i <= power-2; i++)
            {
                result *=  basis;
            }
            return result;
        }
    }
}
