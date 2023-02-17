using HeroesApp.Heroes;
using System;

namespace HeroesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();

            //Armor item2 = new Armor("Hylian");
            weapon.some_method();
            
            Mage mage = new Mage("Hjalmar")
            {
                Name = "Sverre",
                level= 1,
            };

            mage.TotalAttributes();

            Hero TestHero = new Mage("Forsøkskanin");
            Console.WriteLine(TestHero.TotalAttributes().Intelligence);
            TestHero.LevelUp();
            Console.WriteLine(TestHero.TotalAttributes().Intelligence);
            TestHero.LevelUp();
            Console.WriteLine(TestHero.TotalAttributes().Intelligence);






        }
    }
}
