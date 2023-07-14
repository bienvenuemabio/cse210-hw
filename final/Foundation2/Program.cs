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
        product2.SetProductId("prod124");
        product2.GetProductId();
        product2.SetName("machine");
        product2.GetName();
        product2.SetPrice(15000);
        product2.GetPrice();
        product2.SetQuantity(2);
        product2.GetQuantity();
        order1.AddProduct(product1);
        order1.AddProduct(product2);


        Address customadress1= new Address("a001","provo","salt lake","usa");
        Customer customer1= new Customer("landry",customadress1);
        order1.AddCustomer(customer1);
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.TotalCostOrdered();
        Console.WriteLine();

        Order order2 = new Order(0,0,5,35);
        Products product21 = new Products();
        product21.SetProductId("p0004");
        product21.GetProductId();
        product21.SetName("Calculate");
        product21.GetName();
        product21.SetPrice(5000);
        product21.GetPrice();
        product21.SetQuantity(5);
        product21.GetQuantity();
        Products product3= new Products();
        product3.SetProductId("p0004");
        product3.GetProductId();
        product3.SetName("Tv");
        product3.GetName();
        product3.SetPrice(80000);
        product3.GetPrice();
        product3.SetQuantity(20);
        product3.GetQuantity();
        order2.AddProduct(product21);
        order2.AddProduct(product3);

        Products product4= new Products();
        product4.SetProductId("p00334");
        product4.GetProductId();
        product4.SetName("Wifi Box");
        product4.GetName();
        product4.SetPrice(30000);
        product4.GetPrice();
        product4.SetQuantity(15);
        product4.GetQuantity();
        order2.AddProduct(product4);


        Address customadress2= new Address("A021","abidjan","Aboisso","IvoryCoast");
        Customer customer2= new Customer("Keli Dan",customadress2);
        order2.AddCustomer(customer2);
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        order2.TotalCostOrdered();
        Console.WriteLine();

        
    }
}