using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            VowelsCounter(input);
        }

        static void VowelsCounter(string input)
        {

            int counter = 0;
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                char currentChar = input[i];
                if (currentChar == 'a' || currentChar == 'A')
                {
                    counter++;
                }
                else if (currentChar == 'o' || currentChar == 'O')
                {
                    counter++;
                }
                else if (currentChar == 'e' || currentChar == 'E')
                {
                    counter++;
                }
                else if (currentChar == 'i' || currentChar == 'I')
                {
                    counter++;
                }
                else if (currentChar == 'u' || currentChar == 'U')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
