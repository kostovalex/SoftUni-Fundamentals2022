using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(input, times));
        }
        static string StringRepeater(string input, int times)
        {
            string result = string.Empty;
            for (int i = 1; i <= times; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
