using System;
using System.Linq;

namespace _2._From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (array[0] > array[1])
                {
                    while (array[0] != 0)
                    {
                        sum += (array[0] % 10);
                        array[0] /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                    sum = 0;
                }
                else
                {
                    while (array[1] != 0)
                    {
                        sum += (array[1] % 10);
                        array[1] /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                    sum = 0;
                }
            }

        }
    }
}
