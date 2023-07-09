using System;

class Program
{
    static void Main(string[] args)
    {   //First Order
        Order order1 = new Order();
        Customer customer1 = new Customer("Juan");
        Product product1 = new Product(1111,"Candy Bars", 10, 5);
        Product product2 = new Product(1112,"Legos", 5, 5);
        order1.products.Add(product1);
        order1.products.Add(product2);
        Address address1 = new Address(true,"Utah", "Salt Lake", "Bountifoul", "USA");
        order1.PackingLabel();
        order1.ShippingLabel();
    }
}   