using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsByOccurance = new Dictionary<string, int>();

            string[] arrayOfWords = Console.ReadLine().Split(' ', StringSplitOptions.None);

            foreach (var word in arrayOfWords)
            {
                string wordLow = word.ToLower();

                if (!wordsByOccurance.Keys.Contains(wordLow))
                {
                    wordsByOccurance.Add(wordLow, 0);
                }
                wordsByOccurance[wordLow]++;
            }

            foreach (var word in wordsByOccurance)
            {
                if (word.Value%2!=0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
