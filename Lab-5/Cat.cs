using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    //Cat inherits from Animal.
    internal class Cat : Animal
    {

        //New cat specific property with a default value.
        public bool LikesClimbing { get; set; } = true;

        public Cat(string name, int age, double weight, string gender, bool likesClimbing = true) : base(name, age, weight, gender, "Cat")
        {
            LikesClimbing = likesClimbing;
        }

        //New cat specific method.
        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching.");
        }

        //Cat´s own sound.
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Meow! ");
        }
    }
}
