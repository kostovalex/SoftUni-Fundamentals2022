using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string crypted = string.Empty;
            

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i] + 3;
                crypted += (char)current;
            }
            Console.WriteLine(crypted);
        }
    }
}
