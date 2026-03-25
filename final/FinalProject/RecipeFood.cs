using System;
using System.Collections.Generic;

public class RecipeFood : FoodItem
{
    private List<Ingredient> ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        ingredients.Add(ingredient);
    }

    public override void DisplayNutrition()
    {
        Console.WriteLine($"{Name} (Recipe) nutrition calculation pending...");
    }
}