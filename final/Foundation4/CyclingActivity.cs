using System;

public class CyclingActivity : Activity
{
    private int revolutions;

    public CyclingActivity(double distance, double duration, int revolutions)
        : base(distance, duration)
    {
        this.revolutions = revolutions;
    }

    public override double GetDistance()
    {
        // Convert revolutions to distance; average wheel circumference)
        return revolutions * 0.004; // 0.004 kilometers per revolution
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Revolutions: {revolutions}";
    }
}
