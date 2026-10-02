using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching.");
        }
    }
}
