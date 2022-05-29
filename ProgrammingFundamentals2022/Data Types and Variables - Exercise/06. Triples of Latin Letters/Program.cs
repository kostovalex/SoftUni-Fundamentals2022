using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i <= 96+n; i++)
            {
                for (int r = 97; r <=96+n; r++)
                {
                    for (int j = 97; j <= 96+n; j++)
                    {
                        char output = (char)i;
                        char output2 = (char)r;
                        char output3 = (char)j;

                        Console.WriteLine($"{output}{output2}{output3}");
                    }
                }
            }
        }
    }
}
