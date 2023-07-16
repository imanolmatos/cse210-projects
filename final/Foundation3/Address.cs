public class Address
{   
    private string _city;
    private string _state;
    private string _address;
    private string _country;
    public Address(string city, string state, string address, string country)
    {
        _city = city;
        _state = state;
        _address = address;
        _country = country;
    }

    public string ReturnAddress()
    {
        return $"{_address}, {_city}, {_state}, {_country}";
    }
}
