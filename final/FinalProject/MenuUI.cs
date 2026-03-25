using System;

public class MenuUI
{
    public void ShowMenu()
    {
        Console.WriteLine("\n--- Macro Calculator Menu ---");
        Console.WriteLine("1. Display user info");
        Console.WriteLine("2. Display daily log");
        Console.WriteLine("3. Exit");
    }

    public int GetUserChoice()
    {
        Console.Write("Enter choice: ");
        return int.Parse(Console.ReadLine());
    }
}