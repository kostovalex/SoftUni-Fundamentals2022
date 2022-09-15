using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int integer = int.Parse(Console.ReadLine());
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = j+1; i < array.Length; i++)
                {
                    if (integer == array[j] + array[i])
                    {
                        Console.WriteLine($"{array[j]} {array[i]}");
                    }
                }
            }
    
        }
    }
}
