using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{

    internal class Cat : Animal
    {
        public bool LikesClimbing { get; set; } = true;

        public Cat(string name, int age, double weight, string gender, string species, bool likesClimbing) : base(name, age, weight, gender, species)
        {
            LikesClimbing = likesClimbing;
        }   

        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching.");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Meow! ");
        }
    }
}
