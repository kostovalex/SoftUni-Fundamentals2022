using System;

namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!= "Abracadabra")
            {
                if (command[0] == "Abjuration")
                {
                    string finalSpell = string.Empty;
                    for (int i = 0; i < spell.Length; i++)
                    {
                        char currChar = spell[i];
                        if (char.IsLower(currChar))
                        {
                            currChar = char.ToUpper(currChar);
                            finalSpell += currChar;
                        }
                        else
                        {
                            finalSpell += currChar;
                        }
                    }
                    spell = finalSpell;
                    Console.WriteLine(spell);
                }
                else if (command[0] == "Necromancy")
                {
                    string finalSpell = string.Empty;
                    for (int i = 0; i < spell.Length; i++)
                    {
                        char currChar = spell[i];
                        if (char.IsUpper(currChar))
                        {
                            currChar = char.ToLower(currChar);
                            finalSpell += currChar;
                        }
                        else
                        {
                            finalSpell += currChar;
                        }
                    }
                    spell = finalSpell;
                    Console.WriteLine(spell);
                }
                else if (command[0] == "Illusion")
                {
                    int currIndex = int.Parse(command[1]);
                    char replacement = char.Parse(command[2]);
                    if (currIndex>=0&&currIndex<spell.Length)
                    {
                        char[] array = spell.ToCharArray();
                        array[currIndex] = replacement;
                        spell = string.Join("", array);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (command[0] == "Divination")
                {
                    string firstSubstring = command[1];
                    string replacement = command[2];

                    if (spell.Contains(firstSubstring))
                    {
                        spell = spell.Replace(firstSubstring, replacement);
                        Console.WriteLine(spell);
                    }
                }
                else if (command[0] == "Alteration")
                {
                    string substring = command[1];
                    if (spell.Contains(substring))
                    {
                        int startIndex = spell.IndexOf(substring);
                        spell = spell.Remove(startIndex, substring.Length);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
