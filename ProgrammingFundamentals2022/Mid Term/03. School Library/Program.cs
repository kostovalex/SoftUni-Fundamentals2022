using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] commands = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Done")
            {
                if (commands[0] == "Add Book")
                {
                    string bookName = commands[1];
                    
                    if (!library.Exists(n => n == bookName))
                    {
                        library.Insert(0, bookName);
                    }
                }
                else if (commands[0] == "Take Book")
                {
                    string bookName = commands[1];
                    if (library.Contains(bookName))
                    {
                        library.Remove(bookName);
                    }
                }
                else if (commands[0] == "Swap Books")
                {
                    string bookOne = commands[1];
                    string bookTwo = commands[2];
                    if (library.Contains(bookOne)&& library.Contains(bookTwo))
                    {
                        int indexOne = library.IndexOf(bookOne);
                        int indexTwo = library.IndexOf(bookTwo);

                        library.Insert(indexOne, bookTwo);
                        library.Insert(indexTwo + 1, bookOne);
                        library.RemoveAt(indexOne + 1);
                        library.RemoveAt(indexTwo + 1);
                    }
                }
                else if (commands[0] == "Insert Book")
                {
                    string bookName = commands[1];
                    if (!library.Contains(bookName))
                    {
                        library.Add(bookName);
                    }
                }
                else if (commands[0] == "Check Book")
                {
                    int index = int.Parse(commands[1]);
                    if (index>0 && index<library.Count)
                    {
                        for (int i = 0; i < library.Count-1; i++)
                        {
                            if (i==index)
                            {
                                Console.WriteLine(library[i]);
                            }
                        }
                    }
                }
                commands = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(", ", library));
        }
        
    }
}
