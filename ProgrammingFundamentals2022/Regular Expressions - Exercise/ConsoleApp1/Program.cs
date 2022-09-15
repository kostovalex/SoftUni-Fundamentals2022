using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^\|\.\$\%]*%(?<name>[A-Z][a-z]+)%[^\|\.\$\%]*<(?<product>\w+)>[^\|\.\$\%]*\|(?<count>[0-9]+)\|[^\|\.\$\%\d]*(?<price>\d+(.\d+)?)\$";
            decimal income = 0;
            
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input== "end of shift")
                {
                    break;
                }
                
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    decimal totalPrice = decimal.Parse(match.Groups["count"].Value) * decimal.Parse(match.Groups["price"].Value);
                    income += totalPrice;
                    
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
