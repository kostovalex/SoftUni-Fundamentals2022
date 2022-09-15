using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int valueOne = int.Parse(Console.ReadLine());
                int valueTwo = int.Parse(Console.ReadLine());
                GetMax(valueOne, valueTwo);
            }
            else if (input == "char")
            {
                char valueOne = char.Parse(Console.ReadLine());
                char valueTwo = char.Parse(Console.ReadLine());
                GetMax(valueOne, valueTwo);
            }
            else
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                GetMax(firstValue, secondValue);    
            }
        }
        static void GetMax(int firstValue, int secondValue)
        {
            
            if (firstValue>secondValue)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
        }
        static void GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
        }
        static void GetMax(string firstValue, string secondValue)
        {
            if (String.Compare(firstValue, secondValue) < 0)
            {
                Console.WriteLine(secondValue);
            }
                
            else
            {
                Console.WriteLine(firstValue);
            }
                            
                   
        }
    }
}
