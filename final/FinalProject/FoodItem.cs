using System;

public class FoodItem
{
    private string name;
    private double calories;
    private double protein;
    private double carbs;
    private double fat;

    public string Name { get => name; set => name = value; }
    public double Calories { get => calories; set => calories = value; }
    public double Protein { get => protein; set => protein = value; }
    public double Carbs { get => carbs; set => carbs = value; }
    public double Fat { get => fat; set => fat = value; }

    public virtual void DisplayNutrition()
    {
        Console.WriteLine($"{Name}: {Calories} cal, {Protein}g protein, {Carbs}g carbs, {Fat}g fat");
    }
}