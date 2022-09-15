using System;

using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();
            string[] stringArray = numbersAsString.Split(' ');
            int[] numbers = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numbers[i] = int.Parse(stringArray[i]);
            }
            int sum=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    sum+=numbers[i];
                }
            }
            Console.WriteLine(sum);
        }


    }
}
