using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Dalmatian
    {
        public class Dalmatian : Dog
        {
            public bool HasSpots { get; set; } = true;
           
            public void Run()
            {
                Console.WriteLine($"{Name} is running.");
            }
        }
    }
}
