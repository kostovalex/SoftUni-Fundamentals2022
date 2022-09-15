using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[@](?<wordOne>[A-Za-z]{3,})[@]{2}(?<wordTwo>[A-Za-z]{3,})[@]|[#](?<wordOne>[A-Za-z]{3,})[#]{2}(?<wordTwo>[A-Za-z]{3,})[#]";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();
            
            foreach (Match match in matches)
            {
                string wordOne = match.Groups["wordOne"].Value;
                string wordTwo = match.Groups["wordTwo"].Value;
                bool isSame = true;
                
                if (wordOne.Length!=wordTwo.Length)
                {
                    isSame = false;
                    break;
                }
                else
                {
                    for (int i = 0; i < wordOne.Length; i++)
                    {
                        if (wordOne[i] != wordTwo[wordOne.Length-1-i])
                        {
                            isSame = false;
                            break;
                        }
                    }
                }

                if (isSame)
                {
                    mirrorWords.Add(wordOne, wordTwo);
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                if (mirrorWords.Count==0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");

                    List<string> words = new List<string>();
                    foreach (var item in mirrorWords)
                    {
                        words.Add($"{item.Key} <=> {item.Value}");
                    }

                    Console.WriteLine(string.Join(", ", words));
                } 
            }
            
        }
    }
}
