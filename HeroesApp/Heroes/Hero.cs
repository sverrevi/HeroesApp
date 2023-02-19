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
        public int Level { get; set; }
        public Dictionary <Slot, Item> Equipment { get; set; }
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributes LevelUpAttributes { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        
        protected Hero(string name)
        {
            Name = name;
            Level = 1;
            Equipment = new Dictionary<Slot, Item>
            {
                [Slot.Weapon] = null,
                [Slot.Head] = null,
                [Slot.Body] = null,
                [Slot.Legs] = null
            };
            ValidWeaponTypes = new List<Items.WeaponType>();
            ValidArmorTypes = new List<Items.ArmorType>();
        }

        //The level up method
        public void LevelUp()
        {
            Level += 1;
            LevelAttributes = LevelUpAttributes + LevelAttributes;

        }

        public HeroAttributes TotalAttributes()
        { 
            return LevelAttributes;
            
        }

        //The doDamage method is overriden in children classes
        public abstract double DoDamage();
        
        public void Equip(Weapon Weapon)
        {
            if (!ValidWeaponTypes.Contains(Weapon.WeaponType))
            {
                throw new InvalidWeaponException($"{this.GetType().Name} can not equip INSERT WEAPON NAME L8R");
            }

            if (Weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException("Not high enough level");
            }

            Equipment[Slot.Weapon] = Weapon;
        }

        public void Equip(Armor Armor)
        {
            Equipment[Armor.Slot] = Armor;
        }
    }
}
