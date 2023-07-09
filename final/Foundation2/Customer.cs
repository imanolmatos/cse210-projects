public class Customer
{
    private string _customerName;
    private Address address = new Address(); 

    public Customer(string name)
    {
        _customerName = name;
    }

    public Customer() { }

    public string GetName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return address.ReturnAddress();
    }

    public bool IsTheCustomerUsa()
    {
        return address.InUsa();
    }
}
