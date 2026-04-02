public class WholeFood : FoodItem
{
    private double _calories;
    private double _protein;
    private double _carbs;
    private double _fats;

    public WholeFood(string name, double calories, double protein, double carbs, double fats)
        : base(name)
    {
        _calories = calories;
        _protein = protein;
        _carbs = carbs;
        _fats = fats;
    }

    public override double GetCalories()
    {
        return _calories;
    }

    public override double GetProtein()
    {
        return _protein;
    }

    public override double GetCarbs()
    {
        return _carbs;
    }

    public override double GetFats()
    {
        return _fats;
    }

    public override string GetDetails()
    {
        return _name + " | Calories: " + _calories +
               " Protein: " + _protein +
               " Carbs: " + _carbs +
               " Fats: " + _fats;
    }
}