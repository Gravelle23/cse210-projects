using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    public int _duration;  

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        
        // Ensure the input is valid and can be parsed
        bool validInput = false;
        while (!validInput)
        {
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int duration) && duration > 0)
            {
                _duration = duration;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
            }
        }

        Console.WriteLine("Get ready...");
        ShowSpinner(3);  // Show a spinner for 3 seconds before starting
    }

    public void End()
    {
        Console.WriteLine("Well done! You completed the activity.");
        ShowSpinner(3);  // Show a spinner for 3 seconds before ending
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }

    public virtual void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(1000);
            Console.Write("\b \b");  // Erase previous spinner character
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.WriteLine();
    }

    public abstract void Run();  // Abstract method to be overridden by subclasses
}
