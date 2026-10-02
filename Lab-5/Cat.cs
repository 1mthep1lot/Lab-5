using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{

    internal class Cat : Animal
    {
        public bool LikesClimbing { get; set; }

        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching.");
        }
    }
}
