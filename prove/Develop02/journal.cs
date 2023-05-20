using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public DateTime Date { get; set; }
    public string Content { get; set; }
}

class Journal
{
    private List<JournalEntry> entries;
    private Random random;

    public Journal()
    {
        entries = new List<JournalEntry>();
        random = new Random();
    }

    public void AddEntry(string content)
    {
        JournalEntry entry = new JournalEntry
        {
            Date = DateTime.Now,
            Content = content
        };
        entries.Add(entry);
    }

    public void DeleteEntry(int index)
    {
        if (index >= 0 && index < entries.Count)
        {
            entries.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid entry index!");
        }
    }

    public void SaveEntries(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Content);
                writer.WriteLine("=====");
            }
        }
        Console.WriteLine("Entries saved to {0}", filename);
    }

    public void DisplayRandomQuestion()
    {
        string[] questions = {
            "What was the best part of your day?",
            "What is something you learned today?",
            "Describe a challenge you faced and how you overcame it.",
            "What are you grateful for today?",
            "Write about a goal you're currently working towards.",
            "Describe a memorable interaction you had with someone today."
        };

        int randomIndex = random.Next(questions.Length);
        string randomQuestion = questions[randomIndex];

        Console.WriteLine("Random Question: {0}", randomQuestion);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Delete entry");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Get random question");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter your journal entry: ");
                    string content = Console.ReadLine();
                    journal.AddEntry(content);
                    break;
                case 2:
                    Console.Write("Enter the index of the entry to delete: ");
                    int index = int.Parse(Console.ReadLine());
                    journal.DeleteEntry(index);
                    break;
                case 3:
                    Console.Write("Enter the filename to save entries: ");
                    string filename = Console.ReadLine();
                    journal.SaveEntries(filename);
                    break;
                case 4:
                    journal.DisplayRandomQuestion();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}