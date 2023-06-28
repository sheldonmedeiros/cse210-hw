using System;
using System.Collections.Generic;

// Base class for goals
public abstract class Goal
{
    protected string description;
    protected int value;

    public string Description { get { return description; } }
    public int Value { get { return value; } }

    public abstract void MarkComplete();
}

// Simple goal that can be marked complete
public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string description, int value)
    {
        this.description = description;
        this.value = value;
        this.isComplete = false;
    }

    public override void MarkComplete()
    {
        if (!isComplete)
        {
            Console.WriteLine($"Congratulations! You completed the goal: {description}");
            isComplete = true;
        }
        else
        {
            Console.WriteLine($"Goal already completed: {description}");
        }
    }
}