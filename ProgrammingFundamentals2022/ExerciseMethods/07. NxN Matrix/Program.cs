using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Printer(n);
                Console.WriteLine();
            }
        }

        private static void Printer(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(n + " ");
            }
        }
    }
}
