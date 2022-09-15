using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> companiesAndPersonal = new Dictionary<string, List<string>>();

            while (input[0]!="End")
            {
                string company = input[0];
                string empID = input[1];

                if (!companiesAndPersonal.Keys.Contains(company))
                {
                    companiesAndPersonal.Add(company, new List<string>());
                    if (!companiesAndPersonal[company].Contains(empID))
                    {
                        companiesAndPersonal[company].Add(empID);
                    }
                }
                else
                {
                    if (!companiesAndPersonal[company].Contains(empID))
                    {
                        companiesAndPersonal[company].Add(empID);
                    }
                }

                input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var company in companiesAndPersonal)
            {
                Console.WriteLine(company.Key);
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
