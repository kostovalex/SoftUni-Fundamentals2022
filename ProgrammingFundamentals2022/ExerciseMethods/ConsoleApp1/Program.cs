using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
            int[] numbers = {1, 2, 3, 4, 5};

            for (int i = 0; i < numbers.Length; i++)
            {
                list.Add(numbers[i]);
            }
        }
    }
}
