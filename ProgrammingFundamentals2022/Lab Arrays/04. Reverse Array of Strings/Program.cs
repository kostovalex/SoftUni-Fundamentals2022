using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = new string[firstArray.Length];


            for (int i = 0; i <= firstArray.Length / 2; i++)
            {
                //string tempString = "";
                //tempString = firstArray[i];
                //firstArray[i] = firstArray[firstArray.Length - 1 - i];
                //firstArray[firstArray.Length - 1 - i] = tempString;
                secondArray[secondArray.Length - 1 - i] = firstArray[i];
                secondArray[i] = firstArray[firstArray.Length - 1 - i];





            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write($"{secondArray[i]} ");
            }

        }
    }
}
