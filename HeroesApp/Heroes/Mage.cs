using HeroesApp.Items;
using System.Collections.Generic;


namespace HeroesApp.Heroes
{    /// <summary>
     /// The Mage class inherits from the hero class, uses the name when a hero is created and sets the individual attributes corresponding to the
     /// mage hero type. The doDamage method included in this deals damage based upon the Mages attributes and overrides the method from the 
     /// hero class. 
     /// </summary>
    public class Mage: Hero
    {
        public Mage(string Name) : base(Name)
        {
            LevelAttributes = new HeroAttributes(1, 1, 8);
            LevelUpAttributes = new HeroAttributes(1, 1, 5);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Staffs, WeaponType.Wands };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Cloth };
        }

        public override double DoDamage()
        {
            Weapon Weapon = (Weapon)Equipment[Slot.Weapon];
            double Damage = (Weapon !=null) ? Weapon.WeaponDamage : 1;
            return Damage*(1 + (double)TotalAttributes().Intelligence / (double)100);
        }


    }
}
