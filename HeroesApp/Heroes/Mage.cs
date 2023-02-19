using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return 2;
        }


    }
}
