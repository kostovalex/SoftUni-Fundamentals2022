using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharactersPrinter(first, second);
        }

        static void CharactersPrinter(char first, char second)
        {
            if ((int)first < (int)second)
            {
                int beginning = (int)first;
                int end = (int)second;
                for (int i = beginning + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                int beginning = (int)second;
                int end = (int)first;
                for (int i = beginning +1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
