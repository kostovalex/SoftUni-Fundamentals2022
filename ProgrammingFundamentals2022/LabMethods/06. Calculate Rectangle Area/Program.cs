﻿using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaCalculator(width,height));
        }
        static double AreaCalculator(double width, double height)
        {
            return width * height;
        }
    }
}
