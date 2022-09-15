using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier==0||bigNumber=="0")
            {
                Console.WriteLine(0);
                return;
            }
            
            StringBuilder sb = new StringBuilder();
            int rest = 0;
            
            for (int i = bigNumber.Length-1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int result = (currentDigit * multiplier) + rest;
                sb.Insert(0,result%10);
                rest = result / 10;
            }
            
            if (rest!=0)
            {
                sb.Insert(0, rest);
            }
            
            Console.WriteLine(sb.ToString());   
        }
    }
}
