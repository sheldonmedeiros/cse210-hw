class Program
{
    static void Main()
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Create activity instances
        DateTime date = new DateTime(2022, 11, 3);
        Activity running = new Running(date, 30, 3.0);
        Activity cycling = new Cycling(date, 30, 6.0);
        Activity swimming = new Swimming(date, 30, 10);

        // Add activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Output the summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}