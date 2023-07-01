using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Concrete class for horses (inherits from Mammal)
    public class Horse : Mammal
    {
        // Concrete property
        public override string FurColor { get; set; }

        // Constructor
        public Horse(string name, int age, double weight, string furColor) : base(name, age, weight)
        {
            FurColor = furColor;
        }
        // Concrete methods
        public override string Sound()
        {
            return "Neigh!";
        }

        public override string GiveBirth()
        {
            return "The horse gives birth to a foal.";
        }

        // Override virtual methods
        public override string Sleep()
        {
            return "The horse is lying down and resting.";
        }

        // Override virtual methods
        public override string Eat()
        {
            return "The horse is eating hay.";
        }
    }
}
