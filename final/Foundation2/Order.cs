public class Order
{
    private int _totalCost;
    private int _totalPrice;
    private int _shippingCost=5;
    private int _outshippingCost=35;
    public List<Products> _products;
    public List<Customer> _customer;

    public Order(int totalPrice, int totalCost, int shippingCost, int outshippingCost)
    {
        _totalCost=0;
        _totalPrice=0;
        _shippingCost=5;
        _outshippingCost=35;
        _products= new List<Products>();
        _customer= new List<Customer>();

    }



    public void AddProduct(Products product)
    {
        _products.Add(product);
    }



    public void AddCustomer(Customer customers)
    {
        _customer.Add(customers);
    }

    public void TotalCostOrdered()
    {
       foreach (Products product in _products)
        {
           _totalCost += product.PriceofProduct();
            
        }

        Console.WriteLine($"The total Cost is: {_totalCost}");
       // _totalPrice = _totalCost * _customer.Address().IsUsa()?_shippingCost: _outshippingCost;
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
        foreach (Customer customer in _customer)
        {
            customer.DisplayCustomerInfo();
        }

    }
}
