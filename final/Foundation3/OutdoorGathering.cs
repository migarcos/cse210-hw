public class OutdoorGathering: Event
{
    private string _forecastWeather;
    public OutdoorGathering()
    {

    }
    public OutdoorGathering(string title, string descr, string date, string time, string weather): base(title, descr, date, time)
    {
        _forecastWeather = weather;
    }
    public void SetWeather(string weather)
    {
        _forecastWeather = weather;
    }
    public string GetWeather()
    {
        return _forecastWeather;
    }
    public string FullDetails()
    {
        string Details = $"{StdDetails()},\nForecast: {_forecastWeather}";
        return Details;
    }
    public string ShortDetails()
    {
        string StdDetails = $"Outhdoor Gathering: {GetTitle()}, {GetDate()}";
        return StdDetails;
    }
}