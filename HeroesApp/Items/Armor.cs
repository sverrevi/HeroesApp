using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{
    public class Armor: Item
    {
        public HeroAttributes ArmorAttributes { get; set; }
        public ArmorType ArmorType { get; set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType, HeroAttributes armorAttributes) : base(name, requiredLevel)
        {
            if (slot == Slot.Weapon)
            {
                throw new InvalidArmorException("You can not equip this armor at your current level");
            }
            ArmorAttributes = armorAttributes;
            ArmorType = armorType;
            Slot = slot;
        }
    }
}
