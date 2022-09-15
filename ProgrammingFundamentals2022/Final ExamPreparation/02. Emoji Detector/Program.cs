using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(?<opening>[*]{2}|[:]{2})(?<emoji>[A-Z]{1}[a-z]{2,})(\k<opening>)";

            string input = Console.ReadLine();
            
            long coolTreshold = 1;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = int.Parse(input[i].ToString());
                    coolTreshold *= digit;
                }
            }

            MatchCollection matches = Regex.Matches(input, emojiPattern);
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in matches)
            {
                long coolness = 0;
                string emoji = match.Groups["emoji"].Value;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += (int)emoji[i];
                }

                if (coolness>=coolTreshold)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
