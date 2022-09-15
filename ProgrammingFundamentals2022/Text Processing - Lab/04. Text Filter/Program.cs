using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string replacement = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    replacement += "*";
                }
                
                text = text.Replace(word, replacement);
            }
            
            Console.WriteLine(text);

        }
    }
}
