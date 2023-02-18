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
        public ArmorType ArmorTypeArmor { get; set; }

    }
}
