using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string[] command = Console.ReadLine().Split(":|:");

            while (command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    message = message.Insert(index, " ");
                }
                else if (command[0] == "Reverse")
                {
                    string substring = command[1];
                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);                       
                        message = message.Remove(index, substring.Length);
                        char[] array = substring.ToCharArray();
                        Array.Reverse(array);                       
                        message = $"{message}{string.Join("", array)}";
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine().Split(":|:");
                        continue;
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];

                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);
                command = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
