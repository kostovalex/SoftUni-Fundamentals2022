using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysMax = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay= double.Parse(Console.ReadLine());

            double waterSupply = waterPerDay * playersCount * daysMax;
            double foodSupply = foodPerDay * playersCount * daysMax;

            int daysCounter = 1;
            while (daysCounter<=daysMax)
            {
                double energyLost = double.Parse(Console.ReadLine());
                energy-=energyLost;

                if(energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {foodSupply:f2} food and {waterSupply:f2} water.");
                    return;
                }

                if (daysCounter%2==0)
                {
                    energy += energy * 0.05;
                    waterSupply -= waterSupply * 0.3;
                }
                if (daysCounter%3==0)
                {
                    energy += energy * 0.1;
                    foodSupply -= foodSupply / playersCount;
                }
                daysCounter++;
                
            }
            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            
        }
    }
}
