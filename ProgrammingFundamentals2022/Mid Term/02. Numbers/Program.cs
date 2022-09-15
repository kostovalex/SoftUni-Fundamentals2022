using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0]!= "Finish")
            {
                if (command[0] == "Add")
                {
                    int value = int.Parse(command[1]);
                    numbersSequence.Add(value);
                }
                else if (command[0] == "Remove")
                {
                    int value = int.Parse(command[1]);
                    numbersSequence.Remove(value);
                }
                else if (command[0] == "Replace")
                {
                    int value = int.Parse(command[1]);
                    int replacement = int.Parse(command[2]);
                    if (numbersSequence.Contains(value))
                    {
                        
                        numbersSequence.Insert(numbersSequence.FindIndex(n => n == value), replacement);
                        numbersSequence.Remove(value);
                    }
                }
                else if (command[0] == "Collapse")
                {
                    int value = int.Parse(command[1]);
                    numbersSequence.RemoveAll(n=> n<value);
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbersSequence));
        }
    }
}
