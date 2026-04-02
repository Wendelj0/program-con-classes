using System;
using System.Collections.Generic;

public class Meal
{
    private string _name;
    private List<Ingredient> _items;

    public Meal(string name)
    {
        _name = name;
        _items = new List<Ingredient>();
    }

    public string GetName()
    {
        return _name;
    }

    public void AddItem(Ingredient item)
    {
        _items.Add(item);
    }

    public List<Ingredient> GetItems()
    {
        return _items;
    }

    public double GetCalories()
    {
        double total = 0;

        foreach (Ingredient item in _items)
        {
            total += item.GetCalories();
        }

        return total;
    }

    public double GetProtein()
    {
        double total = 0;

        foreach (Ingredient item in _items)
        {
            total += item.GetProtein();
        }

        return total;
    }

    public double GetCarbs()
    {
        double total = 0;

        foreach (Ingredient item in _items)
        {
            total += item.GetCarbs();
        }

        return total;
    }

    public double GetFats()
    {
        double total = 0;

        foreach (Ingredient item in _items)
        {
            total += item.GetFats();
        }

        return total;
    }

    public void DisplayMeal()
    {
        Console.WriteLine("\n--- " + _name + " ---");

        foreach (Ingredient item in _items)
        {
            Console.WriteLine(item.GetSummary());
        }

        Console.WriteLine("Meal Totals:");
        Console.WriteLine("Calories: " + GetCalories());
        Console.WriteLine("Protein: " + GetProtein());
        Console.WriteLine("Carbs: " + GetCarbs());
        Console.WriteLine("Fats: " + GetFats());
    }
}