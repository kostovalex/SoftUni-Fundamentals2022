using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "end")
                {
                    break;
                }
                
                string firstName = input[0];
                string secondName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                Student student = new Student(firstName, secondName, age, homeTown); 
                students.Add(student);
            }
            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public Student(string firstName, string secondName, int age, string homeTown)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

}
