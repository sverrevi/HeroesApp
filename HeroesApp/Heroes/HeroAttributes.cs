using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp
{
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
