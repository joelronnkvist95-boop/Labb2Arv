using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Labb2Arv.Classes
{
    public class Mouse : Mammal
    {
        public bool HideInWall { get; set; } = false;

        public Mouse(string name, int age, double weight, string sound, double speed, bool fur, bool hideInWall)
            :base(name, age, weight, sound, speed, fur)
        {
            HideInWall = hideInWall;
        }
        public void GetCheese()
        {
            Console.WriteLine("The mouse is chasing cheese");
        }
    }
}
