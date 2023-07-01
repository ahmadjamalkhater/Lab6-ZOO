using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Abstract class for reptiles (inherits from Animal)
    public abstract class Reptile : Animal
    {
        // Abstract property
        public abstract string SkinColor { get; set; }

        //override virtual property
        public override bool IsWarmBlooded { get; set; }

        // Constructor
        public Reptile(string name, int age, double weight) : base(name, age, weight)
        {
            IsWarmBlooded = false;//override virtual property
        }

        // Abstract methods
        public abstract string LayEggs();
        public abstract string Sunbathe();
    }
}
