using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Dog : Animal
    {
        public string Breed { get; set; } = "Mixed";

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching.");
        }
    }
}
