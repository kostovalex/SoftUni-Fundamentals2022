using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] someNumbers = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                someNumbers[i] = number;
            }
            
            for (int i = someNumbers.Length -1; i >= 0; i--)
            {
                Console.Write($"{someNumbers[i]} ");
            }
        }
    }
}
