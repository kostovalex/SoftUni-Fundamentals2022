using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> boughtFurniture = new List<string>();
            string pattern = @"\B>>(?<item>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)\b";
            decimal sum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                
                if (regex.Match(input).Success && match.Groups["quantity"].Value!="0")
                {
                    string name = match.Groups["item"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value) * decimal.Parse(match.Groups["quantity"].Value);
                    sum += price;
                    boughtFurniture.Add(name);
                }
            }
            
            Console.WriteLine("Bought furniture:");
            foreach (var item in boughtFurniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
