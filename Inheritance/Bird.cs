using System;

namespace Inheritance;

public class Bird : Animal
{
    public double Wingspan { get; set; }
    public string Sound { get; set; }
    public string NestType { get; set; }
    public bool CanFly { get; set; }

    public void BirdStats()
    {
        Console.WriteLine($"Hello my name is {Name} and I am {Age} years old. \n" +
                          $"My wingspan is about {Wingspan} inches wide and \n" +
                          $"my nest is typically a {NestType}. The habitat I am \n" +
                          $"happiest in is usually a {Habitat}");
    }

    public void Fly()
    {
        if (CanFly) { Console.WriteLine($"{Name} has flown away!"); }
        else { Console.WriteLine($"{Name} has is hopping away!"); }
    }
}