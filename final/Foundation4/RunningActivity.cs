using System;

public class RunningActivity : Activity
{
    private int steps;

    public RunningActivity(double distance, double duration, int steps)
        : base(distance, duration)
    {
        this.steps = steps;
    }

    public override double GetDistance()
    {
        // Convert steps to distance. We can use average length of step)
        return (steps * 0.000762); // 0.000762 kilometers per step
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Steps: {steps}";
    }
}
