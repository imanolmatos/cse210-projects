using System;

class Program
{
    static void Main(string[] args)
    {   //First Order
        Console.WriteLine("These are the orders.");
        Console.WriteLine("");
        Order order1 = new Order();
        order1.SetCustomer(new Customer("Leonardo", new Address(true, "Salt Lake", "Utah", "Bountiful Park 2032", "USA")));
        Product product1 = new Product(1111,"Candy Bars", 10, 5);
        Product product2 = new Product(1112,"Legos", 5, 5);
        order1.products.Add(product1);
        order1.products.Add(product2);
        order1.ShippingLabel();
        order1.PackingLabel();
        order1.TotalCost();
        Console.WriteLine();
        Order order2 = new Order();
        order2.SetCustomer(new Customer("Maria", new Address(false, "Azua", "Centro de Azua", "Calle Duarte #47", "Republica Dominicana"))); //We are going to pass the boolean, we can also check if a variable is Usa. But in console I would typcally ask yes or no or make a numbers selection.
        Product product01 = new Product(1113,"Chocolate Bars", 10, 3);
        Product product02 = new Product(1114,"Cars", 5, 10);
        order2.products.Add(product01);
        order2.products.Add(product02);
        order2.ShippingLabel();
        order2.PackingLabel();
        order2.TotalCost();
    }   
}