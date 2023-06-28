using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Add some goals
        goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10));

        // Record events (accomplished goals)
        goalManager.RecordEvent(0); // Run a marathon
        goalManager.RecordEvent(1); // Read scriptures
        goalManager.RecordEvent(2); // Attend the temple (1st time)
        goalManager.RecordEvent(2); // Attend the temple (2nd time)
        goalManager.RecordEvent(2); // Attend the temple (3rd time)
        goalManager.RecordEvent(2); // Attend the temple (4th time)
        goalManager.RecordEvent(2); // Attend the temple (5th time)
        goalManager.RecordEvent(2); // Attend the temple (6th time)
        goalManager.RecordEvent(2); // Attend the temple (7th time)
        goalManager.RecordEvent(2); // Attend the temple (8th time)
        goalManager.RecordEvent(2); // Attend the temple (9th time)
        goalManager.RecordEvent(2); // Attend the temple (10th time)

        // Display goals and score
        goalManager.DisplayGoals();
        Console.WriteLine($"Score: {goalManager.GetScore()}"); }
}