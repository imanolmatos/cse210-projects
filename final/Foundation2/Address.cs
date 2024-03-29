public class Address
{
    private bool _inUsa = true;
    private string _city;
    private string _state;
    private string _address;
    private string _country;
    
    public Address(bool inUsa, string city, string state, string address, string country)
    {
        _inUsa = inUsa;
        _city = city;
        _state = state;
        _address = address;
        _country = country;
    }

    public string ReturnAddress()
    {
        return $"{_address}, {_city}, {_state}, {_country}";
    }

    public bool InUsa()
    {
        return _inUsa;
    }
}
