public class Ingredient
{
    private FoodItem _food;
    private double _servings;

    public Ingredient(FoodItem food, double servings)
    {
        _food = food;
        _servings = servings;
    }

    public FoodItem GetFood()
    {
        return _food;
    }

    public double GetServings()
    {
        return _servings;
    }

    public double GetCalories()
    {
        return _food.GetCalories() * _servings;
    }

    public double GetProtein()
    {
        return _food.GetProtein() * _servings;
    }

    public double GetCarbs()
    {
        return _food.GetCarbs() * _servings;
    }

    public double GetFats()
    {
        return _food.GetFats() * _servings;
    }

    public string GetSummary()
    {
        return _food.GetName() + " x " + _servings +
               " | Calories: " + GetCalories() +
               " Protein: " + GetProtein() +
               " Carbs: " + GetCarbs() +
               " Fats: " + GetFats();
    }
}
