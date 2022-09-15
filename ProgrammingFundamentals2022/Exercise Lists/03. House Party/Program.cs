using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            //"{name} is going!"
            //You have to add the person, if they are not on the guestlist already.
            //If the person is on the list print the following to the console: "{name} is already in the list!"
            //"{name} is not going!"
            //You have to remove the person, if they are on the list. 
            //If not, print out: "{name} is not in the list!"
            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];
                if (commands[1] == "is"&& commands[2] == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (commands[1] == "is" && commands[2] == "not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.Write(guests[i]);
                Console.WriteLine();
            }
        }
    }
}
