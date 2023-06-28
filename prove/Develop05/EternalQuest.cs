class EternalQuest
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private string description;
    private int value;

    public EternalQuest(string description, int value)
    {
        this.description = description;
        this.value = value;
    }

    public EternalQuest()
    {
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist):");
        int goalType = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal value:");
        int value = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(description, value);
                break;
            case 2:
                goal = new EternalQuest(description, value);
                break;
            case 3:
                Console.WriteLine("Enter goal target count:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter goal bonus value:");
                int bonusValue = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(description, targetCount, value, bonusValue);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the index of the goal you want to record an event for:");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            goal.Complete();
            score += goal.Value;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.Write($"{i}. [{(goal.IsCompleted ? 'X' : ' ')}] {goal.Description}");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($" (Completed {checklistGoal.CompletionCount}/{checklistGoal.TargetCount} times)");
            }

            Console.WriteLine();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {score}");
    }

    public void SaveGoals()
    {
        // Implement saving goals to a file
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        // Implement loading goals from a file
        Console.WriteLine("Goals loaded successfully.");
    }
}