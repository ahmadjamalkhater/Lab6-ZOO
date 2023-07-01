using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Abstract class for domesticated animals (inherits from Mammal)
    public abstract class DomesticatedMammal : Mammal
    {
        // Constructor
        public DomesticatedMammal(string name, int age, double weight) : base(name, age, weight)
        {
        }

        // Abstract method
        public abstract string LiveInsideHomes();
    }
}
