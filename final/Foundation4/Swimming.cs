public class Swimming: Activity
{
    private double _laps;
    public Swimming(string date, double time, double laps): base(date, time)
    {
            _laps = laps;
    }
    public void SetLaps(double laps)
    {
        _laps = laps;
    }
    public double GetLaps()
    {
        return _laps;
    }
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetTime()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        string summary = $"{GetDate()} Swimming ({GetTime()})-Distance {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km.";
        return summary;
    }
}