using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\B@#+(?<sin>[A-Z][a-zA-Z0-9]{4,}[A-Z])@#+\B";
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();

                if (Regex.IsMatch(barcode, pattern))
                {
                    
                    string barcodeGroup = string.Empty;
                    
                    for (int j = 0; j < barcode.Length; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            barcodeGroup += barcode[j];
                        }
                    }
                    if (barcodeGroup.Length!=0)
                    {
                        Console.WriteLine($"Product group: {barcodeGroup}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
