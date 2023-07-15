class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}\n";
    }

    public virtual string GetFullDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}\n";
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: Generic Event\nEvent: {title}\nDate: {date.ToShortDateString()}\n";
    }
}
