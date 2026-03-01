using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<string> activityLog = new List<string>();

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. View Activity Log");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    activity = new GratitudeActivity(); // Extra
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Activity Log:");
                    foreach (string log in activityLog)
                        Console.WriteLine(log);
                    Console.WriteLine("\nPress Enter to return...");
                    Console.ReadLine();
                    continue;
                case "6":
                    running = false;
                    continue;
                default:
                    continue;
            }

            activity.Run();
            activityLog.Add($"{DateTime.Now}: {activity.GetName()} ({activity.GetDuration()} sec)");
        }
    }
}