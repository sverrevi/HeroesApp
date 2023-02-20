using HeroesApp.Heroes;
using HeroesApp.Items;
using System;

namespace HeroesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Name = "Ola Nordmann";
            Hero TestHero = new Warrior(Name);
            HeroAttributes InitialValues = TestHero.TotalAttributes();
            TestHero.LevelUp();
            HeroAttributes LeveledUp = TestHero.TotalAttributes();
        }
    }
}
