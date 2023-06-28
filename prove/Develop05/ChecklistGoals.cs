class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletionCount { get; private set; }
    public int BonusValue { get; set; }

    public ChecklistGoal(string description, int targetCount, int value, int bonusValue)
    {
        Description = description;
        TargetCount = targetCount;
        Value = value;
        BonusValue = bonusValue;
    }

    public override void Complete()
    {
        CompletionCount++;
        if (CompletionCount == TargetCount)
        {
            IsCompleted = true;
            Value += BonusValue; // Apply bonus value when target count is reached
        }
    }
}