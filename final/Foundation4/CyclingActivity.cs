// CyclingActivity.cs
public class CyclingActivity : Activity
{
    private int _revolutions;

    public CyclingActivity(double distance, double duration, int revolutions)
        : base(distance, duration)
    {
        _revolutions = revolutions;
    }

    public override double GetDistance()
    {
        // Convert revolutions to distance (assuming an average wheel circumference)
        return _revolutions * 0.004; // 0.004 kilometers per revolution
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Revolutions: {_revolutions}";
    }
}
