using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add { passengers} – add a wagon to the end of the train with the given number of passengers.
            //{ passengers} – find a single wagon to fit all the incoming passengers(starting from the first wagon).
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            while (input[0] != "end")
            {
                if (input[0]== "Add")
                {
                    int passengers = int.Parse(input[1]);
                    train.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(input[0]);
                    FindWagon(passengers, train, capacity);
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", train));
        }

        private static void FindWagon(int passengers, List<int> train, int capacity)
        {
            for (int i = 0; i < train.Count; i++)
            {
                if (train[i]+passengers<=capacity)
                {
                    train[i] += passengers;
                    break;
                }
            }
        }
    }
}
