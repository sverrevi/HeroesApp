using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Items
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slots Slot { get; set; }
        
        

        
    }
}
