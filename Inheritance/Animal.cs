using System;

namespace Inheritance;

public class Animal
{
    public string Habitat { get; set; }  //Forest, Ocean, Desert, etc.
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public void AnimalStats()
    {
        Console.WriteLine(
            $"This animal is a {Species} \n" +
            $"Its name is: {Name} \n" +
            $"It is {Age} years old \n" +
            $"You will typically find it in a {Habitat}"
            );
    }
}