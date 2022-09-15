using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> arrays = Console.ReadLine().Split("|").Reverse().ToList();            
            List<int> intArrays = new List<int>();

            foreach (string array in arrays)
            {
                intArrays.AddRange(array.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(String.Join(" ", intArrays));
        }
    }
}
