using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Create the activities
        Activity breathingActivity = new BreathingActivity();
        Activity reflectingActivity = new ReflectingActivity();
        Activity listingActivity = new ListingActivity();

        int choice;  // Declare choice outside the loop

        do
        {
             // Display menu
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
                case 4:
                    // Exit condition, no action needed
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 4);  // Continue looping until user chooses option 4
    }
}
