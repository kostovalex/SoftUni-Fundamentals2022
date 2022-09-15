using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
               
                if (input[0]=="End")
                {
                    break;
                }
                
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                
                if (!list.Any(x=>x.ID == id))
                {
                    Person person = new Person(name, id, age);
                    list.Add(person);
                }
                else
                {
                    foreach (Person person in list)
                    {
                        if (person.ID==id)
                        {
                            person.Name = name;
                            person.Age = age;
                        }
                    }
                }
            }
            List<Person> orderedList = list.OrderBy(x => x.Age).ToList();

            foreach (Person person in orderedList)
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
