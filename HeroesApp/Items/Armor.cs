using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{/// <summary>
/// The child class of Item, and inherits the name and required level. 
/// In the constructor, the class ensures that the particular hero can equip this armor. If it can't, 
/// it throws a customException.
/// </summary>
    public class Armor: Item
    {
        public HeroAttributes ArmorAttributes { get; set; }
        public ArmorType ArmorType { get; set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType, HeroAttributes armorAttributes) : base(name, requiredLevel)
        {
            if (slot == Slot.Weapon)
            {
                throw new InvalidArmorException("You can not equip armor at weapon slot");
            }
            ArmorAttributes = armorAttributes;
            ArmorType = armorType;
            Slot = slot;
        }
    }
}
