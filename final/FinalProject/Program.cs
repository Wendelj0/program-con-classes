using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User { Name = "Jacob", Age = 21, Weight = 230, Goal = "Lose" };

        Meal breakfast = new Meal();
        Ingredient egg = new Ingredient
        {
            Food = new WholeFood { Name = "Egg", Calories = 70, Protein = 6, Carbs = 0, Fat = 5 },
            Quantity = 100
        };
        breakfast.AddIngredient(egg);


        DailyLog log = new DailyLog();
        log.AddMeal(breakfast);

        MenuUI menu = new MenuUI();
        bool running = true;

        while (running)
        {
            menu.ShowMenu();
            int choice = menu.GetUserChoice();
            switch (choice)
            {
                case 1:
                    user.DisplayUserInfo();
                    break;
                case 2:
                    log.DisplayDailyLog();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Macro Calculator!");
    }
}