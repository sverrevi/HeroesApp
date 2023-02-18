using HeroesApp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int level;
        public Dictionary <Slots, Item> Equipment { get; set; }
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributes LevelUpAttributes { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        
        protected Hero(string name)
        {
            Name = name;
            level = 1;
            Equipment = new Dictionary<Slots, Item> { 
                [Slots.Weapon] = null, 
                [Slots.Head] = null,
                [Slots.Body] = null, 
                [Slots.Legs] = null
            };

        }

        //The level up method
        public void LevelUp()
        {
            level += 1;
            LevelAttributes = LevelUpAttributes + LevelAttributes;

        }


        public HeroAttributes TotalAttributes()
        { 
            return LevelAttributes;
            
        }

        public HeroAttributes EquipWeapon() 
        {
            return null;
        }

        public HeroAttributes EquipArmor()
        {
            return null;
        }
        public abstract double doDamage();
        
        public void equipWeapon(Weapon weapon)
        {
            Equipment [Slots.Weapon] = weapon;
        }



    }
}
