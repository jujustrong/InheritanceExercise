using System;

namespace Inheritance;

public class Reptile : Animal
{
    public string Diet { get; set; }
    public string TongueColor { get; set; }
    public int Legs { get; set; }
    public string GaitPattern { get; set; }
    public bool IsHungry { get; set; }

    public void ReptileStats()
    {
        Console.WriteLine($"Hello my name is {Name} and I am {Age} years old. \n" +
                          $"My tongue is {TongueColor} and you can typically find me eating \n" +
                          $"a lot of {Diet}. I typically like to {GaitPattern} around in a {Habitat}."
                          );
    }

    public void Hunt()
    {
        if (IsHungry) { Console.WriteLine($"LOOK OUT! {Name} is coming after you!"); }
        else { Console.WriteLine($"{Name} turns around and {GaitPattern}s away."); }
    }
}