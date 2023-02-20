using HeroesApp.Heroes;
using HeroesApp.Items;
using System;

namespace HeroesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Name = "Frodos silver thingy";
            int RequiredLevel = 1;
            ArmorType ArmorType = ArmorType.Plate;
            HeroAttributes armorAttributes = new HeroAttributes(1, 2, 3);
            Item TestArmor = new Armor(Name, RequiredLevel, Slot.Body, ArmorType, armorAttributes);
        }
    }
}
