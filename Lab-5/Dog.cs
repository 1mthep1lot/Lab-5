using System;


namespace Lab_5
{
    // Dog inherits from Animal. It gets Name, Age, Eat(), Sleep() and so on.
    internal class Dog : Animal
    {
        //New property that only dogs have witha  default value.
        public string Breed { get; set; } = "Mixed";

        //Constructor : base sends the shared values up to Animals constructor. 
        // The species is alwats "Dog" for this class, so Dog sets it itself.
        // breed is optional, if it is left out, it will be "Mixed" by default.
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
