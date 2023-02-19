using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, int requiredLevel, Slot slot, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel)
        {
            if (slot != Slot.Weapon)
            {
                throw new InvalidWeaponException("cant do this bro code");
            }
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }

        public int WeaponDamage { get; set; }
        public WeaponType WeaponType { get; set; }
    }
}
