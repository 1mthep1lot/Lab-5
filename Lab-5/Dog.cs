using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Dog : Animal
    {
        public string Breed { get; set; } = "Mixed";

        public Dog (string name, int age, double weight, string gender, string species, string breed) : base(name, age, weight, gender, species)
        {
            Breed = breed;
        }
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching.");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Woof! ");
        }
    }

    }
