
class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(5000); // Pause for 5 seconds to think

        Console.WriteLine("Start listing items...");

        // Simulating user input by entering items manually
        List<string> items = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;

            items.Add(item);
        }

        Console.WriteLine($"Number of items listed: {items.Count}");
    }
}