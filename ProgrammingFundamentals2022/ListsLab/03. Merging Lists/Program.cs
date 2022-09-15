using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mergedList= new List<int>();
            
            int length = 0;
            if (first.Count<second.Count)
            {
                length= first.Count;
                for (int i = 0; i < length; i++)
                {
                    mergedList.Add(first[i]);
                    mergedList.Add(second[i]);
                }
                for (int i = length; i < second.Count; i++)
                {
                    mergedList.Add(second[i]);
                }
            }
            else
            {
                length = second.Count;
                for (int i = 0; i < length; i++)
                {
                    mergedList.Add(first[i]);
                    mergedList.Add(second[i]);
                }
                for (int i = length; i < first.Count; i++)
                {
                    mergedList.Add(first[i]);
                }
            }
            Console.WriteLine(String.Join(" ", mergedList));
            

        }
    }
}
