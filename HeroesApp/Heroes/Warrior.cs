using HeroesApp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Heroes
{
    /// <summary>
    /// The Warrior class inherits from the hero class, uses the name when a hero is created and sets the individual attributes corresponding to the
    /// warrior hero type. The doDamage method included in this deals damage based upon the warriors attributes and overrides the method from the 
    /// hero class. 
    /// </summary>
    public class Warrior: Hero
    {
        public Warrior(string Name) : base(Name)
        {
            LevelAttributes = new HeroAttributes(5, 2, 1);
            LevelUpAttributes = new HeroAttributes(3, 2, 1);
            ValidWeaponTypes = new List<WeaponType>  { WeaponType.Axes, WeaponType.Hammers, WeaponType.Swords };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Mail, ArmorType.Plate };
        }

        

        public override double DoDamage()
        {
            Weapon Weapon = (Weapon)Equipment[Slot.Weapon];
            double Damage = (Weapon != null) ? Weapon.WeaponDamage : 1;
            return Damage * (1 + (double)TotalAttributes().Strength/(double)100);
        }
    }
}
