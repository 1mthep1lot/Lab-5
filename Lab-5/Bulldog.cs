using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Bulldog :Dog
    {
            public bool IsStrong { get; set; } = true;  

        public Bulldog(string name, int age, double weight, string gender, string species, string breed, bool isStrong) 
            : base(name, age, weight, gender, species, breed)
        {
            IsStrong = isStrong;
        }

        public void Guard()
            {
                Console.WriteLine($"{Name} is guarding.");
            }   
        }
    }

