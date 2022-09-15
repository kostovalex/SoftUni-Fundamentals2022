using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> integersByOccurence = new SortedDictionary<int, int>();

            List<int>numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var number in numbers)
            {
                if (!integersByOccurence.Keys.Contains(number))
                {
                    integersByOccurence.Add(number, 0);
                }
                integersByOccurence[number]++;
            }

            foreach (var integer in integersByOccurence)
            {
                Console.WriteLine($"{integer.Key} -> {integer.Value}");
            }
        }
    }
}
