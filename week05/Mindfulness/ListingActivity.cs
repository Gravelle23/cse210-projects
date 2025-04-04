using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 60;
        _prompts = new List<string>
        {
            "Things you are greatful for",
            "Hobbies you enjoy",
            "Things you want to achieve this week"
        };
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}: {_description}");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            System.Threading.Thread.Sleep(1000);
        }
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[index]}");
    }

    public void GetlistFromUser()
    {
        Console.WriteLine("Please list items related to prompt:");
        Console.ReadLine();
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetlistFromUser();
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }

}