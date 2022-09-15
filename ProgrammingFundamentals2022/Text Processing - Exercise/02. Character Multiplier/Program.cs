using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            string str1 = input[0];
            string str2 = input[1];

            Console.WriteLine(CharMultiplier(str1, str2));
        }

        public static int CharMultiplier(string str1, string str2)
        {
            int sum = 0;
            string longer = string.Empty;
            string shorter = string.Empty;
            
            if (str1.Length > str2.Length)
            {
                longer = str1;
                shorter = str2;
            }
            else
            {
                longer = str2;
                shorter = str1;
            }

            for (int i = 0; i < shorter.Length; i++)
            {
                sum += shorter[i] * longer[i];
            }

            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }

            return sum;
        }
    }
}
