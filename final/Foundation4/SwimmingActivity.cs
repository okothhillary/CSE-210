using System;

public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(int laps, double duration)
        : base(0, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 0.05; // 0.05 kilometers per lap
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Laps: {laps}";
    }
}
