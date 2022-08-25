using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class BurritoFactory
    {
        public static IBurrito GetBurrito(string burritoType)
        {
            
            switch(burritoType.ToLower())
            {
                case "breakfast":
                case "braekfast":
                    return new Breakfast();

                case "dinner":
                case "regular":
                    return new Dinner();

                default:
                    return new Dinner();
            }
            
        }

        
    }
}
