using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0]!= "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    Merge(startIndex, endIndex, input);
                }
                else if (command[0] == "divide")
                {

                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static void Merge(int startIndex, int endIndex, List<string> input)
        {
            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
            }
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex > endIndex)
            {
                startIndex = endIndex - (endIndex - startIndex);
            }
            List <string> temp = new List<string>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                temp.Add(input[i]);
            }

            input.RemoveRange(startIndex, endIndex - startIndex +1);
            input.Insert(startIndex, string.Join("", temp));
        }
    }
}
