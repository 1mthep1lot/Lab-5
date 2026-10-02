using System;
using System.Collections.Generic;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of any kind of animals, which works because Dog, Cat, Lion, Bulldog, and Dalmatian all inherit from Animal.
            List<Animal> zoo = new List<Animal>
             {
            new Dog("Shellby", 3, 15.5, "Female", "Labrador"),

            new Cat("Whiskers", 2, 10.2, "Male"), // likesClimbing uses default value (true)

            new Lion("Simba", 5, 420.0, "Male"), // hasMane uses default value (true)

            new Bulldog("Barky", 4, 25.0, "Male"), // isWrinkly uses default value (true)

           new Dalmatian("Dotty", 3, 20.0, "Female", 87), //custom number of spots.
                };

            //Polymprhism, the loop treats every item as an Animal and calls the same method, makeSound().
            //Each object runs its own version of it because the subclasses override the method. So the same line of code gives different result.

            foreach (Animal animal in zoo)
            {
                animal.makeSound();
            }
            Bulldog bulldog = new Bulldog("Woofy", 4, 25.0, "Male");
            Dalmatian dalmatian = new Dalmatian("Spots", 3, 20.0, "Female");
            bulldog.ShowWrinkles();
            dalmatian.ShowSpots();

            // Eat() is defined in Animal, but Bulldog gets it through Dog.
            bulldog.Eat();
        }
    }
}
