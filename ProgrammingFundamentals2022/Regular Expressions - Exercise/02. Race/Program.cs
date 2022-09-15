using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ");
            string patternName = @"(?<name>[A-Za-z]+)";
            string patternDist = @"(?<distance>[0-9])";
            Dictionary<string, int> finishers = new Dictionary<string, int>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }
                
                MatchCollection nameMatches = Regex.Matches(input, patternName);
                string name = string.Join("",nameMatches);
                
                MatchCollection distance = Regex.Matches(input, patternDist);
                int totalDistance = 0;
                foreach (var match in distance)
                {
                    totalDistance += int.Parse(match.ToString());
                }

                if (participants.Any(n => n==name))
                {
                    if (!finishers.ContainsKey(name))
                    {
                        finishers.Add(name, totalDistance);
                    }
                    else
                    {
                        finishers[name] += totalDistance;
                    }
                }
            }
            
            List<string> winners = TopThree(finishers);
            
            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }

        static List<string> TopThree(Dictionary<string,int> finishers)
        {
            finishers = finishers.OrderByDescending(n => n.Value).ToDictionary(n => n.Key, n => n.Value);
            List<string> winners = new List<string>();
            foreach (var item in finishers)
            {
                winners.Add(item.Key);
            }
            return winners;
        }
    }
}
