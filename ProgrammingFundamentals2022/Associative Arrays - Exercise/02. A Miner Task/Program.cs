using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minersLager = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop") { break; }
                
                int quantity = int.Parse(Console.ReadLine());

                if (!minersLager.Keys.Contains(resource))
                {
                    minersLager.Add(resource, quantity);
                }
                else
                {
                    minersLager[resource] += quantity;
                }
            }

            foreach (var resource in minersLager)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
