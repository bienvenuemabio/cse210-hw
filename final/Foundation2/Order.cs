public class Order
{
    private int _shippingUsa =5;
    private int _totalCost =0;
    private int _totalPrice=0;
    private int _shippingCost= 35;
    public List<Products> _products;
    public List<Customer> _customers;

    public Order()
    {

    }

    public void AddProduct(Products products)
    {
        _products.Add(products);
    }

    public void AddCustomer(Customer customers)
    {
        _customers.Add(customers);
    }

    public void TotalCostOrdered()
    {
        foreach (Products product in _products)
        {
           _totalCost += product.PriceofProduct();
            
        }
        _totalPrice= _totalCost * _shippingCost;
        Console.WriteLine($"The total Price is: {_totalPrice}");

    }

    public void DisplayPackingLabel()
    {
        foreach(Products product in _products)
        {
            product.ProductInfo();
        }


    }

    public void DisplayShippingLabel()
    {
        foreach (Customer customer in _customers)
        {
            customer.DisplayCustomerInfo();
        }

    }
}
