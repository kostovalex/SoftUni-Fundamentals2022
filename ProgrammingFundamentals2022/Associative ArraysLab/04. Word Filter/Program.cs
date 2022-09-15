using System;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in arrayOfStrings)
            {
                if (word.Length%2==0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
