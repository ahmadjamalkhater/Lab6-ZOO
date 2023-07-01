using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Concrete class for turtles (inherits from Reptile)
    public class Turtle : Reptile
    {
        // Concrete property
        public override string SkinColor { get; set; }

        // Constructor
        public Turtle(string name, int age, double weight, string skinColor) : base(name, age, weight)
        {
            SkinColor = skinColor;
        }

        // Concrete methods
        public override string Sound()
        {
            return "Hiss when it scared!";
        }

        public override string LayEggs()
        {
            return "The turtle lays eggs on land.";
        }

        public override string Sunbathe()
        {
            return "The turtle basks in the sun to warm up.";
        }

        // Override virtual methods
        public override string Sleep()
        {
            return "The turtle finds a safe spot and rests.";
        }

        // Override virtual methods
        public override string Eat()
        {
            return "The turtle eats plants and small aquatic creatures.";
        }
    }
}
