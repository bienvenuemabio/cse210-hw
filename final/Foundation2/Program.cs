using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Order order1 = new Order(0,0,5,35);
        Products product1 = new Products();
        product1.SetProductId("prod123");
        product1.GetProductId();
        product1.SetName("phone");
        product1.GetName();
        product1.SetPrice(1000);
        product1.GetPrice();
        product1.SetQuantity(8);
        product1.GetQuantity();
        Products product2= new Products();
        product1.SetProductId("prod124");
        product1.GetProductId();
        product1.SetName("machine");
        product1.GetName();
        product1.SetPrice(15000);
        product1.GetPrice();
        product1.SetQuantity(2);
        product1.GetQuantity();
        order1.AddProduct(product1);
        order1.AddProduct(product2);


        Address customadress1= new Address("a001","provo","salt lake","usa");
        Customer customer1= new Customer("landry",customadress1);
        order1.AddCustomer(customer1);
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.TotalCostOrdered();
        Console.WriteLine();


        
    }
}