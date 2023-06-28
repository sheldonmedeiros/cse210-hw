using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);

        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds

        Console.WriteLine("Start!");
        PerformActivity();

        Console.WriteLine($"Well done! You have completed {name} for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected abstract void PerformActivity();
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for 2 seconds

            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Pause for 2 seconds
        }
    }
}
