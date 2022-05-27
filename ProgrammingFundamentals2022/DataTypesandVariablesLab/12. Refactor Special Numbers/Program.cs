using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= endNumber; i++)
            {
                int sum = 0;
                int num = 0;
                bool itIs = false;
                num = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                itIs = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, itIs);
                sum = 0;
                i = num;
            }
        }
    }
}
