using HeroesApp.Items;
using System.Collections.Generic;


namespace HeroesApp.Heroes
{
    public class Mage: Hero
    {
        public Mage(string Name) : base(Name)
        {
            LevelAttributes = new HeroAttributes(1, 1, 8);
            LevelUpAttributes = new HeroAttributes(1, 1, 5);
            ValidWeaponTypes = new List<Items.WeaponType> { Items.WeaponType.Staffs, Items.WeaponType.Wands };
            ValidArmorTypes = new List<Items.ArmorType> { Items.ArmorType.Cloth };
        }

        public override double DoDamage()
        {
            Weapon Weapon = (Weapon)Equipment[Slot.Weapon];
            double Damage = (Weapon !=null) ? Weapon.WeaponDamage : 1;
            return Damage*(1 + (double)TotalAttributes().Intelligence / (double)100);
        }


    }
}
