using System;

namespace _2._From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                var number = Console.ReadLine();
                int length = number.Length;
                bool isSpace = false;
                string firstString = "";
                string secondString = "";

                for (int i = 0; i < length; i++)
                {
                    if ((int)number[i] == 32 || isSpace)
                    {
                        isSpace = true;
                        secondString += number[i];

                    }
                    else
                    {
                        firstString += number[i];
                    }

                }
                long firstNum = long.Parse(firstString);
                long secondNum = long.Parse(secondString);
                if (firstNum > secondNum)
                {
                    long sum = 0;
                    while (firstNum != 0)
                    {
                        sum += firstNum % 10;
                        firstNum /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
                else
                {
                    long sum = 0;
                    while (secondNum != 0)
                    {
                        sum += secondNum % 10;
                        secondNum /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
            }

        }
    }
}
