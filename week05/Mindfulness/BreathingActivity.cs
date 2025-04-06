using System.Runtime.CompilerServices;
using System.Threading;
public class BreathingActivity 
{
    private string _name;
    private string _description;
    private string _endDescription;
    private int _duration;
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by breathing deeply.";
        _endDescription = "Thank you for taking the time to do this Activity!";
        _duration = 60;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}: {_endDescription}");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Please wait...");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            System.Threading.Thread.Sleep(1000);
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }
}