using System;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawString = Console.ReadLine();

            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            while (commands[0] != "Done")
            {
                if (commands[0] == "TakeOdd")
                {
                    string newString = string.Empty;
                    for (int i = 0; i < rawString.Length; i++)
                    {
                        char currChar = rawString[i];
                        if (i%2!=0)
                        {
                            newString += currChar;
                        }
                    }
                    rawString = newString;
                    Console.WriteLine(rawString);
                }
                //"Cut {index} {length}"
                else if (commands[0] == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    rawString = rawString.Remove(index, length);
                    Console.WriteLine(rawString);
                }
                //"Substitute {substring} {substitute}"
                else if (commands[0] == "Substitute")
                {
                    string substring = commands[1];
                    string replacement = commands[2];

                    if (rawString.Contains(substring))
                    {
                        rawString = rawString.Replace(substring, replacement);
                        Console.WriteLine(rawString);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }                    
                }
                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your password is: {rawString}");
        }
    }
}
