using System;

namespace Data_Type_Finder
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!= "END")
            {
                bool isDataTypeInt = int.TryParse(input, out int i);
                bool isDataTypeFloat = double.TryParse(input, out double d);
                bool isDataTypeChar = char.TryParse(input, out char c);
                bool isDataTypeBool = bool.TryParse(input, out bool b);
                if (isDataTypeInt)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isDataTypeFloat)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isDataTypeChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isDataTypeBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }



        }

    }
}
