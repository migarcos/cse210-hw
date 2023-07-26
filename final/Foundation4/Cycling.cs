public class Cycling: Activity
{
    private double _speed;
    public Cycling(string date, double time, double speed): base (date, time)
    {
        _speed = speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double distance = (_speed * GetTime() / 60) ;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
    public override string GetSummary()
    {
        string summary = $"{GetDate()} Cycling ({GetTime()})-Distance {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km.";
        return summary;
    }

    
}