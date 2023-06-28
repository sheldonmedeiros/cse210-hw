class Program
{
    static void Main(string[] args)
    {
        EternalQuest quest = new EternalQuest();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Create goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    quest.CreateGoal();
                    break;
                case 2:
                    quest.RecordEvent();
                    break;
                case 3:
                    quest.DisplayGoals();
                    break;
                case 4:
                    quest.DisplayScore();
                    break;
                case 5:
                    quest.SaveGoals();
                    break;
                case 6:
                    quest.LoadGoals();
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}