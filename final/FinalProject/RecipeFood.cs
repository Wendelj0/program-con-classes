using System.Collections.Generic;

public class RecipeFood : FoodItem
{
    private List<Ingredient> _ingredients;

    public RecipeFood(string name) : base(name)
    {
        _ingredients = new List<Ingredient>();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public List<Ingredient> GetIngredients()
    {
        return _ingredients;
    }

    public override double GetCalories()
    {
        double total = 0;

        foreach (Ingredient ingredient in _ingredients)
        {
            total += ingredient.GetCalories();
        }

        return total;
    }

    public override double GetProtein()
    {
        double total = 0;

        foreach (Ingredient ingredient in _ingredients)
        {
            total += ingredient.GetProtein();
        }

        return total;
    }

    public override double GetCarbs()
    {
        double total = 0;

        foreach (Ingredient ingredient in _ingredients)
        {
            total += ingredient.GetCarbs();
        }

        return total;
    }

    public override double GetFats()
    {
        double total = 0;

        foreach (Ingredient ingredient in _ingredients)
        {
            total += ingredient.GetFats();
        }

        return total;
    }

    public override string GetDetails()
    {
        return _name + " (Recipe) | Calories: " + GetCalories() +
               " Protein: " + GetProtein() +
               " Carbs: " + GetCarbs() +
               " Fats: " + GetFats();
    }
}