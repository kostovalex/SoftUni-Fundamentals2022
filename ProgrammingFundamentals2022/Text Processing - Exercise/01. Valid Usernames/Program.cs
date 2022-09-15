using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            

            foreach (var username in usernames)
            {
                bool isValid = true;
                if (username.Length>=3 && username.Length<=16)
                {
                    foreach (var character in username)
                    {
                        if (!(character == '-' || character == '_' || char.IsLetterOrDigit(character)))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }                    
        }
    }
}
