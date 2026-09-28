using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }

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
            Console.WriteLine($"{Name} is sleeping.");
        }


    }





}
