using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLongEnough = LengthChecker(password);
            bool isVariableEnough = VarietyChecker(password);
            bool areTheDigitsEnough = DigitsChecker(password);

            if (isLongEnough && isVariableEnough && areTheDigitsEnough)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool LengthChecker(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool VarietyChecker(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] >= 48 && (int)password[i] <= 57
                    || (int)password[i] >= 65 && (int)password[i] <= 90
                    || (int)password[i] >= 97 && (int)password[i] <= 122)
                {
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }
        static bool DigitsChecker(string password)
        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    digitCounter++;
                }
            }
            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
