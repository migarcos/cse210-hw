public class Running: Activity
{
    private double _distance;
    public Running(string date, double time, double distance): base (date, time)
    {
        _distance = distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = _distance / GetTime() * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        string summary = $"{GetDate()} Running ({GetTime()})-Distance {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km.";
        return summary;
    }

    
}