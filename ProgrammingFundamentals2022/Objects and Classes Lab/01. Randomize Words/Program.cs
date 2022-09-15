using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Random random = new Random();
            
            for (int i = 0; i < input.Count - 1; i++)
            {
                int randomIndex = random.Next(0, input.Count);
                string temp = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] = temp;
            }
            foreach (string word in input)
            {
                Console.WriteLine(word);
            }
        }
    }

   
}
