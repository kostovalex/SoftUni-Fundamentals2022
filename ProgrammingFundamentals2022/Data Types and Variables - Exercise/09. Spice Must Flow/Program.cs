using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());

            uint storage = 0;
            uint daysCount = 0;

            if (startingYield<100)
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(storage);
                return;
            }
            while (startingYield>=100)
            {
                daysCount++;
                storage += startingYield;
                storage -= 26; 
                startingYield -= 10;
            }
            storage -= 26;
            Console.WriteLine(daysCount);
            Console.WriteLine(storage);
        }

    }
}
