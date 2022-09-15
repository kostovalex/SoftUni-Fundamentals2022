using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "register")
                {
                    string username = input[1];
                    string plateNum = input[2];

                    if (parkingLot.Keys.Contains(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNum}");
                    }
                    else
                    {
                        parkingLot.Add(username, plateNum);
                        Console.WriteLine($"{username} registered {plateNum} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    string username = input[1];

                    if (!parkingLot.Keys.Contains(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingLot.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }

            }

            foreach (var car in parkingLot)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
