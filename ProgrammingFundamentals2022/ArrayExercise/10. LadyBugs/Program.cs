using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] startBugIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[sizeOfField];

            for (int i = 0; i < startBugIndex.Length; i++)
            {
                int currentIndex = startBugIndex[i];
                if (currentIndex >= 0 && currentIndex < sizeOfField)
                {
                    field[currentIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(commands[0]);

                while (currentIndex >= 0 && currentIndex < field.Length && field[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        field[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLength = int.Parse(commands[2]);

                    if (commands[1] == "left")
                    {
                        currentIndex -= flightLength;
                        if (currentIndex >= 0 && currentIndex < sizeOfField)
                        {
                            if (field[currentIndex] == 0)
                            {
                                field[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLength;
                        if (currentIndex >= 0 && currentIndex < sizeOfField)
                        {
                            if (field[currentIndex] == 0)
                            {
                                field[currentIndex] = 1;
                                break;
                            }
                        }
                    }

                }
                commands = Console.ReadLine().Split();


            }
            Console.WriteLine(String.Join(" ", field));




        }
    }
}
