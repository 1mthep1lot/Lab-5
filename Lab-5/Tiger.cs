using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Lion : Animal
    {
        public bool HasMane { get; set; } = true;   

        public Lion(string name, int age, double weight, string gender, string species, bool hasMane) : base(name, age, weight, gender, species)
        {
            HasMane = hasMane;
        }   

        public void Roar()
        {
            Console.WriteLine($"{Name} is roaring.");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Roar! ");
        }

    }
}
