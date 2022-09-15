using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                LinePrinter(1, i);
            }
            for (int i = length-1; i > 0; i--)
            {
                LinePrinter(1, i);
            }
        }
        static void LinePrinter(int start, int length)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
