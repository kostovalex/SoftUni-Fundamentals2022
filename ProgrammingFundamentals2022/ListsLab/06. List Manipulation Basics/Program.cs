using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(" ");
            bool hasChanged=false;
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int number =int.Parse(command[1]);
                    integersList.Add(number);
                    hasChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    integersList.RemoveAll(n=>n == number);
                    hasChanged = true;
                }
                else if(command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    integersList.RemoveAt(index);
                    hasChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    integersList.Insert(index, number);
                    hasChanged = true;
                }
                else if (command[0] == "Contains")
                {
                    int number = int.Parse(command[1]);
                    ContainMethod(integersList, number);
                }
                else if (command[0] == "PrintEven"|| command[0] == "PrintOdd")
                {
                    PrintEvenOrOdd(integersList, command);
                }
                else if (command[0] == "GetSum")
                {
                    int sum = 0;
                    foreach (int integer in integersList)
                    {
                        sum += integer;
                    }
                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {
                    string condition = command[1];
                    int number =int.Parse(command[2]);
                    ConditionChecker(integersList, condition, number);
                }

                command = Console.ReadLine().Split(" ");
            }
            if (hasChanged)
            {
                Console.WriteLine(String.Join(" ", integersList));
            }
           
        }

        private static void ConditionChecker(List<int> integersList, string condition, int number)
        {
            if (condition == "<")
            {
                foreach (int integer in integersList)
                {
                    if (integer < number)
                    {
                        Console.Write(integer + " ");
                    }
                }
                Console.WriteLine();    
            }
            else if (condition == ">")
            {
                foreach (int integer in integersList)
                {
                    if (integer > number)
                    {
                        Console.Write(integer + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == "<=")
            {
                foreach (int integer in integersList)
                {
                    if (integer <= number)
                    {
                        Console.Write(integer + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                foreach (int integer in integersList)
                {
                    if (integer >= number)
                    {
                        Console.Write(integer + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void PrintEvenOrOdd(List<int> integersList, string[] command)
        {
            if (command[0] == "PrintEven")
            {
                foreach (var integer in integersList)
                {
                    if (integer%2==0)
                    {
                        Console.Write(integer + " ");
                    }
                }
                    Console.WriteLine();
            }
            else if (command[0] == "PrintOdd")
            {
                foreach (var integer in integersList)
                {
                    if (integer % 2 != 0)
                    {
                        Console.Write(integer + " ");                        
                    }
                    Console.WriteLine();
                }
            }
        }

        static void ContainMethod(List<int> integersList, int number)
        {
            bool contains = false;
            foreach (int integer in integersList)
            {
                if (integer==number)
                {
                    contains=true;
                    Console.WriteLine("Yes");
                }
            }
            if (!contains)
            {
                Console.WriteLine("No such number");
            }
        }
    }
}


