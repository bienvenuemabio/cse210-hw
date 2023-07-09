using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Order order1 = new Order();
        Products product1 = new Products();
        product1.SetProductId("prod123");
        product1.GetProductId();
        product1.SetName("phone");
        product1.GetName();
        product1.SetPrice(1000);
        product1.GetPrice();
        product1.SetQuantity(8);
        product1.GetQuantity();
        order1.AddProduct(product1);
        order1.DisplayPackingLabel();
        
    }
}