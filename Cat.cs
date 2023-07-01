using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Concrete class for cats (inherits from DomesticatedMammal)
    public class Cat : DomesticatedMammal
    {
        // Concrete property
        public override string FurColor { get; set; }

        // Constructor
        public Cat(string name, int age, double weight, string furColor) : base(name, age, weight)
        {
            FurColor = furColor;
        }

        // Concrete methods
        public override string Sound()
        {
            return "Meow!";
        }

        public override string GiveBirth()
        {
            return "The cat gives birth to kittens.";
        }

        public override string LiveInsideHomes()
        {
            return "People love cats to cuddle with them.";
        }

        // Override virtual methods
        public override string Sleep()
        {
            return "The cat is curling up and taking a nap.";
        }

        // Override virtual methods
        public override string Eat()
        {
            return "The cat is eating cat food.";
        }
    }
}
