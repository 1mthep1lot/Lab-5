using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    //Lion inherits from Animal.
    internal class Lion : Animal
    {
        //New lion specific property with a default value.
        public bool HasMane { get; set; } = true;   

        public Lion(string name, int age, double weight, string gender, bool hasMane = true) : base(name, age, weight, gender, "Lion")
        {
            HasMane = hasMane;
        }   

        //New Lion method.
        public void Roar()
        {
            Console.WriteLine($"{Name} is roaring.");
        }

        //Lion´s own sound.
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Roar! ");
        }

    }
}
