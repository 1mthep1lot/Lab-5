using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Bulldog :Dog
    {
            public bool IsWrinkly { get; set; } = true;  

        public Bulldog(string name, int age, double weight, string gender, string species, string breed, bool isWrinkly) 
            : base(name, age, weight, gender, species, breed)
        {
            IsWrinkly = isWrinkly;
        }

        public void ShowWrinkles()
            {
                Console.WriteLine($"{Name} has wrinkles.");
            }   
        }
    }

