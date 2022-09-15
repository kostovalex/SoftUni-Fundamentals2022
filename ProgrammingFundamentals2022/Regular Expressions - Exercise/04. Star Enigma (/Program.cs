using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countPattern = @"[sStTaArR]";
            string messagePattern = @"@(?<planetName>[A-Za-z]+)[^\@\-\:\!\>]*:(?<population>\d+)[^\@\-\:\!\>]*!(?<attackType>[A-Z]{1})![^\@\-\:\!\>]*->(?<soldierCount>\d+)";
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, countPattern);

                int code = matches.Count;
                string message = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    message += (char)((int)input[j] - code);
                }


                if (Regex.IsMatch(message, messagePattern))
                {
                    Match matchPlanets = Regex.Match(message, messagePattern);
                    string name = matchPlanets.Groups["planetName"].Value;
                    string status = matchPlanets.Groups["attackType"].Value;

                    if (status == "D")
                    {
                        destroyedPlanets.Add(name);
                    }
                    else if (status == "A")
                    {
                        attackedPlanets.Add(name);
                    }
                }
            }
            
            attackedPlanets = attackedPlanets.OrderBy(n => n).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(n => n).ToList();
            
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}


