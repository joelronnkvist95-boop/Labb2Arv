using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Labb2Arv.Classes
{
    public abstract class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0.0;
        public string Sound { get; set; } = "Unknown";

        public double Speed { get; set; } = 0.0;

        public Animal(string name, int age, double weight, string sound, double speed)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Sound = sound;
            Speed = speed;
        }

        public void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Detta djur {Name} är {Age} år gammal och har vikten {Weight} kg. Djuret har hastigheten {Speed}m/s och dens läte är {Sound}. ");
        }
        public void Eat()
        {
            Console.WriteLine($"Gulp...");
        }

        
    }
} 
