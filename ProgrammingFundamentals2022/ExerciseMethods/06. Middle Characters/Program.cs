using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = MiddleFingerMethod(input);
            Console.WriteLine(output);
        }

        private static string MiddleFingerMethod(string input)
        {
            string output = string.Empty;
            int length = input.Length;
            if (length%2==00)
            {
                for (int i = length/2-1; i < length/2+1; i++)
                {
                    output+= input[i];
                }
                return output;
            }
            else
            {
                for (int i = length / 2; i < length/2+1; i++)
                {
                    output += input[i];
                }
                return output;
            }
        }
    }
}
