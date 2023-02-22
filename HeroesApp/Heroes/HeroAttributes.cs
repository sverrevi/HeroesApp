using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp
{/// <summary>
/// The class sets the HeroAttributes, which are three inputs relating to what the particular hero is good at. These are measured in 
/// integer values. The class also contains an overlading operator method which allows other parts of the code to add different 
/// instances together such that the object attributes compounds on each other. 
/// </summary>
    public class HeroAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttributes(int Strength, int Dexterity, int Intelligence) 
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
        }
        

        public static HeroAttributes operator + (HeroAttributes rhs, HeroAttributes lhs)
        {
            return new HeroAttributes(lhs.Strength + rhs.Strength, 
                lhs.Dexterity + rhs.Dexterity, lhs.Intelligence + rhs.Intelligence);
            
        }

    }    
}
