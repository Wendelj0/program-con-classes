using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        List<Scripture> scriptures = new List<Scripture>();

        Reference ref1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(ref1,
            "For God so loved the world that he gave his only begotten Son");

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(ref2,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        Reference ref3 = new Reference("Mosiah", 2, 17);
        Scripture scripture3 = new Scripture(ref3,
            "When ye are in the service of your fellow beings ye are only in the service of your God");

        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);

        Console.Clear();
        Console.WriteLine("Select a scripture to memorize:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Mosiah 2:17");
        Console.Write("Enter choice (1-3): ");

        string choice = Console.ReadLine();

        Scripture selectedScripture = null;

        if (choice == "1")
        {
            selectedScripture = scripture1;
        }
        else if (choice == "2")
        {
            selectedScripture = scripture2;
        }
        else if (choice == "3")
        {
            selectedScripture = scripture3;
        }
        else
        {
            selectedScripture = scripture1;
        }

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}
