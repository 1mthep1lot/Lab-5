using System;
using System.Collections.Generic;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> zoo = new List<Animal>
             {
            new Dog("Shellby", 3, 15.5, "Female", "Labrador"),

            new Cat("Whiskers", 2, 10.2, "Male"),

            new Lion("Simba", 5, 420.0, "Male"),

            new Bulldog("Woofy", 4, 25.0, "Male"),

           new Dalmatian("Spots", 3, 20.0, "Female", 87),
                };

            foreach (Animal animal in zoo)
            {
                animal.makeSound();
            }
            Bulldog bulldog = new Bulldog("Woofy", 4, 25.0, "Male");
            Dalmatian dalmatian = new Dalmatian("Spots", 3, 20.0, "Female");
            bulldog.ShowWrinkles();
            dalmatian.ShowSpots();

            bulldog.Eat();
        }
    }
}
