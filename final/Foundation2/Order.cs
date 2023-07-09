public class Order
{
    public List<Product> products = new List<Product>();
    private Customer customer = new Customer("Juan"); //This should change in the program class.
    private double _totalCost = 0;
    private double _oneTime = 5;
    private double _oneTimeNot = 35;
    public void PackingLabel()
    {
        string name = customer.GetName();
        foreach (Product product in products)
        {
            int _id = product.GetId();

            Console.WriteLine($"{name}{_id}");
        }
    }

    public void ShippingLabel()
    {
        string name = customer.GetName();
        string address = customer.GetAddress();
        Console.WriteLine($"{name} {address}");
    }

    public void TotalCost()
    {
        foreach (Product product in products)
        {
            double total = product.ReturnPrice();
            total = total + total;
            Console.WriteLine(total);
        }
    }
}
