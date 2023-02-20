using HeroesApp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Heroes
{
    public class Ranger: Hero
    {
        public Ranger(string Name) : base(Name)
        {
            LevelAttributes = new HeroAttributes(1, 7, 1);
            LevelUpAttributes = new HeroAttributes(1, 5, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Bows };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        }

        public List<String> validWeaponTypes;

        public override double DoDamage()
        {
            Weapon Weapon = (Weapon)Equipment[Slot.Weapon];
            double Damage = (Weapon != null) ? Weapon.WeaponDamage : 1;
            return Damage * (1 + (double)TotalAttributes().Dexterity / (double)100);
        }
    }
}
