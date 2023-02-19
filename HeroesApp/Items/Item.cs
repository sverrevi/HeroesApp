using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{
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
