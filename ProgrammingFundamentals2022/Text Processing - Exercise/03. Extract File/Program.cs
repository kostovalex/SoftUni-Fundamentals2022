using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string[] file = path[path.Length - 1].Split(".");

            string fileName = file[0];  
            string extension = file[1];

            Console.Write("File name: ");
            Console.WriteLine(fileName);
            Console.Write("File extension: ");
            Console.WriteLine(extension);
        }
    }
}
