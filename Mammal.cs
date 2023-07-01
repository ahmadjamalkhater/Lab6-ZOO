using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Abstract class for mammals (inherits from Animal)
    public abstract class Mammal : Animal
    {
        // Abstract property
        public abstract string FurColor { get; set; }

        //override virtual property
        public override bool IsWarmBlooded { get; set; }

        // Constructor
        public Mammal(string name, int age, double weight) : base(name, age, weight)
        {
            IsWarmBlooded = true; //override virtual property
        }

        // Abstract methods
        public abstract string GiveBirth();

    }
}

