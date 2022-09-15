using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex rg = new Regex(pattern);

            MatchCollection matches = rg.Matches(input);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
