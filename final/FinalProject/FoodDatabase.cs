using System;
using System.Collections.Generic;

public class FoodDatabase
{
    private Dictionary<string, WholeFood> _foods;

    public FoodDatabase()
    {
        _foods = new Dictionary<string, WholeFood>();

        AddFood(new WholeFood("chicken", 165, 31, 0, 3.6));
        AddFood(new WholeFood("white rice", 205, 4.3, 45, 0.4));
        AddFood(new WholeFood("egg", 78, 6, 0.6, 5));
        AddFood(new WholeFood("apple", 95, 0.5, 25, 0.3));
        AddFood(new WholeFood("banana", 105, 1.3, 27, 0.4));
        AddFood(new WholeFood("milk", 103, 8, 12, 2.4));
        AddFood(new WholeFood("oats", 150, 5, 27, 3));
        AddFood(new WholeFood("peanut butter", 190, 8, 7, 16));
        AddFood(new WholeFood("greek yogurt", 100, 17, 6, 0));
        AddFood(new WholeFood("ground beef", 332, 22, 0, 28));
        AddFood(new WholeFood("potato", 161, 4.3, 37, 0.2));
        AddFood(new WholeFood("broccoli", 55, 3.7, 11, 0.6));
    }

    public void AddFood(WholeFood food)
    {
        string key = food.GetName().ToLower();
        _foods[key] = food;
    }

    public WholeFood FindFood(string name)
    {
        string key = name.ToLower();

        if (_foods.ContainsKey(key))
        {
            return _foods[key];
        }

        return null;
    }

    public void DisplayAllFoods()
    {
        Console.WriteLine("\n-------- Food Database --------");

        foreach (KeyValuePair<string, WholeFood> pair in _foods)
        {
            Console.WriteLine(pair.Value.GetDetails());
        }
    }
}
