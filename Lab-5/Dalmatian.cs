using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Dalmatian : Dog
    {
        public int NumberOfSpots { get; set; } = 50;
           
            public void Run()
            {
                Console.WriteLine($"{Name} has {NumberOfSpots} spots.");
            }
        }
    }

