

using FactoryPatternExercise;

Console.WriteLine("Hello Lets Build a Burrito!");
Console.WriteLine("What are you in the mood for? \nBreakfast \nDinner");

var burrito = Console.ReadLine();

var awnser = BurritoFactory.GetBurrito(burrito);

awnser.RollItUp();