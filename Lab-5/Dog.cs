using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    // Dog inherits from Animal.
    internal class Dog : Animal
    {
        //New property that only dogs have
        public string Breed { get; set; } = "Mixed";

     //Constructor passes the shared values to Animal using base (..) and sets the dog-specific value itself.
        public Dog (string name, int age, double weight, string gender, string breed = "Mixed") : base(name, age, weight, gender, "Dog")
        {
            Breed = breed;
        }

        //New method that only dogs have
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching.");
        }

        //Overrides the base method so the dog barks instead of generic sound.
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Woof! ");
        }
    }

    }
