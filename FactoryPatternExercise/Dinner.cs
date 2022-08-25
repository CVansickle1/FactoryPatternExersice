using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Dinner : IBurrito
    {
        public Dinner()
        {
            Type = GetInnards.InnerDinnerBurrito();
        }
        public string Type { get; set; }
        public void RollItUp()
        {
            Console.WriteLine($"Rolling that {Type} Burrito!");
        }
    }
}
