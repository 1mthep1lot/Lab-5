using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    internal class Bulldog :Dog
    {
            public bool IsStrong { get; set; } = true;  

            public void Guard()
            {
                Console.WriteLine($"{Name} is guarding.");
            }   
        }
    }

