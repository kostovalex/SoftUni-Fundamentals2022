using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOne= new int[n];
            int[] arrayTwo = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    arrayOne[i] = input[0];
                    arrayTwo[i] = input[1];
                }
                else
                {
                    arrayOne[i] = input[1];
                    arrayTwo[i] = input[0];
                }
            }
            Console.WriteLine(String.Join(' ',arrayOne));
            Console.WriteLine(String.Join(' ', arrayTwo));
        }
    }
}
