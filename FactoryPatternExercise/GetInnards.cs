using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class GetInnards
    {
       

        public static string InnerBreakfastBurrito()
        {
            Console.WriteLine("What would you like inside your burrito?");
            Console.WriteLine("We Have\n1: Sausage \n2: Bacon \n3: Ham");
            var numCheck = int.TryParse(Console.ReadLine(), out var choice);

            while (!numCheck)
            {
                Console.WriteLine("Please use 1-3 to Pick your option:");
                numCheck = int.TryParse(Console.ReadLine(), out choice);
            }

            switch (choice)
            {
                case 1:
                    return "Sausage";
                case 2:
                    return "Bacon";
                case 3:
                    return "Ham";
                default:
                    return "Meat-Lovers";
            }

        }


        public static string InnerDinnerBurrito()
        {
            Console.WriteLine("What would you like inside your burrito?");
            Console.WriteLine("We Have\n1: Steak \n2: Chicken \n3: Barbacoa");
            var numCheck = int.TryParse(Console.ReadLine(), out var choice);

            while(!numCheck)
            {
                Console.WriteLine("Please use 1-3 to Pick your option:");
                numCheck = int.TryParse(Console.ReadLine(), out choice);
            }

            switch(choice)
            {
                case 1:
                    return "Steak";
                case 2:
                    return "Chicken";
                case 3:
                    return "Barbacoa";
                default:
                    return "Veggie";
            }


        }



    }
}
