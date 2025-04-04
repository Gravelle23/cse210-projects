using System;

public class Program
{
    public static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathingActivity.Run();
                break;
            case 2:
                listingActivity.Run();
                break;
            case 3:
                reflectingActivity.Run();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

