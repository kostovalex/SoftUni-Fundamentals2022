using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bomb[0];
            int bombPower = bomb[1];
            int originalCount = numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    for (int j = 0; j < (bombPower*2)+1 && j < originalCount - (i - bombPower); j++)
                    {
                        if ((i - bombPower)>=0)
                        {
                            numbers.RemoveAt(i - bombPower);
                        }
                        else
                        {
                            i++;
                            j--;
                        } 

                    }
                    i-=(bombPower+1);
                }
            }
            
            Console.WriteLine(numbers.Sum(x => x));
        }
    }
}
