using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Concrete class for snakes (inherits from Reptile)
    public class Snake : Reptile
    {
        // Concrete property
        public override string SkinColor { get; set; }

        // Constructor
        public Snake(string name, int age, double weight, string skinColor) : base(name, age, weight)
        {
            SkinColor = skinColor;
        }

        // Concrete methods
        public override string Sound()
        {
            return "Hiss!";
        }

        public override string LayEggs()
        {
            return "The snake lays eggs.";
        }

        public override string Sunbathe()
        {
            return "The snake sunbathes to regulate its body temperature.";
        }

        // Override virtual methods
        public override string Sleep()
        {
            return "The snake coils up and rests.";
        }

        // Override virtual methods
        public override string Eat()
        {
            return "The snake swallows its prey whole.";
        }

    }
}
