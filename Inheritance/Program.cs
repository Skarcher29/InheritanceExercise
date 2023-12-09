using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird()
            {
                WingSpanCM = 81,
                CanFly = false,
                WingColor = "black",
                DoMigrate = false

            };

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "jungle",
                CanGrowTail = true,
            };

            var myAnimals = new Animal[] { bird, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Mammal: {animal.IsMammal}");
                Console.WriteLine($"Legs: {animal.LegCount}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"");
            }
        }
    }
}
