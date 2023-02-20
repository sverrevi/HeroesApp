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

        public void LevelUp()
        {
            Level += 1;
            LevelAttributes = LevelUpAttributes + LevelAttributes;

        }

        public HeroAttributes TotalAttributes()
        {
            HeroAttributes TotalAttributes = LevelAttributes;

            foreach (KeyValuePair<Slot, Item> equipment in Equipment)
            {
                if (equipment.Value is Armor)
                {
                    Armor armor = equipment.Value as Armor;
                    TotalAttributes += armor.ArmorAttributes;
                }
                Armor Armor = equipment.Value as Armor;
            }

            return TotalAttributes;
        }

        //The DoDamage method is overriden in children classes
        public abstract double DoDamage();
        
        public void Equip(Weapon Weapon)
        {
            if (!ValidWeaponTypes.Contains(Weapon.WeaponType))
            {
                throw new InvalidWeaponException($"{this.GetType().Name} can not equip {Weapon.WeaponType}");
            }

            if (Weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"Not high enough level. Your current level is {Level}, while the required level to equip {Weapon.Name} is {Weapon.RequiredLevel}");
            }

            Equipment[Slot.Weapon] = Weapon;
        }

        public void Equip(Armor Armor)
        {
            if (!ValidArmorTypes.Contains(Armor.ArmorType))
            {
                throw new InvalidArmorException($"{this.GetType().Name} can not equip {Armor.ArmorType}");
            }
            if (Armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException($"Not high enough level. Your current level is {Level}, while the required level to equip {Armor.Name} is {Armor.RequiredLevel}");
            }
            Equipment[Armor.Slot] = Armor;
        }

        public string Display()
        {
            StringBuilder StringBuild = new StringBuilder("\n");
            StringBuild.Append("Name: " + Name + "\n");
            StringBuild.Append("Class: " + GetType().ToString().Split('.').Last() + "\n");
            StringBuild.Append("Level: " + Level + "\n");
            StringBuild.Append("Strength: " + TotalAttributes().Strength + "\n");
            StringBuild.Append("Dexterity: " + TotalAttributes().Dexterity + "\n");
            StringBuild.Append("Intelligence: " + TotalAttributes().Intelligence + "\n");
            StringBuild.Append("Damage: " + DoDamage() + "\n");

            return StringBuild.ToString();
        }
    }
}
