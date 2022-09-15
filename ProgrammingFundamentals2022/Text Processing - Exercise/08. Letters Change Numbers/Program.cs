using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentCombo = input[i];
                char firstLetter = currentCombo[0];
                char secondLetter = currentCombo[currentCombo.Length-1];
                
                currentCombo = currentCombo.Remove(0, 1);
                currentCombo = currentCombo.Remove(currentCombo.Length - 1, 1);
                decimal number = decimal.Parse(currentCombo);

                if (char.IsUpper(firstLetter))
                {
                    if (char.IsUpper(secondLetter))
                    {
                        sum += (number / ((int)firstLetter % 32)) - ((int)secondLetter % 32);
                    }
                    else if (char.IsLower(secondLetter))
                    {
                        sum += (number / ((int)firstLetter % 32)) + ((int)secondLetter % 32);
                    }
                }
                else if (char.IsLower(firstLetter))
                {
                    if (char.IsUpper(secondLetter))
                    {
                        sum += (number * ((int)firstLetter % 32)) - ((int)secondLetter % 32);
                    }
                    else if (char.IsLower(secondLetter))
                    {
                        sum += (number * ((int)firstLetter % 32)) + ((int)secondLetter % 32);
                    }
                }
                
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
