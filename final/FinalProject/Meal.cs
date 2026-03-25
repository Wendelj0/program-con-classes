using System;
using System.Collections.Generic;

public class Meal
{
    private List<Ingredient> ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => ingredients.Add(ingredient);
    public void RemoveIngredient(Ingredient ingredient) => ingredients.Remove(ingredient);

    public void DisplayMeal()
    {
        Console.WriteLine("Meal ingredients:");
        foreach (var ing in ingredients)
        {
            ing.DisplayIngredient();
        }
    }
}