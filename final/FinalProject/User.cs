using System;

public class User
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Age { get; set; }
    public string Goal { get; set; } // gain, lose, maintain

    public void DisplayUserInfo()
    {
        Console.WriteLine($"{Name}, Age: {Age}, Weight: {Weight}, Goal: {Goal}");
    }
}