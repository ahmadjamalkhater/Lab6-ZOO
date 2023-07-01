using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ZOO
{
    // Abstract base class for animals
    public abstract class Animal
    {
        // Properties
        public string? Name { get; set; }
        public int Age { get; set; }

        // Virtual property
        public virtual double Weight { get; set; }
        public virtual bool IsWarmBlooded { get; set; }

        // Constructor
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight; //override virtual property
        }

        // Abstract method
        public abstract string Sound();

        // Virtual methods
        public virtual string Sleep()
        {
            return "The animal is sleeping.";
        }

        public virtual string Eat()
        {
            return "The animal is eating.";
        }

    }
}
