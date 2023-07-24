public class Lectures: Event
{
    private string _speaker;
    private int _maxCapacity;
    public Lectures()
    {
    }
    public Lectures(string title, string descr, string date, string time, string speaker, int capacity): base(title, descr, date, time)
    {
        _speaker = speaker;
        _maxCapacity = capacity;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetCapacity(int capacity)
    {
        _maxCapacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _maxCapacity;   
    }
    public string FullDetails()
    {
        string Details = $"{StdDetails()},\nSpeaker: {_speaker},\tCapacity: {_maxCapacity}";
        return Details;
    }
    public string ShortDetails()
    {
        string StdDetails = $"Lectures: {GetTitle()}, {GetDate()}";
        return StdDetails;
    }
}