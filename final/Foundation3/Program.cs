class Program
{
    static void Main()
    {
        // Create address instances
        Address address1 = new Address("123 Main St", "Cityville", "State A", "12345");
        Address address2 = new Address("456 Elm St", "Townsville", "State B", "67890");
        Address address3 = new Address("789 Oak St", "Villageland", "State C", "54321");

        // Create event instances
        Event genericEvent = new Event("Generic Event", "This is a generic event", DateTime.Now, "10:00 AM", address1);
        Lecture lecture = new Lecture("Science Talk", "An informative lecture about science", DateTime.Now, "2:00 PM", address2, "Dr. Scientist", 50);
        Reception reception = new Reception("Networking Mixer", "A networking event for professionals", DateTime.Now, "6:00 PM", address3, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "A fun outdoor gathering for all", DateTime.Now, "12:00 PM", address1, "Sunny with a chance of clouds");

        // Output the marketing messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(gathering.GetStandardDetails());

        Console.WriteLine("Full Details:");
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(gathering.GetFullDetails());

        Console.WriteLine("Short Description:");
        Console.WriteLine(genericEvent.GetShortDescription());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(gathering.GetShortDescription());
    }
}