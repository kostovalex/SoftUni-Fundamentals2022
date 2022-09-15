using System;
using System.Collections.Generic;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Guest> guests = new Dictionary<string, Guest>();
            int disliked = 0;
            
            while (command[0]!= "Stop")
            {
                if (command[0] == "Like")
                {
                    string guestName = command[1];
                    string meal = command[2];
                    
                    if (!guests.ContainsKey(guestName))
                    {
                        Guest guest = new Guest { Name = guestName, LikedDishes = new List<string>() };
                        guest.LikedDishes.Add(meal);
                        guests.Add(guestName, guest);
                    }
                    else
                    {
                        if (!guests[guestName].LikedDishes.Contains(meal))
                        {
                            guests[guestName].LikedDishes.Add(meal);
                        }
                    }
                }
                else if (command[0] == "Dislike")
                {
                    string guestName = command[1];
                    string meal = command[2];

                    if (!guests.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                    else
                    {
                        if (!guests[guestName].LikedDishes.Contains(meal))
                        {
                            Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            disliked++;
                            guests[guestName].LikedDishes.Remove(meal);
                            Console.WriteLine($"{guestName} doesn't like the {meal}.");
                        }
                    }
                }
                command = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in guests)
            {
                Console.Write($"{person.Key}: ");
                Console.Write(string.Join(", ", person.Value.LikedDishes));
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {disliked}");
        }
    }
    class Guest
    {
        public string Name { get; set; }
        public List<string> LikedDishes { get; set; }
        public int DislikedDishes { get; set; }
    }
}
