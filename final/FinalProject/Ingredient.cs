using System;

public class Ingredient
{
    private FoodItem food;
    private double quantity; // grams

    public FoodItem Food { get => food; set => food = value; }
    public double Quantity { get => quantity; set => quantity = value; }

    public void DisplayIngredient()
    {
        Console.WriteLine($"{Quantity}g of {Food.Name}");
    }
}