public class Address 
{
    private string _street, _city, _country;

    public Address(string street, string city, string country = "USA")
    {
        _street = street;
        _city = city;
        _country = country;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetCountry()
    {
        return _country;
    }
    public string GetStringAdrress()
    {
        string address = $"{_street} \n{_city}, {_country}";

        return address;
    }
    
    public bool GetStatus(string country)
    {
        bool status; // to determine if customer is local or foreign
        if (country != "USA")
        {
            status = false;
        } else {
            status = true;
        }
        return status;
    }
}