using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();
            string[] stringArray = numbersAsString.Split(' ');
            double[] doubleArray = new double[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                doubleArray[i] = double.Parse(stringArray[i]);
            }
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine($"{doubleArray[i]} => {(int)Math.Round(doubleArray[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
