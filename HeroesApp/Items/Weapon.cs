using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{
    public class Weapon : Item
    {
        public int WeaponDamage { get; set; }
        public WeaponType WeaponTypeWeapon { get; set; }
    }
}
