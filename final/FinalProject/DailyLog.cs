using System;
using System.Collections.Generic;

public class DailyLog
{
    private List<Meal> _meals;

    public DailyLog()
    {
        _meals = new List<Meal>();
    }

    public void AddMeal(Meal meal)
    {
        _meals.Add(meal);
    }

    public List<Meal> GetMeals()
    {
        return _meals;
    }

    public double GetCalories()
    {
        double total = 0;

        foreach (Meal meal in _meals)
        {
            total += meal.GetCalories();
        }

        return total;
    }

    public double GetProtein()
    {
        double total = 0;

        foreach (Meal meal in _meals)
        {
            total += meal.GetProtein();
        }

        return total;
    }

    public double GetCarbs()
    {
        double total = 0;

        foreach (Meal meal in _meals)
        {
            total += meal.GetCarbs();
        }

        return total;
    }

    public double GetFats()
    {
        double total = 0;

        foreach (Meal meal in _meals)
        {
            total += meal.GetFats();
        }

        return total;
    }

    public void DisplaySummary()
    {
        Console.WriteLine("\n--- Daily Summary ---");

        foreach (Meal meal in _meals)
        {
            Console.WriteLine(meal.GetName() + " | Calories: " + meal.GetCalories() +
                              " Protein: " + meal.GetProtein() +
                              " Carbs: " + meal.GetCarbs() +
                              " Fats: " + meal.GetFats());
        }

        Console.WriteLine("\nDaily Totals:");
        Console.WriteLine("Calories: " + GetCalories());
        Console.WriteLine("Protein: " + GetProtein());
        Console.WriteLine("Carbs: " + GetCarbs());
        Console.WriteLine("Fats: " + GetFats());
    }
}