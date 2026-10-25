using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Arv.Classes
{
    public class Cat : Mammal
    {
        public bool IndoorCat { get; set; } = false;

        public bool IsTurtoiseShell { get; set; } = false;

        public Cat(string name, int age, double weight, string sound, double speed, bool fur, bool indoorCat, bool isTurtoiseShell)
            :base(name, age, weight, sound, speed, fur)
        {
            IndoorCat = indoorCat;
            IsTurtoiseShell = isTurtoiseShell;
        }


        public void ChaseMouse()
        {
            Console.WriteLine($"{Name} is going after the mouse!");
        }
    }
}
