using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.MarkComplete();
            score += goal.Value;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public int CurrentCount { get { return currentCount; } }
    public int TargetCount { get { return targetCount; } }

    public ChecklistGoal(string description, int value, int targetCount)
    {
        this.description = description;
        this.value = value;
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public override void MarkComplete()
    {
        Console.WriteLine($"You recorded progress for the checklist goal: {description}");
        currentCount++;

        if (currentCount == targetCount)
        {
            Console.WriteLine($"Congratulations! You achieved the checklist goal: {description}");
            currentCount = 0; // Reset the count
        }
    }
}
    public int GetScore()
    {
        return score;
    }

    internal void DisplayGoals()
    {
        throw new NotImplementedException();
    }
}
