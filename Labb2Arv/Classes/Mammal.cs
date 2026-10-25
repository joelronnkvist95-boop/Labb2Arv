using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Labb2Arv.Classes
{
    public class Mammal : Animal
    {
        public bool Fur { get; set; } = true;

        public Mammal(string name, int age, double weight, string sound, double speed, bool fur)
            : base(name, age, weight, sound, speed)
        {

            Fur = fur;
        }

        public void GiveBirth()
        {
            Console.WriteLine("The mammal gives birth live young instead of laying eggs");
        }

       
    }
}
