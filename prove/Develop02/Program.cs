using System;
using System.Collections.Generic;
using System.IO;

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