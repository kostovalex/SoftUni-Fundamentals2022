using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0]!= "End")
            {               
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    listOfNumbers.Add(number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index>listOfNumbers.Count-1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfNumbers.Insert(index, number);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index > listOfNumbers.Count - 1 || index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfNumbers.RemoveAt(index);
                    }
                }
                else if (command[0] == "Shift")
                {
                    string direction = command[1];
                    int count = int.Parse(command[2]);
                    ShiftMethod(direction, count, listOfNumbers);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ",listOfNumbers));
        }

        static void ShiftMethod(string direction, int count, List<int> listOfNumbers)
        {
            if (direction=="left")
            {
                for (int i = 0; i < count; i++)
                {
                    listOfNumbers.Add(listOfNumbers[0]);
                    listOfNumbers.RemoveAt(0);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    listOfNumbers.Insert(0, listOfNumbers[listOfNumbers.Count - 1]);
                    listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                }
            }
        }
    }
}
