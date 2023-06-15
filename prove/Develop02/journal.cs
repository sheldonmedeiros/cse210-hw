using System;
using System.Collections.Generic;
using System.IO;



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