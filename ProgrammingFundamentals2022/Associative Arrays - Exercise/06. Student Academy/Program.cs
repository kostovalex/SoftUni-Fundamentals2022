using System;

using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.Keys.Contains(student))
                {
                    studentsGrades.Add(student, new List<double>());
                    studentsGrades[student].Add(grade);
                }
                else
                {
                    studentsGrades[student].Add(grade);
                }
            }

           
            foreach (var item in studentsGrades)
            {
                
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }

    }
}