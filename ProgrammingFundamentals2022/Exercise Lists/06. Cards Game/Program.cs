using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numberOfCards = playerOne.Count;
            while (playerOne.Count != 0 && playerTwo.Count != 0)
            {
                int i = 0;
                if (playerOne[i] > playerTwo[i])
                {
                    playerOne.Add(playerOne[i]);
                    playerOne.Add(playerTwo[i]);
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                else if (playerTwo[i] > playerOne[i])
                {
                    playerTwo.Add(playerTwo[i]);
                    playerTwo.Add(playerOne[i]);
                    playerTwo.RemoveAt(i);
                    playerOne.RemoveAt(i);
                }
                else if (playerOne[i] == playerTwo[i])
                {
                    playerTwo.RemoveAt(i);
                    playerOne.RemoveAt(i);
                }
                
            }
            if (playerOne.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum(x => x)}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum(x => x)}");
            }
        }
    }
}
