using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity helps you reflect on personal prompts.";
        _duration = 60; // Example duration in seconds
        _prompts = new List<string> { "What are you grateful for?", "What can you improve?" };
        _questions = new List<string> { "Why is this important?", "What can you do to change?" };
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
            System.Threading.Thread.Sleep(1000); // Sleep for 1 second
        }
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[index]}");
    }

    public void GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        Console.WriteLine($"Question: {_questions[index]}");
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetRandomQuestion();
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }
}

