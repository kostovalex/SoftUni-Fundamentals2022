using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split();
            while (input[0] != "end")
            {
                if (input[0] == "exchange")
                {
                    int index = int.Parse(input[1]);
                    if (index < 0 || index >= initialArray.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] newInitArray = new int[initialArray.Length];
                        ExchangeCommand(newInitArray, index, input, initialArray);
                        initialArray = newInitArray;
                    }
                }
                else if (input[0] == "max")
                {
                    if (input[1] == "odd")
                    {

                        int biggestOddIndex = MaxOdd(initialArray);
                        if (biggestOddIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(biggestOddIndex);
                        }
                    }
                    else
                    {
                        int biggestEvenIndex = MaxEven(initialArray); ;
                        if (biggestEvenIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(biggestEvenIndex);
                        }
                    }
                }
                else if (input[0] == "min")
                {
                    if (input[1] == "odd")
                    {

                        int smallestOddIndex = MinOdd(initialArray);
                        if (smallestOddIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(smallestOddIndex);
                        }
                    }
                    else
                    {
                        int smallestEvenIndex = MinEven(initialArray); ;
                        if (smallestEvenIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(smallestEvenIndex);
                        }
                    }
                }
                else if (input[0] == "first")
                {
                    if (int.Parse(input[1]) > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (input[2] == "even")
                    {
                        List<int> firstEven=new List<int>();
                        int count = int.Parse(input[1]);
                        FirstEvenNumber(count, firstEven, initialArray);
                        Console.WriteLine($"[{String.Join(", ", firstEven)}]");
                    }
                    else
                    {
                        List<int> firstOdd = new List<int>();
                        int count = int.Parse(input[1]);
                        FirstOddNumber(count, firstOdd, initialArray);
                        Console.WriteLine($"[{String.Join(", ", firstOdd)}]");
                    }


                }
                else if (input[0] == "last")
                {
                    if (int.Parse(input[1]) > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (input[2] == "even")
                    {
                        List<int> lastEven = new List<int>();
                        int count = int.Parse(input[1]);
                        LastEvenNumber(count, lastEven, initialArray);
                        Console.WriteLine($"[{String.Join(", ", lastEven)}]");
                    }
                    else
                    {
                        List<int> lastOdd = new List<int>();
                        int count = int.Parse(input[1]);
                        LastOddNumber(count, lastOdd, initialArray);
                        Console.WriteLine($"[{String.Join(", ", lastOdd)}]");
                    }
                }
                input = Console.ReadLine().Split();


            }
            Console.WriteLine($"[{String.Join(", ", initialArray)}]");

            static int MaxEven(int[] initialArray)
            {
                int biggestEvenIndex = -1;
                int biggestEven = 0;
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] >= biggestEven && initialArray[i] % 2 == 0)
                    {
                        biggestEven = initialArray[i];
                        biggestEvenIndex = i;
                    }
                }
                return biggestEvenIndex;
            }

            static int MaxOdd(int[] initialArray)
            {
                int biggestOddIndex = -1;
                int biggestOdd = 0;
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] >= biggestOdd && initialArray[i] % 2 != 0)
                    {
                        biggestOdd = initialArray[i];
                        biggestOddIndex = i;
                    }
                }
                return biggestOddIndex;
            }

            static int[] ExchangeCommand(int[] newInitArray, int index, string[] input, int[] initialArray)
            {
                for (int i = 0; i < newInitArray.Length - (index + 1); i++)
                {
                    newInitArray[i] = initialArray[index + 1 + i];
                }
                for (int i = newInitArray.Length - 1 - index; i < newInitArray.Length; i++)
                {
                    newInitArray[i] = initialArray[(index + 1 + i) - newInitArray.Length];
                }
                return newInitArray;
            }
        }

        private static List<int> LastOddNumber(int count, List<int> lastOdd, int[] initialArray)
        {
            int[] temporaryArrayTwoAndHalf = new int[initialArray.Length];
            for (int i = 0; i < temporaryArrayTwoAndHalf.Length; i++)
            {
                temporaryArrayTwoAndHalf[i] = initialArray[i];
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = temporaryArrayTwoAndHalf.Length - 1; j >= 0; j--)
                {
                    if (temporaryArrayTwoAndHalf[j] % 2 != 0)
                    {
                        lastOdd.Add(temporaryArrayTwoAndHalf[j]);
                        temporaryArrayTwoAndHalf[j] = 0;
                        break;
                    }
                }
            }
            return lastOdd;
        }

        private static List<int> LastEvenNumber(int count, List<int> lastEven, int[] initialArray)
        {
            int[] temporaryArrayTwo = new int[initialArray.Length];
            for (int i = 0; i < temporaryArrayTwo.Length; i++)
            {
                temporaryArrayTwo[i] = initialArray[i];
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = temporaryArrayTwo.Length - 1; j >= 0; j--)
                {
                    if (temporaryArrayTwo[j] % 2 == 0)
                    {
                        lastEven.Add(temporaryArrayTwo[j]);
                        temporaryArrayTwo[j] = -1;
                        break;
                    }
                }
            }
            return lastEven;
        }

        static List<int> FirstOddNumber(int count, List<int> firstOdd, int[] initialArray)
        {
            int[] temporaryArrayOne = new int[initialArray.Length];
            for (int i = 0; i < temporaryArrayOne.Length; i++)
            {
                temporaryArrayOne[i] = initialArray[i];
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < temporaryArrayOne.Length; j++)
                {
                    if (temporaryArrayOne[j] % 2 != 0)
                    {
                        firstOdd.Add(temporaryArrayOne[j]);
                        temporaryArrayOne[j] = 0;
                        break;
                    }
                }
            }
            return firstOdd;
        }

        static List<int> FirstEvenNumber(int count, List<int> firstEven, int[] initialArray)
        {
            int[] temporaryArray = new int[initialArray.Length];
            for (int i = 0; i < temporaryArray.Length; i++)
            {
                temporaryArray[i] = initialArray[i];
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < temporaryArray.Length; j++)
                {
                    if (temporaryArray[j] % 2 == 0)
                    {
                        firstEven.Add(temporaryArray[j]);
                        temporaryArray[j] = -1;
                        break;
                    }
                }
            }
            return firstEven;
        }

        private static int MinEven(int[] initialArray)
        {
            int smallestEvenIndex = -1;
            int smallestEven = int.MaxValue;
            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] <= smallestEven && initialArray[i] % 2 == 0)
                {
                    smallestEven = initialArray[i];
                    smallestEvenIndex = i;
                }
            }
            return smallestEvenIndex;
        }

        static int MinOdd(int[] initialArray)
        {
            int smallestOddIndex = -1;
            int smallestOdd = int.MaxValue;
            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] <= smallestOdd && initialArray[i] % 2 != 0)
                {
                    smallestOdd = initialArray[i];
                    smallestOddIndex = i;
                }
            }
            return smallestOddIndex;
        }



    }
}
