public class FoodItem
{
    protected string _name;

    public FoodItem(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual double GetCalories()
    {
        return 0;
    }

    public virtual double GetProtein()
    {
        return 0;
    }

    public virtual double GetCarbs()
    {
        return 0;
    }

    public virtual double GetFats()
    {
        return 0;
    }

    public virtual string GetDetails()
    {
        return _name;
    }
}