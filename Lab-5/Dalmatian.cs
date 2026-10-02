using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Dalmatian : Dog
    {
        public int NumberOfSpots { get; set; } = 50;

        public Dalmatian(string name, int age, double weight, string gender, string species, string breed, int numberOfSpots) :
            base(name, age, weight, gender, species, breed)
        {
            NumberOfSpots = numberOfSpots;  
        }


            public void ShowSpots()
            {
                Console.WriteLine($"{Name} has {NumberOfSpots} spots.");
            }
        }
    }

