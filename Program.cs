using System.Xml.Linq;
using System;

namespace Lab6_ZOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse("Gece", 3, 400, "Black");
            Console.WriteLine($"Horse Name: {horse.Name}");
            Console.WriteLine($"Age: {horse.Age}");
            Console.WriteLine($"Weight: {horse.Weight} kg");
            Console.WriteLine($"Fur Color: {horse.FurColor}");
            Console.WriteLine($"Is Warm-Blooded: {horse.IsWarmBlooded}");
            Console.WriteLine($"Sound: {horse.Sound()}");
            Console.WriteLine($"Give Birth: {horse.GiveBirth()}");
            Console.WriteLine($"Sleep: {horse.Sleep()}");
            Console.WriteLine($"Eat: {horse.Eat()}");
            Console.WriteLine();

            Dog dog = new Dog("Jack", 2, 10, "White");
            Console.WriteLine($"Dog Name: {dog.Name}");
            Console.WriteLine($"Age: {dog.Age}");
            Console.WriteLine($"Weight: {dog.Weight} kg");
            Console.WriteLine($"Fur Color: {dog.FurColor}");
            Console.WriteLine($"Is Warm-Blooded: {dog.IsWarmBlooded}");
            Console.WriteLine($"Sound: {dog.Sound()}");
            Console.WriteLine($"Give Birth: {dog.GiveBirth()}");
            Console.WriteLine($"Live Inside Homes (Domesticated): {dog.LiveInsideHomes()}");
            Console.WriteLine($"Sleep: {dog.Sleep()}");
            Console.WriteLine($"Eat: {dog.Eat()}");
            Console.WriteLine();

            Cat cat = new Cat("Karamel", 2, 5, "cinnamon");
            Console.WriteLine($"Cat Name: {cat.Name}");
            Console.WriteLine($"Age: {cat.Age}");
            Console.WriteLine($"Weight: {cat.Weight} kg");
            Console.WriteLine($"Fur Color: {cat.FurColor}");
            Console.WriteLine($"Is Warm-Blooded: {cat.IsWarmBlooded}");
            Console.WriteLine($"Sound: {cat.Sound()}");
            Console.WriteLine($"Give Birth: {cat.GiveBirth()}");
            Console.WriteLine($"Live Inside Homes (Domesticated): {cat.LiveInsideHomes()}");
            Console.WriteLine($"Sleep: {cat.Sleep()}");
            Console.WriteLine($"Eat: {cat.Eat()}");
            Console.WriteLine();

            Snake snake = new Snake("Slinky", 1, 3, "Yellow");
            Console.WriteLine($"Snake Name: {snake.Name}");
            Console.WriteLine($"Age: {snake.Age}");
            Console.WriteLine($"Weight: {snake.Weight} kg");
            Console.WriteLine($"Skin Color: {snake.SkinColor}");
            Console.WriteLine($"Is Warm-Blooded: {snake.IsWarmBlooded}");
            Console.WriteLine($"Sound: {snake.Sound()}");
            Console.WriteLine($"Lay Eggs: {snake.LayEggs()}");
            Console.WriteLine($"Sunbathe: {snake.Sunbathe()}");
            Console.WriteLine($"Sleep: {snake.Sleep()}");
            Console.WriteLine($"Eat: {snake.Eat()}");
            Console.WriteLine();

            Turtle turtle = new Turtle("Penny", 100, 7, "Dark Brown");
            Console.WriteLine($"Turtle Name: {turtle.Name}");
            Console.WriteLine($"Age: {turtle.Age}");
            Console.WriteLine($"Weight: {turtle.Weight} kg");
            Console.WriteLine($"Skin Color: {turtle.SkinColor}");
            Console.WriteLine($"Is Warm-Blooded: {turtle.IsWarmBlooded}");
            Console.WriteLine($"Sound: {turtle.Sound()}");
            Console.WriteLine($"Lay Eggs: {turtle.LayEggs()}");
            Console.WriteLine($"Sunbathe: {turtle.Sunbathe()}");
            Console.WriteLine($"Sleep: {turtle.Sleep()}");
            Console.WriteLine($"Eat: {turtle.Eat()}");

        }
    }
}