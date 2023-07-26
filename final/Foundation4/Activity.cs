public class Activity
{
    private string _date;
    private double _time;
    public Activity()
    {

    }
    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTime(double time)
    {
        _time = time;        
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetTime()
    {
        return _time;
    }
    public virtual string GetSummary()
    {
        string summary = $"";
        return summary;
    }
    public virtual double GetDistance()
    {
        double distance = 0;
        return distance;
    }
    public virtual double GetSpeed()
    {
        double speed = 0;
        return speed;
    }
    public virtual double GetPace()
    {
        double pace = 0;
        return pace;
    }
}