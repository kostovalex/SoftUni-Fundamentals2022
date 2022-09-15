using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawString = Console.ReadLine();

            string[] command = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!="Generate")
            {
                if (command[0] == "Contains")
                {
                    string substring = command[1];
                    if (rawString.Contains(substring))
                    {
                        Console.WriteLine($"{rawString} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string substring = rawString.Substring(startIndex, (endIndex - startIndex));
                    if (command[1] == "Upper")
                    {
                        rawString = rawString.Replace(substring, substring.ToUpper());
                    }
                    else if (command[1] == "Lower")
                    {
                        rawString = rawString.Replace(substring, substring.ToLower());
                    }
                    Console.WriteLine(rawString);
                }
                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    rawString = rawString.Remove(startIndex, (endIndex - startIndex));
                    Console.WriteLine(rawString);
                }
                
                command = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your activation key is: {rawString}");
        }
    }
}
