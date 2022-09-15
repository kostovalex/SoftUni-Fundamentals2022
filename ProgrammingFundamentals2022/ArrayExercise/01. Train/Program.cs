using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currwagon = int.Parse(Console.ReadLine());
                
                passengers[i] = currwagon;
                
                sum += currwagon;
            }
            Console.WriteLine(String.Join(" ",passengers));
            Console.WriteLine(sum);
        }
    }
}
