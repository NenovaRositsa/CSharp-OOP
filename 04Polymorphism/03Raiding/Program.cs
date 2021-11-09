using Raiding.Models;
using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int countHeroes = int.Parse(Console.ReadLine());
            int counter = 0;

            while (countHeroes != counter)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    BaseHero hero = FactoryHeroes(heroName, heroType);
                    heroes.Add(hero);
                    counter++;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
                
            

            int bossPower = int.Parse(Console.ReadLine());
            int sumHeroesPowers = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                sumHeroesPowers += hero.Power;
            }

            PrintResult(bossPower, sumHeroesPowers);
        }

        private static void PrintResult(int bossPower, int sumHeroesPowers)
        {
            if (sumHeroesPowers >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        public static BaseHero FactoryHeroes(string heroName, string heroType)
        {
            BaseHero hero = null;
            if (heroType != "Druid" && heroType != "Paladin"
                && heroType != "Rogue" && heroType != "Warrior")
            {
               throw new Exception("Invalid hero!");
            }

            switch (heroType)
            {
                case "Druid": hero = new Druid(heroName); break;
                case "Paladin": hero = new Paladin(heroName); break;
                case "Rogue": hero = new Rogue(heroName); break;
                case "Warrior": hero = new Warrior(heroName); break;
                default:
                    break;
            }

            return hero;
        }
    }
}
