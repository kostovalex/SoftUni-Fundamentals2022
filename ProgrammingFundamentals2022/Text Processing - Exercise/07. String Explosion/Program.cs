using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //abv>>>>dasd
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
  
                if (input[i].ToString() == ">")
                {
                    power += int.Parse(input[i + 1].ToString());
                    input = input.Remove(i + 1, 1);
                    power--;
                }
                else if (power>0)
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
