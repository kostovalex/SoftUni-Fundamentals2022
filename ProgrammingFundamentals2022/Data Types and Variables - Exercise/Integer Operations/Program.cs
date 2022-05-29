using System;

namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //⦁	Add first to the second.
            //⦁	Divide(integer) the result of the first operation by the third number.
            //⦁	Multiply the result of the second operation by the fourth number.
            //Print the result after the last operation
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());      
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());
            secondInteger += firstInteger;
            secondInteger /= thirdInteger;
            secondInteger *= fourthInteger;
            Console.WriteLine(secondInteger);
        }
    }
}
