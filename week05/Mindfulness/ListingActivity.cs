using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by listing things you appreciate.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?"
        };
    }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[promptIndex]}");

        Console.WriteLine("Start listing your thoughts:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Press Enter to add another thought...");
            Console.ReadLine();
        }

        End();
    }
}
