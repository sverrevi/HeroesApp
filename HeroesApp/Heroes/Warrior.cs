using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Heroes
{
    public class Warrior: Hero
    {
        public Warrior(string Name) : base(Name)
        {
            LevelAttributes = new HeroAttributes(1, 1, 8);
            LevelUpAttributes = new HeroAttributes(3, 2, 1);
        }

        public List<String> validWeaponTypes;
    }
}
