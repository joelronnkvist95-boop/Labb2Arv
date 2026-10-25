using Labb2Arv.Classes;

namespace Labb2Arv
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Charlie", 8, 10, "MAAAW", 3.2, true, true, false);
            cat1.PrintInfo();
            cat1.MakeSound();
            Console.WriteLine();

            Cat cat2 = new Cat("Vera", 7, 8, "meow", 4, true, true, true);
            cat2.PrintInfo();
            cat2.GiveBirth();
            cat2.MakeSound();
            Console.WriteLine();

            Cat cat3 = new Cat("Nala", 5, 4, "MEOW", 5, true, true, false);
            cat3.PrintInfo();
            cat3.MakeSound();
            cat3.ChaseMouse();
            cat3.Eat();
            Console.WriteLine();

            Mouse mouse1 = new Mouse("Jerry", 1, 0.025, "Squeak", 2, true, false);
            mouse1.PrintInfo();
            mouse1.MakeSound();
            mouse1.GetCheese();
            mouse1.Eat();
            Console.WriteLine();

            Bird bird1 = new Bird("Crow", 10, 0.6, "Kra Kra", 20, true);
            bird1.PrintInfo();
            bird1.MakeSound();
            bird1.Fly();
            bird1.Eat();
            Console.WriteLine();


            Reptile reptile1 = new Reptile("Crocodile", 71, 120, "GRRSH", 5, true);
            reptile1.PrintInfo();
            reptile1.MakeSound();
            reptile1.Crawl();
            reptile1.Eat();
        }
    }
}

        
