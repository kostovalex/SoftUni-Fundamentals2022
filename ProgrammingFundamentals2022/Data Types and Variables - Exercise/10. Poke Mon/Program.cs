using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerInit = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int power = powerInit;
            int pokeCounter = 0;
            while (power >= distance)
            {
                power -= distance;
                pokeCounter++;
                if (power == powerInit/2&&power>exhaustion&&exhaustion!=0)
                {
                    power /= exhaustion;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCounter);
        }
    }
}
