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
            ShowSpinner(3);  // Pause for 2 seconds with animation
            Console.WriteLine("Breathe out...");
            ShowSpinner(4);  // Pause for 2 seconds with animation
        }

        End();
    }
}