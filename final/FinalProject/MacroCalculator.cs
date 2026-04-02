public class MacroCalculator
{
    public double CalculateCalories(FoodItem food, double servings)
    {
        return food.GetCalories() * servings;
    }

    public double CalculateProtein(FoodItem food, double servings)
    {
        return food.GetProtein() * servings;
    }

    public double CalculateCarbs(FoodItem food, double servings)
    {
        return food.GetCarbs() * servings;
    }

    public double CalculateFats(FoodItem food, double servings)
    {
        return food.GetFats() * servings;
    }
}