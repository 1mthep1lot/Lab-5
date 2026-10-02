using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Animal
    {
        public string Name { get; set; } = "Unknown";   
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0.0;   
        public string Gender { get; set; } = "Unknown"; 
        public string Species { get; set; } = "Unknown";    

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


    }


}
