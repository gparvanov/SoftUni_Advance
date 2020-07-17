using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int raidGroup = int.Parse(Console.ReadLine());

            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();

            List<BaseHero> heroesGroup = new List<BaseHero>();            

            while (heroesGroup.Count < raidGroup)
            {
                if(heroType == "Druid")
                {
                    Druid druid = new Druid(heroName);
                    heroesGroup.Add(druid);
                }
                else if (heroType == "Paladin")
                {
                    Paladin paladin = new Paladin(heroName);
                    heroesGroup.Add(paladin);
                }
                else if ( heroType == "Rogue")
                {
                    Rogue rogue = new Rogue(heroName);
                    heroesGroup.Add(rogue);
                }
                else if ( heroType == "Warrior")
                {
                    Warrior warrior = new Warrior(heroName);
                    heroesGroup.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

                if (heroesGroup.Count < raidGroup)
                {
                    heroName = Console.ReadLine();
                    heroType = Console.ReadLine();
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int sumHeroesPower = 0;

            foreach (var hero in heroesGroup)
            {
                Console.WriteLine(hero.CastAbility());
                sumHeroesPower += hero.Power;
            }
            if (sumHeroesPower >= bossPower) Console.WriteLine("Victory!");
            else Console.WriteLine("Defeat...");

        }
    }
}
