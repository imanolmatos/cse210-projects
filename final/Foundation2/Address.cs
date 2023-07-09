public class Address
{
    private bool _inUsa = true;
    private string _city = "Unknwon City";
    private string _state = "Unknown State";
    private string _address = "Unknown Address";
    private string _country = "Unknown Country";

    public Address(bool inUsa, string city, string state, string address, string country)
    {
        _inUsa = inUsa;
        _city = city;
        _state = state;
        _address = address;
        _country = country;
    }

    public Address() { }

    public string ReturnAddress()
    {
        return $"{_address}, {_city}, {_state}, {_country}";
    }

    public bool InUsa()
    {
        return _inUsa;
    }
}
