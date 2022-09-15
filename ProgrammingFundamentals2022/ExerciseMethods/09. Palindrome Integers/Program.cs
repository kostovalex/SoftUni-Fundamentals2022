using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int[] arrayOfNumbers = new int[input.Length];
                int number = int.Parse(input);
                int currentNum = 0;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    currentNum = number % 10;
                    arrayOfNumbers[i] = currentNum;
                    number /= 10;
                }
                
                bool isItPalindrome = PalindromeMethod(input, arrayOfNumbers);
                Console.WriteLine(isItPalindrome);                
                input = Console.ReadLine();
            }
        }

        private static bool PalindromeMethod(string input, int[] arrayOfNumbers)
        {
            int[] newArray = new int[arrayOfNumbers.Length];

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (arrayOfNumbers[i] != arrayOfNumbers[arrayOfNumbers.Length - 1 - i])
                {
                    return false;
                }               
            }
            return true;
        }
    }
}
