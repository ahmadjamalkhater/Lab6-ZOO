using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Concrete class for dogs (inherits from DomesticatedMammal)
    public class Dog : DomesticatedMammal
    {
        // Concrete property
        public override string FurColor { get; set; }

        // Constructor
        public Dog(string name, int age, double weight, string furColor) : base(name, age, weight)
        {
            FurColor = furColor;
        }
        // Concrete methods
        public override string Sound()
        {
            return "Woof woof!";
        }

        public override string GiveBirth()
        {
            return "The dog gives birth to puppies.";
        }

        public override string LiveInsideHomes()
        {
            return "People love dogs to cuddle with them.";
        }

        // Override virtual methods
        public override string Sleep()
        {
            return "The dog is lying down and resting.";
        }

        // Override virtual method
        public override string Eat()
        {
            return "The dog is eating dog food.";
        }
    }
}
