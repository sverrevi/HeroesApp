using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int level;
        public List <Weapon> ValidWeapons { get; set; }
        public List <Armor> ValidArmor { get; set; }
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributes LevelUpAttributes { get; set; }
        public List<string> items;
        protected Hero(string name)
        {
            Name = name;
            level = 1;

        }

        public void LevelUp()
        {
            level += 1;
            LevelAttributes = LevelUpAttributes + LevelAttributes;

        }


        public HeroAttributes TotalAttributes()
        { 
            return LevelAttributes;
            
        }



    }
}
