using System;
using System.Collections.Generic;

public class DailyLog
{
    private List<Meal> meals = new List<Meal>();

    public void AddMeal(Meal meal) => meals.Add(meal);

    public void DisplayDailyLog()
    {
        Console.WriteLine("Daily Log:");
        foreach (var meal in meals)
        {
            meal.DisplayMeal();
        }
    }
}