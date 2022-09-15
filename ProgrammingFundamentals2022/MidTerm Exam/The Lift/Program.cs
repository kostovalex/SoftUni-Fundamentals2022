using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 40 min
            int tourists = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                int emptyPlaces = 4 - wagons[i];
                if (tourists>=emptyPlaces)
                {
                    tourists -= emptyPlaces;
                    wagons[i] += emptyPlaces;
                }
                else
                {                    
                    wagons[i] += tourists;
                    tourists = 0;
                }
                
                if (tourists<=0&&wagons.Sum() / 4 != wagons.Count)
                {
                    
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(String.Join(" ",wagons));
                    return;
                }
                if (wagons.Sum()/4==wagons.Count&&tourists>0)
                {
                    Console.WriteLine($"There isn't enough space! {tourists} people in a queue!");
                    Console.WriteLine(String.Join(" ", wagons));
                    return;
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
