public class Address
{
    private string _street, _city;
    public Address()
    {
    }
    public Address(string street, string city)
    {
        _street = street;
        _city = city;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetInfo()
    {
        string info = $"{GetStreet()}, {GetCity()}";

        return info;
    }
}