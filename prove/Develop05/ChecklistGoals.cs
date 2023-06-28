using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public int CurrentCount { get { return _currentCount; } }
    public int TargetCount { get { return _targetCount; } }

    public ChecklistGoal(string description, int value, int targetCount)
    {
        this.description = description;
        this.value = value;
        this._targetCount = targetCount;
        this._currentCount = 0;
    }

    public override void MarkComplete()
    {
        Console.WriteLine($"You recorded progress for the checklist goal: {description}");
        _currentCount++;

        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Congratulations! You achieved the checklist goal: {description}");
            _currentCount = 0; // Reset the count
        }
    }
}