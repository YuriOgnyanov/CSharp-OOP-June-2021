using Raiding.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    { 
        static void Main(string[] args)
        {
            List<BaseHero> herous = new List<BaseHero>();

            int numbersOfHerous = int.Parse(Console.ReadLine());

            while (herous.Count != numbersOfHerous)
            {
                try
                {
                    string name = Console.ReadLine();
                    string typeHero = Console.ReadLine();

                    if (typeHero is "Druid")
                    {
                        BaseHero druid = new Druid(name);
                        herous.Add(druid);
                    }
                    else if (typeHero is "Paladin")
                    {
                        BaseHero paladin = new Paladin(name);
                        herous.Add(paladin);
                    }
                    else if (typeHero is "Rogue")
                    {
                        BaseHero rogue = new Rogue(name);
                        herous.Add(rogue);
                    }
                    else if (typeHero is "Warrior")
                    {
                        BaseHero warrior = new Warrior(name);
                        herous.Add(warrior);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }

            int bossPower = int.Parse(Console.ReadLine());

            int herousPower = herous.Sum(x => x.Power);

            foreach (var hero in herous)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (herousPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
            
            

        }
    }
}
