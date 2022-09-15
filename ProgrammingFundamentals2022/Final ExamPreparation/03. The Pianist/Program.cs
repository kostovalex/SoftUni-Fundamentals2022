using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, PianoPiece> pieces = new Dictionary<string, PianoPiece>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string pieceName = input[0];
                string composer = input[1];
                string key = input[2];

                PianoPiece piece = new PianoPiece { Name = pieceName, Composer = composer, Key = key };    
                pieces.Add(pieceName, piece);               
            }

            string[] line = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            while (line[0]!= "Stop")
            {
                //"Add|{piece}|{composer}|{key}":

                if (line[0] == "Add")
                {
                    string currentPieceName = line[1];
                    string currentComposer = line[2];
                    string currentKey = line[3];
                    if (!pieces.ContainsKey(currentPieceName))
                    {
                        PianoPiece piece = new PianoPiece { Name = currentPieceName, Composer = currentComposer, Key = currentKey };
                        pieces.Add(currentPieceName, piece);
                        Console.WriteLine($"{currentPieceName} by {currentComposer} in {currentKey} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPieceName} is already in the collection!");
                    }

                }
                
                else if (line[0] == "Remove")
                {
                    string currentPieceName = line[1];
                    if (pieces.ContainsKey(currentPieceName))
                    {
                        pieces.Remove(currentPieceName);
                        Console.WriteLine($"Successfully removed {currentPieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPieceName} does not exist in the collection.");
                    }
                }
                //"ChangeKey|{piece}|{new key}":
                else if (line[0] == "ChangeKey")
                {
                    string currentPieceName = line[1];
                    string newKey = line[2];
                    if (pieces.ContainsKey(currentPieceName))
                    {
                        pieces[currentPieceName].Key = newKey;
                        Console.WriteLine($"Changed the key of {currentPieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPieceName} does not exist in the collection.");
                    }
                }
                line = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            }

           
            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }

    class PianoPiece
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string  Key { get; set; }
    }
}
