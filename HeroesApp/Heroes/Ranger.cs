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
        }

        public List<String> validWeaponTypes;

        public override double DoDamage()
        {
            return 2;
        }
    }
}
