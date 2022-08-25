using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Breakfast : IBurrito
    {
        public Breakfast()
        {
            Type = GetInnards.InnerBreakfastBurrito();
        }
        public string Type { get; set; }
        public void RollItUp()
        {
            Console.WriteLine($"Rolling that {Type} Breakfast Burrito!");
        }
    }
}
