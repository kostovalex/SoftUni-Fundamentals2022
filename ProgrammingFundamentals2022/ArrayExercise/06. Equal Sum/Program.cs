using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int j = i; j > 0; j--)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    else
                    {
                        sumLeft += array[j - 1];
                    }
                }
                for (int n = i + 1; n < array.Length; n++)
                {
                    if (i == array.Length - 1)
                    {
                        break;
                    }
                    else
                    {
                        sumRight += array[n];
                    }
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }
            if (isFound==false)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
