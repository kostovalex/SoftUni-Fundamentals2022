using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delete { element} – delete all elements in the array, which are equal to the given element.
            //Insert { element} { position} – insert the element at the given position.
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0]!="end")
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
