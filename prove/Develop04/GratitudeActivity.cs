using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude Activity",
              "This activity will help you focus on gratitude by silently thinking of things you are thankful for.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nThink of things you are grateful for.");
        ShowSpinner(GetDuration());
    }
}