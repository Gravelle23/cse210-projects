using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.") {}

    public override void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);  
            Console.WriteLine("Breathe out...");
            ShowSpinner(4);  
        }

        End();
    }
}