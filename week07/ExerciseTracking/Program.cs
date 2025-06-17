using System;
using System.Collections.Generic;

// Base class
abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Encapsulated properties for derived classes if needed
    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods to be overridden
    public abstract double GetDistance();  // miles or km
    public abstract double GetSpeed();     // mph or kph
    public abstract double GetPace();      // min per mile or min per km

    // Shared method to get summary string
    public virtual string GetSummary()
    {
        // Format date as "dd MMM yyyy"
        string dateStr = _date.ToString("dd MMM yyyy");

        // Example summary:
        // "03 Nov 2022 Running (30 min) - Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile"
        return $"{dateStr} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.00} min per unit";
    }
}

// Derived class Running
class Running : Activity
{
    private double _distance; // miles or km, depending on choice

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();

    public override string GetSummary()
    {
        string dateStr = Date.ToString("dd MMM yyyy");
        return $"{dateStr} Running ({Minutes} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}

// Derived class Cycling
class Cycling : Activity
{
    private double _speed;  // mph or kph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Distance = speed * (minutes / 60)
    public override double GetDistance() => _speed * Minutes / 60.0;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60.0 / _speed;

    public override string GetSummary()
    {
        string dateStr = Date.ToString("dd MMM yyyy");
        return $"{dateStr} Cycling ({Minutes} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}

// Derived class Swimming
class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50.0;
    private const double MeterToMile = 0.000621371;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Calculate distance in miles: laps * 50 meters converted to miles
    public override double GetDistance()
    {
        double meters = _laps * LapLengthMeters;
        return meters * MeterToMile;
    }

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();

    public override string GetSummary()
    {
        string dateStr = Date.ToString("dd MMM yyyy");
        return $"{dateStr} Swimming ({Minutes} min) - Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create one activity of each type
        Activity run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity bike = new Cycling(new DateTime(2022, 11, 3), 45, 12.0);
        Activity swim = new Swimming(new DateTime(2022, 11, 3), 60, 40);

        // Put activities in a list
        List<Activity> activities = new List<Activity> { run, bike, swim };

        // Iterate and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}