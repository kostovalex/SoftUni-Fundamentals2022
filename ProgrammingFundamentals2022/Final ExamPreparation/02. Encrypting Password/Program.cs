using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<start>.+)\>(?<groupOne>[0-9]{3})\|(?<groupTwo>[a-z]{3})\|(?<groupThree>[A-Z]{3})\|(?<groupFour>[^<>]{3})\<(\k<start>)";
            
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string password = Console.ReadLine();

                if (Regex.IsMatch(password, pattern))
                {
                    Match match = Regex.Match(password, pattern);
                    string first = match.Groups["groupOne"].Value;
                    string second = match.Groups["groupTwo"].Value;
                    string third = match.Groups["groupThree"].Value;
                    string fourth = match.Groups["groupFour"].Value;

                    string final = first + second + third + fourth;
                    Console.WriteLine($"Password: {final}");    
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }

        }
    }
}
