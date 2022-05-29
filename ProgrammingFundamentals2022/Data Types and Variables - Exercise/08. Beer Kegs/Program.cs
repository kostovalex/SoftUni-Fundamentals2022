using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string modelSaved = "";
            double biggestVolume = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    modelSaved = model;
                }

            }
            Console.WriteLine(modelSaved);  
        }
    }
}
