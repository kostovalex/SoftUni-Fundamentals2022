using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestStreakCount = 1;
            int longestStreakStart = 0;

            int currStreakCount = 1;
            int currStreakStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i-1])
                {
                    currStreakCount++;
                    if (currStreakCount>longestStreakCount)
                    {
                        longestStreakCount = currStreakCount;
                        longestStreakStart = currStreakStart;
                    }
                }
                else
                {
                    currStreakCount = 1;
                    currStreakStart = i;
                }
            }
            for (int i = longestStreakStart; i < longestStreakStart+longestStreakCount; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
