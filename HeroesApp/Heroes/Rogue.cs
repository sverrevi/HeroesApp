using HeroesApp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Heroes
{
    public class Rogue: Hero
    {
        public Rogue(string Name) : base(Name)
        {
            LevelAttributes = new HeroAttributes(2, 6, 1);
            LevelUpAttributes = new HeroAttributes(1, 4, 1);
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
