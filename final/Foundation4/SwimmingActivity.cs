using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int laps, double duration)
        : base(0, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05; // 0.05 kilometers per lap
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Laps: {_laps}";
    }
}
