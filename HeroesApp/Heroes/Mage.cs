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
        }
        
        
            
        /*public EquipArmor()
        {
            //some code goes in here
        }
        
        public EquipWeapons()
        {
            //some code goes in here
        }
        */

    }
}
