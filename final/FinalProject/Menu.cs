using System;

public class Menu
{
    private FoodDatabase _database;
    private DailyLog _log;
    private User _user;
    private MacroCalculator _calculator;

    public Menu()
    {
        _database = new FoodDatabase();
        _log = new DailyLog();
        _user = new User(2200, 180, 250, 70);
        _calculator = new MacroCalculator();
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 9)
        {
            Console.WriteLine("\n--- Macro Tracker ---");
            Console.WriteLine("1. Search food");
            Console.WriteLine("2. Add meal");
            Console.WriteLine("3. Create a recipe");
            Console.WriteLine("4. View full food database");
            Console.WriteLine("5. View daily summary");
            Console.WriteLine("6. Check goals");
            Console.WriteLine("7. Create or update goals");
            Console.WriteLine("8. Add new food to database");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");

            choice = ReadInt();

            if (choice == 1)
            {
                LookUpFood();
            }
            else if (choice == 2)
            {
                AddFoodToMeal();
            }
            else if (choice == 3)
            {
                CreateRecipe();
            }
            else if (choice == 4)
            {
                _database.DisplayAllFoods();
            }
            else if (choice == 5)
            {
                _log.DisplaySummary();
            }
            else if (choice == 6)
            {
                _user.CheckGoals(_log);
            }
            else if (choice == 7)
            {
                SetGoals();
            }
            else if (choice == 8)
            {
                AddFoodToDatabase();
            }
            else if (choice == 9)
            {
                Console.WriteLine("Thank you for using the Macro Tracker. Come Again!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    private void LookUpFood()
    {
        Console.Write("\nEnter food name: ");
        string name = Console.ReadLine();

        WholeFood food = _database.FindFood(name);

        if (food == null)
        {
            Console.WriteLine("Food not found in database.");
            return;
        }

        Console.Write("Enter servings: ");
        double servings = ReadDouble();

        Console.WriteLine("\nFood Found: " + food.GetName());
        Console.WriteLine("Calories: " + _calculator.CalculateCalories(food, servings));
        Console.WriteLine("Protein: " + _calculator.CalculateProtein(food, servings));
        Console.WriteLine("Carbs: " + _calculator.CalculateCarbs(food, servings));
        Console.WriteLine("Fats: " + _calculator.CalculateFats(food, servings));
    }

    private void AddFoodToMeal()
    {
        Console.Write("\nEnter meal name: ");
        string mealName = Console.ReadLine();

        Meal meal = FindMealByName(mealName);

        if (meal == null)
        {
            meal = new Meal(mealName);
            _log.AddMeal(meal);
        }

        Console.Write("Enter food name: ");
        string foodName = Console.ReadLine();

        WholeFood food = _database.FindFood(foodName);

        if (food == null)
        {
            Console.WriteLine("Food not found in database.");
            return;
        }

        Console.Write("Enter servings: ");
        double servings = ReadDouble();

        Ingredient ingredient = new Ingredient(food, servings);
        meal.AddItem(ingredient);

        Console.WriteLine("Added to meal.");
        Console.WriteLine(ingredient.GetSummary());
    }

    private void CreateRecipe()
    {
        Console.Write("\nEnter recipe name: ");
        string recipeName = Console.ReadLine();

        RecipeFood recipe = new RecipeFood(recipeName);

        Console.Write("How many ingredients? ");
        int count = ReadInt();

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter ingredient food name: ");
            string foodName = Console.ReadLine();

            WholeFood food = _database.FindFood(foodName);

            if (food == null)
            {
                Console.WriteLine("Food not found. Skipping ingredient.");
            }
            else
            {
                Console.Write("Enter servings: ");
                double servings = ReadDouble();

                Ingredient ingredient = new Ingredient(food, servings);
                recipe.AddIngredient(ingredient);
            }
        }

        Console.WriteLine("\nRecipe Created:");
        Console.WriteLine(recipe.GetDetails());

        Console.Write("Add this recipe to the food database? (yes/no): ");
        string answer = Console.ReadLine().ToLower();

        if (answer == "yes")
        {
            WholeFood savedRecipe = new WholeFood(
                recipe.GetName(),
                recipe.GetCalories(),
                recipe.GetProtein(),
                recipe.GetCarbs(),
                recipe.GetFats()
            );

            _database.AddFood(savedRecipe);
            Console.WriteLine("Recipe added to database as a food.");
        }
    }

    private void SetGoals()
    {
        Console.WriteLine("\n--- Create or Update Goals ---");

        Console.Write("Enter calorie goal: ");
        double calories = ReadDouble();

        Console.Write("Enter protein goal: ");
        double protein = ReadDouble();

        Console.Write("Enter carb goal: ");
        double carbs = ReadDouble();

        Console.Write("Enter fat goal: ");
        double fats = ReadDouble();

        _user.SetGoals(calories, protein, carbs, fats);

        Console.WriteLine("Goals updated successfully.");
        _user.DisplayGoals();
    }

    private void AddFoodToDatabase()
    {
        Console.WriteLine("\n--- Add New Food ---");

        Console.Write("Enter food name: ");
        string name = Console.ReadLine();

        Console.Write("Enter calories: ");
        double calories = ReadDouble();

        Console.Write("Enter protein: ");
        double protein = ReadDouble();

        Console.Write("Enter carbs: ");
        double carbs = ReadDouble();

        Console.Write("Enter fats: ");
        double fats = ReadDouble();

        WholeFood newFood = new WholeFood(name, calories, protein, carbs, fats);
        _database.AddFood(newFood);

        Console.WriteLine("Food added successfully.");
    }

    private Meal FindMealByName(string name)
    {
        foreach (Meal meal in _log.GetMeals())
        {
            if (meal.GetName().ToLower() == name.ToLower())
            {
                return meal;
            }
        }

        return null;
    }

    private int ReadInt()
    {
        int value;

        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Enter a whole number: ");
        }

        return value;
    }

    private double ReadDouble()
    {
        double value;

        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Enter a number: ");
        }

        return value;
    }
}