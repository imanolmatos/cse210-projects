public class Customer
{
    private string _customerName;
    private Address _add;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _add = address;
    }
    public void SetCustomer(string name)
    { 
        _customerName = name;
        
    }
    public void SetAddress(Address address) 
    {
      _add = address;
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _add.ReturnAddress();
    }

    public bool IsTheCustomerUsa()
    {
        return _add.InUsa();
    }
}
