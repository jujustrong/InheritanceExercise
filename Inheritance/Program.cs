using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            // Create a class Animal
            // give this class 4 members that all Animals have in common
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird();
            bird1.Sound = "Caw Caw";
            bird1.Wingspan = 5;
            bird1.NestType = "Classic Bowl Nest";
            bird1.CanFly = true;
            bird1.Habitat = "forest";
            bird1.Species = "Crow";
            bird1.Name = "Sylus";
            bird1.Age = 7;
            
            bird1.birdStats();
            Console.WriteLine("----------------------------------");
            bird1.AnimalStats();
            Console.WriteLine();
            bird1.fly();
            Console.WriteLine();

            var reptile1 = new Reptile();
            reptile1.Name = "Chris";
            reptile1.Diet = "meat";
            reptile1.Legs = 4;
            reptile1.GaitPattern = "waddle";
            reptile1.TongueColor = "purple";
            reptile1.Species = "Komodo Dragon";
            reptile1.Age = 15;
            reptile1.Habitat = "tropical forest";
            reptile1.IsHungry = true;
            
            reptile1.reptileStats();
            Console.WriteLine("----------------------------------");
            reptile1.AnimalStats();
            Console.WriteLine();
            reptile1.hunt();
        }
    }
}
