using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputOne= Console.ReadLine();
            string[] arrayOne = inputOne.Split();
            string inputTwo = Console.ReadLine();
            string[] arrayTwo = inputTwo.Split();
            
            foreach (var element in arrayOne)
            {
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    if (element==arrayTwo[i])
                    {
                        Console.Write($"{element} ");
                        break;
                    }
                }
            }

        }
    }
}
