using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTopInteger = true;
            for (int i = 0; i < array.Length; i++)
            {
                isTopInteger = true;
                if (i == array.Length - 1)
                {
                    Console.Write($"{array[i]} ");
                    break;
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    
                    if (array[i] > array[j])
                    {
                        continue;
                    }
                    else
                    {
                        isTopInteger = false;
                        break;
                    }
                    
                }
                if (isTopInteger)
                {
                    Console.Write($"{array[i]} ");

                }
            }
            
        }
    }
}
