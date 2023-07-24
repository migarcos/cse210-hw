public class Event
{
    private string _title, _description, _date, _time;
    private Address _eAddress;
    public Event()
    {
    }
    public Event(string title, string descr, string date, string time)
    {
        _title = title;
        _description = descr;
        _date = date;
        _time = time;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetDescr(string descr)
    {
        _description = descr;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public void SetAddress(Address eventAddress)
    {
        _eAddress = eventAddress;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescr()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public Address GetAddress()
    {
        return _eAddress;
    }
    public string StdDetails()
    {
        string StdDetails = $"{GetTitle()},\n {GetDescr()},\n {GetDate()}, {GetTime()},\n {_eAddress.GetInfo()}";

        return StdDetails;
    }

}