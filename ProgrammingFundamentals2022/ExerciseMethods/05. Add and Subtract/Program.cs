using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumMethod(firstNum,secondNum);
            int final = SubtractMethod(sum, thirdNum);

            Console.WriteLine(final);   
        }

        static int SubtractMethod(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }

        static int SumMethod(int firstNum,int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
