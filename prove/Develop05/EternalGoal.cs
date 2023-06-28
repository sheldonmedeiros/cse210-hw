using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    private int count;

    public EternalGoal(string description, int value)
    {
        this.description = description;
        this.value = value;
        this.count = 0;
    }

    public override void MarkComplete()
    {
        Console.WriteLine($"You recorded progress for the eternal goal: {description}");
        count++;
    }
}