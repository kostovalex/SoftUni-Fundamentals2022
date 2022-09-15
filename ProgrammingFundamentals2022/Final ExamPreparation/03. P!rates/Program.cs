using System;
using System.Collections.Generic;

namespace _03._P_rates
{

    class City
    {
        public string Name { get; set; }
        public int People { get; set; }
        public int Gold { get; set; }
    }
    internal class Program    
    {
        
        static void Main(string[] args)
        {
            Dictionary<string,City> targetedCities = new Dictionary<string,City>();
            
            string[] input = Console.ReadLine().Split("||");
            while (input[0] != "Sail")
            {
                if (!targetedCities.ContainsKey(input[0]))
                {
                    City city = new City { Name = input[0], People = int.Parse(input[1]), Gold = int.Parse(input[2]) };
                    targetedCities.Add(city.Name, city);
                }
                else
                {
                    targetedCities[input[0]].People += int.Parse(input[1]);
                    targetedCities[input[0]].Gold += int.Parse(input[2]);
                }

                input = Console.ReadLine().Split("||");
            }

            string[] actions = Console.ReadLine().Split("=>");
            while (actions[0]!="End")
            {
                //"Plunder=>{town}=>{people}=>{gold}"

                if (actions[0] == "Plunder")
                {
                    string currentTown = actions[1];
                    int peopleKilled = int.Parse(actions[2]);
                    int goldStolen = int.Parse(actions[3]);

                    targetedCities[currentTown].People -= peopleKilled;
                    targetedCities[currentTown].Gold -= goldStolen;
                    
                    Console.WriteLine($"{currentTown} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    if (targetedCities[currentTown].People == 0 || targetedCities[currentTown].Gold == 0)
                    {
                        targetedCities.Remove(currentTown);
                        Console.WriteLine($"{currentTown} has been wiped off the map!");
                    }
                }
                else if (actions[0] == "Prosper")
                //"Prosper=>{town}=>{gold}"
                {
                    string currentTown = actions[1];
                    int goldGiven = int.Parse(actions[2]);
                    if (goldGiven>=0)
                    {
                        targetedCities[currentTown].Gold += goldGiven;
                        Console.WriteLine($"{goldGiven} gold added to the city treasury. {currentTown} now has {targetedCities[currentTown].Gold} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }

                actions = Console.ReadLine().Split("=>");
            }

            if (targetedCities.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetedCities.Count} wealthy settlements to go to:");
                foreach (var city in targetedCities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.People} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
