public class Order
{
    public List<Product> products = new List<Product>();
    private Customer _customer;
    private double _totalCost = 0;
    private double _oneTime = 5;
    private double _oneTimeNot = 35;

    public Order(){}

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void PackingLabel()
    { 
        foreach (Product product in products)
        {
            int _id = product.GetId();
            string _name = product.GetProductName();
            Console.WriteLine($"Packing Label: {_name} {_id}");
        }
    }

    public void ShippingLabel()
    {
        string name = _customer.GetName();
        string address = _customer.GetAddress();
        Console.WriteLine($"Shipping Label: {name} {address}");
    }

    public void TotalCost()
    {   double _totalCost = 0;
        bool _inUsa = _customer.IsTheCustomerUsa();
        foreach (Product product in products)
        {
           double _total = product.ReturnPrice();
           _totalCost = _total + _totalCost;    
          
        }      
        if (_inUsa) {
            _totalCost = _totalCost + 5;
           }
        else {
            _totalCost = _totalCost + 35;
           }
        Console.WriteLine($"Total Cost: {_totalCost}");
    }
}
