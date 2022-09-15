using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string letters = string.Empty;
            string digits = string.Empty;
            string sonst = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else if (char.IsDigit(input[i]))
                {
                    digits += input[i];
                }
                else
                {
                    sonst += input[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(sonst);
        }

    }
}
