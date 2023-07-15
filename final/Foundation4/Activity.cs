using System;
using System.Collections.Generic;

// Base Activity class
abstract class Activity
{
    private DateTime date;
    protected int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{date.ToShortDateString()} {GetType().Name} ({lengthInMinutes} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}