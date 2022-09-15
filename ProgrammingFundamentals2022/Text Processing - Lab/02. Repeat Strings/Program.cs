using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string element in input)
            {
                for (int i = 1; i <= element.Length; i++)
                {
                    result.Append(element);
                }
            }

            Console.WriteLine(result);
        }
    }
}
