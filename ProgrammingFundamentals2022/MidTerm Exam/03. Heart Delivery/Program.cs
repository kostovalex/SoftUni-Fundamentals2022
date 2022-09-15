using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            int currentPosition = 0;
            while (command[0] != "Love!")
            {
                int housesLastIndex = neighborhood.Count - 1;
                int lenght = int.Parse(command[1]);
                
                if (currentPosition+lenght> housesLastIndex)
                {
                    currentPosition = 0;
                }
                else
                {
                    currentPosition += lenght;
                }
                
               
                
                if (neighborhood[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");                                        
                }
                else 
                {
                    neighborhood[currentPosition] -= 2;
                    if (neighborhood[currentPosition] == 0)
                    {
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Cupid's last position was {currentPosition}.");
            if (neighborhood.Sum()==0)           
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {

                Console.WriteLine($"Cupid has failed {neighborhood.Count(n => n != 0)} places.");
            }
        }
    }
}
