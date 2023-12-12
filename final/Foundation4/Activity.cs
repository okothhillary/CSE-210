// Activity.cs
using System;

public class Activity
{
    private double _distance;
    private double _duration;

    public Activity(double distance, double duration)
    {
        _distance = distance;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        // Round off the speed to two decimal places
        return Math.Round((_distance / _duration) * 60, 2);
    }

    public virtual double GetPace()
    {
        return _duration / _distance;
    }

    public virtual string GetSummary()
    {
        return $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
