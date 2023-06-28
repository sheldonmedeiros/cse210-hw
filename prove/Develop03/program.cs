using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadScripturesFromFile("scriptures.txt");
        

        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        while (true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Scripture scripture = library.GetRandomScripture();
            Console.Clear();
            Console.WriteLine(scripture.GetFullScripture());

            while (!scripture.IsAllWordsHidden())
            {
                Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
                string innerInput = Console.ReadLine();
                if (innerInput.ToLower() == "quit")
                    break;

                scripture.HideRandomWord();
                Console.Clear();
                Console.WriteLine(scripture.GetFullScripture());
            }
        }

        Console.WriteLine("Program ended.");
    }
}

