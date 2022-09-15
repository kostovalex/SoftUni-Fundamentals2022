using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string erst = Console.ReadLine();
            string ganz = Console.ReadLine();

            while (true)
            {
                int startIndex = ganz.IndexOf(erst);
                
                if (!ganz.Contains(erst))
                {
                    break;
                }

                ganz = ganz.Remove(startIndex, erst.Length);
            }
            
            Console.WriteLine(ganz);
        }
    }
}
