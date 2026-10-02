using System;


namespace Lab_5
{
    //Bulldog inherits from Dog, which inherits from Animal. It has everything Dog has and everything Animal has.
    internal class Bulldog : Dog

        //unique property for bulldogs.
    {
        public bool IsWrinkly { get; set; } = true;

        //Passes everything the Dog constructor needs with base(..).

        //The breed is always "Bulldog" so the user doesnt have to type it.

        public Bulldog(string name, int age, double weight, string gender, bool isWrinkly = true)
            : base(name, age, weight, gender, "Bulldog")
        {
            IsWrinkly = isWrinkly;
        }

        //unique method for bulldogs.

        public void ShowWrinkles()
        {
            Console.WriteLine($"{Name} has wrinkles.");
        }

        //overrides the Dog´s sound so that the bulldog sounds different from other dogs.
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says: Wuff Wuff (a deep, grumpy bark ¬_¬) ");
        }
    }
}

