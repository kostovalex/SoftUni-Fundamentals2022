using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        public int ManaPoint { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());

            Dictionary<string , Hero> heroes = new Dictionary<string, Hero>();
           
            for (int i = 0; i < heroesCount; i++)
            {
                string[] currentHero = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = currentHero[0];
                int hitPoint = int.Parse(currentHero[1]);
                int manaPoint = int.Parse(currentHero[2]);

                Hero newHero = new Hero { Name = name, HitPoint = hitPoint, ManaPoint = manaPoint};
                heroes.Add(name, newHero);
            }

            string[] command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!= "End")
            {
                //"CastSpell – {hero name} – {MP needed} – {spell name}"
                if (command[0]=="CastSpell")
                {
                    string heroName = command[1];
                    int neededMana = int.Parse(command[2]);
                    string spell = command[3];

                    if (heroes[heroName].ManaPoint >= neededMana)
                    {
                        heroes[heroName].ManaPoint -= neededMana;
                        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName].ManaPoint} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                    }
                }
                //"TakeDamage – {hero name} – {damage} – {attacker}"
                else if (command[0]=="TakeDamage")
                {
                    string heroName = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    heroes[heroName].HitPoint -= damage;
                    if (heroes[heroName].HitPoint>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoint} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                //"Recharge – {hero name} – {amount}"
                else if (command[0]=="Recharge")
                {
                    string heroName = command[1];
                    int amount = int.Parse(command[2]);

                    heroes[heroName].ManaPoint += amount;
                    if (heroes[heroName].ManaPoint>200)
                    {
                        int rest = 200 - (heroes[heroName].ManaPoint -= amount);
                        heroes[heroName].ManaPoint = 200;
                        Console.WriteLine($"{heroName} recharged for {rest} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                //"Heal – {hero name} – {amount}"
                else if (command[0]=="Heal")
                {
                    string heroName = command[1];
                    int amount = int.Parse(command[2]);

                    heroes[heroName].HitPoint += amount;
                    if (heroes[heroName].HitPoint > 100)
                    {
                        int rest = 100 - (heroes[heroName].HitPoint -= amount);
                        heroes[heroName].HitPoint = 100;
                        Console.WriteLine($"{heroName} healed for {rest} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }

                command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HitPoint}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoint}");
            }
        }
    }
}
