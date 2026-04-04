using System;

public class User
{
    private double _calorieGoal;
    private double _proteinGoal;
    private double _carbGoal;
    private double _fatGoal;

    public User(double calorieGoal, double proteinGoal, double carbGoal, double fatGoal)
    {
        _calorieGoal = calorieGoal;
        _proteinGoal = proteinGoal;
        _carbGoal = carbGoal;
        _fatGoal = fatGoal;
    }

    public void SetGoals(double calorieGoal, double proteinGoal, double carbGoal, double fatGoal)
    {
        _calorieGoal = calorieGoal;
        _proteinGoal = proteinGoal;
        _carbGoal = carbGoal;
        _fatGoal = fatGoal;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\n--- Goals ---");
        Console.WriteLine("Calories: " + _calorieGoal);
        Console.WriteLine("Protein: " + _proteinGoal);
        Console.WriteLine("Carbs: " + _carbGoal);
        Console.WriteLine("Fats: " + _fatGoal);
    }

    public void CheckGoals(DailyLog log)
    {
        double currentCalories = log.GetCalories();
        double currentProtein = log.GetProtein();
        double currentCarbs = log.GetCarbs();
        double currentFats = log.GetFats();

        Console.WriteLine("\n--- Goal Progress ---");

        DisplaySingleGoalProgress("Calories", currentCalories, _calorieGoal);
        DisplaySingleGoalProgress("Protein", currentProtein, _proteinGoal);
        DisplaySingleGoalProgress("Carbs", currentCarbs, _carbGoal);
        DisplaySingleGoalProgress("Fats", currentFats, _fatGoal);
    }

    private void DisplaySingleGoalProgress(string goalName, double currentAmount, double goalAmount)
    {
        Console.WriteLine("\n" + goalName + ":");
        Console.WriteLine("Current: " + currentAmount);
        Console.WriteLine("Goal: " + goalAmount);

        if (currentAmount < goalAmount)
        {
            Console.WriteLine("Remaining: " + (goalAmount - currentAmount));
        }
        else if (currentAmount > goalAmount)
        {
            Console.WriteLine("Over goal by: " + (currentAmount - goalAmount));
        }
        else
        {
            Console.WriteLine("Goal met exactly.");
        }
    }
}
