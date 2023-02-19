using HeroesApp.Heroes;
using HeroesApp.Items;
using System;

namespace HeroesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon MyWeapon = new Weapon("Common axe", 2, Slot.Weapon, WeaponType.Staffs, 2);
            Armor MyArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttributes(1, 0, 0));
            Warrior MyWarrior = new Warrior("Kristian");
            Console.WriteLine(MyWarrior.DoDamage());
            MyWarrior.Equip(MyWeapon);
            Console.WriteLine(MyWarrior.DoDamage());
            MyWarrior.Equip(MyArmor);
            Console.WriteLine(MyWarrior.DoDamage());
        }
    }
}
