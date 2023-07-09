public class Product 
{
    private int _productId = 0000;
    private string _productName = "Unknown Product Name";
    private double _price = 0;
    private int _quantity = 0;

    public Product(int id, string product, double price, int quantity)
    {
        _productId = id;
        _productName = product;
        _price = price;
        _quantity = quantity;    
    }
    public int GetId()
    {
        return _productId;
    }
    public double ReturnPrice()
    {
        return _price * _quantity;
    }
}