using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{/// <summary>
/// The child class of Item, and inherits the name and required level. 
/// In the constructor, the class ensures that the particular hero can equip this armor. If it can't, 
/// it throws a customException.
/// </summary>
    public class Weapon : Item
    {
        public Weapon(string name, int requiredLevel, Slot slot, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel)
        {
            if (slot != Slot.Weapon)
            {
                throw new InvalidWeaponException("cant do this bro");
            }
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }

        public int WeaponDamage { get; set; }
        public WeaponType WeaponType { get; set; }
    }
}
