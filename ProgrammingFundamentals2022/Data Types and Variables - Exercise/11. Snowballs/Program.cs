using System;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int highestValue = int.MinValue;
            int bestSnow = int.MinValue;
            int bestTime = int.MinValue;
            int bestQuality = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                int value = (int)Math.Pow((snow/time), quality);


                if (value>=highestValue)
                {
                    highestValue = value;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }

            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {highestValue} ({bestQuality})");
        }
    }
}
