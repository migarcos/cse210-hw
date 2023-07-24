public class activity
{
    private string _date, _time;
    private double _distance, _speed, _pace;
    public activity()
    {

    }
    public activity(string date, string time, double distance, double speed, double pace)
    {
        _date = date;
        _time = time;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTime(string time)
    {
        _time = time;        
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public void SetPace(double pace)
    {
        _pace = pace;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public virtual double GetDistance()
    {
        return _distance;
    }
    public virtual double GetSpeed()
    {
        return _speed;
    }
    public virtual double GetPace()
    {
        return _pace;
    }
    public string GetSummary()
    {
        string summary = $"";
        return summary;
    }


}