class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Thread.Sleep(2000); // Pause for 2 seconds

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000); // Pause for 2 seconds
                DisplaySpinnerAnimation();
                Thread.Sleep(2000); // Pause for 2 seconds
            }
        }
    }

    private void DisplaySpinnerAnimation()
    {
        string[] spinnerFrames = { "-", "\\", "|", "/" };

        for (int i = 0; i < 10; i++)
        {
            foreach (string frame in spinnerFrames)
            {
                Console.Write($"\r{frame}"); // Move cursor back to the beginning of the line and write the frame
                Thread.Sleep(100); // Pause for 100 milliseconds
            }
        }

        Console.WriteLine(); // Move to the next line after the spinner animation
    }
}