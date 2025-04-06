using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?"
        };
    }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[promptIndex]}");

        foreach (var question in _questions)
        {
            Console.WriteLine($"Question: {question}");
            ShowSpinner(_duration/3);  
        }

        End();
    }
}
