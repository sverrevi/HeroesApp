using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{/// <summary>
/// A class for generating Items. This is a parent class for two types of Items: Armor and Weapon. The class itself only
/// requires a name and required level, but its children classes Armor and Weapon have more specific inputs.
/// </summary>
    public abstract class Item
    {
        public string Name { get; }
        public int RequiredLevel { get; }
        public Slot Slot { get; protected set; }

        public Item(string name, int requiredLevel)
        {
            Name = name;
            RequiredLevel = requiredLevel;
        }
    }
}
