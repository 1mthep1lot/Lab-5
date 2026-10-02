using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Lion : Animal
    {
        public bool HasMane { get; set; } = true;   

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
