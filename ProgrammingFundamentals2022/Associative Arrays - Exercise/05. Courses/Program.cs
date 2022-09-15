using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesProgram = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0]!="end")
            {
                string course = input[0];
                string student = input[1];

                if (!coursesProgram.Keys.Contains(course))
                {
                    coursesProgram.Add(course,new List<string>());
                    coursesProgram[course].Add(student);
                }
                else
                {
                    coursesProgram[course].Add(student);
                }

                input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var course in coursesProgram)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
