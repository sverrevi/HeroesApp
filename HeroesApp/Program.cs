using HeroesApp.Heroes;
using HeroesApp.Items;
using System;

namespace HeroesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            
            
            
            Mage mage = new Mage("Hjalmar")
            {
                level= 1,
            };

            Console.WriteLine(mage.TotalAttributes().Strength);

            Slots mySlot = Slots.Head;
            Console.WriteLine(mySlot);






        }
    }
}
