using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppintList = Console.ReadLine().Split('!').ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0]!="Go" && command[1]!= "Shopping!")
            {
                if (command[0]=="Urgent")
                {
                    string item = command[1];
                    if (!shoppintList.Contains(item))
                    {
                        shoppintList.Insert(0, item);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    string item = command[1];
                    if (shoppintList.Contains(item))
                    {
                        shoppintList.Remove(item);
                    }
                }
                else if (command[0] == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    if (shoppintList.Contains(oldItem))
                    {
                        shoppintList.Insert(shoppintList.IndexOf(oldItem), newItem);
                        shoppintList.Remove(oldItem);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    string item = command[1];
                    if (shoppintList.Contains(item))
                    {                        
                        shoppintList.Add(item);
                        shoppintList.Remove(item);
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(", ", shoppintList));

        }
    }
}
