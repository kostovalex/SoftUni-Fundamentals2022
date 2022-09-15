using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<char, int> charByOccurence = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!charByOccurence.Keys.Contains(character) && character != ' ')
                {
                    charByOccurence.Add(character, 1);
                }
                else
                {
                    if (character != ' ')
                    {
                        charByOccurence[character]++;
                    }
                }
            }

            foreach (var character in charByOccurence)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
