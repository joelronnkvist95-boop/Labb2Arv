using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Labb2Arv.Classes
{
    class Reptile : Animal
    {
        

        public bool Scales { get; set; } = true;

        public Reptile(string name, int age, double weight, string sound, double speed, bool scales)
            :base(name, age, weight, sound, speed)
        {

            Scales = scales;
        }

        public void Crawl()
        {
            Console.WriteLine($"{Name} is now crawling");
        }


    }
}
