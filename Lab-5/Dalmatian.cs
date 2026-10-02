using System;


namespace Lab_5

    //Dalmatian also inherits from Dog which inherits from Animal.
{
    internal class Dalmatian : Dog
    {
       
        public int NumberOfSpots { get; set; } = 50;

        public Dalmatian(string name, int age, double weight, string gender, int numberOfSpots = 50) :
            base(name, age, weight, gender, "Dalmatian")
        {
            NumberOfSpots = numberOfSpots;  
        }

        //Unique method for Dalmatians.
        public void ShowSpots()
            {
                Console.WriteLine($"{Name} has {NumberOfSpots} spots.");
            }

        //Overrides the Dog´s sound so that the Dalmatian sounds different from other dogs.
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Woof woof (happy energetic bark:D)");
        }
        }
    }

