using System;

public class Activity
{
    private double distance;
    private double duration;

    public Activity(double distance, double duration)
    {
        this.distance = distance;
        this.duration = duration;
    }

    public virtual double GetDistance()
    {
        return distance;
    }

    public virtual double GetSpeed()
    {
        return Math.Round((distance / duration) * 60, 2);
    }

    public virtual double GetPace()
    {
        return duration / distance;
    }

    public virtual string GetSummary()
    {
        return $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
