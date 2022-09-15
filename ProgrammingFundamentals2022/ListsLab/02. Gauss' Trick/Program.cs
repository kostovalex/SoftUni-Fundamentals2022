using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (numbersList.Count%2==0)
            {
                for (int i = 0; i < numbersList.Count; i++)
                {
                    numbersList[i] += numbersList[numbersList.Count - 1];
                    numbersList.RemoveAt(numbersList.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < numbersList.Count/2; i++)
                {
                    numbersList[i] += numbersList[numbersList.Count - 1];
                    numbersList.RemoveAt(numbersList.Count - 1);
                }
                
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
