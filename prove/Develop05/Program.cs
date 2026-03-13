using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            manager.DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                manager.CreateGoal();
            else if (choice == 2)
                manager.ListGoals();
            else if (choice == 3)
                manager.RecordEvent();
            else if (choice == 4)
                manager.SaveGoals();
            else if (choice == 5)
                manager.LoadGoals();

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}


//EXCEEDING REQUIREMENTS:

//I added a leveling system to increase the gamification of the program.
//The user gains a new level every 1000 points earned. This encourages
//continued progress toward completing goals and adds another reward
//mechanism besides just earning points.
