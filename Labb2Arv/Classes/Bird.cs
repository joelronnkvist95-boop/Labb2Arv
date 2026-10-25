using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Labb2Arv.Classes
{
    class Bird : Animal
    {
        public bool Feathers { get; set; } = true;

        public Bird(string name, int age, double weight, string sound, double speed, bool feathers)
            : base(name, age, weight, sound, speed)

        {

            Feathers = feathers;
        }



        public void Fly()
        {
            Console.WriteLine($"{Name} took flight");
        }

        
    }
}
