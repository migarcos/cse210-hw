public class Customer
{
    private string _name;
    private Address _cAddress;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _cAddress = address;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetAddress(string street, string city, string country)
    {
        _cAddress = new Address(street, city, country);
    }
    public Address GetAddress()
    {
        return _cAddress;
    }
    public string GetStringAddress()
    {
        string temp = $"{_cAddress.GetStreet()} {_cAddress.GetCity()} {_cAddress.GetCountry()}";
        return temp;
    }

}