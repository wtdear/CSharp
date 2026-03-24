using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
