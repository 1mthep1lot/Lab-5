using System;


namespace Lab_5
{
    // Base class that holds everything all zoo animals have in common.
    internal class Animal
    {
        // Constructor runs when a new animal is created and stores the shared values.
        public Animal(string name, int age, double weight, string gender, string species)
        {
           Name = name;
           Age = age;
           Weight = weight;
           Gender = gender;
           Species = species;
        }


        // Five shared properties with default values. The value after "=" is the default value. get = ready it set = change it.
        public string Name { get; set; } = "Unknown";   
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0.0;   
        public string Gender { get; set; } = "Unknown"; 
        public string Species { get; set; } = "Unknown";    

        //Shared methods that every animal inherits.
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public void Drink()
        {
            Console.WriteLine($"{Name} is drinking.");
        }

        // Marked virtual so that subclasses can override it with their own version.
        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} is making a sound.");
        }

    }


}
