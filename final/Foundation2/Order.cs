public class Order
{
    private int _totalCost;
    private int _totalPrice;
    private int _shippingCost;
    public List<Products> _products;
    public List<Customer> _customers;

    public Order(int totalPrice, int totalCost, int shippingCost)
    {
        _totalCost=0;
        _totalPrice=0;
        _shippingCost=35;
        _products= new List<Products>();
        _customers= new List<Customer>();

    }

    public void AddProduct(Products product)
    {
        _products.Add(product);
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

           // _shippingCost =35;
            //_totalPrice= _totalCost * _shippingCost;
           // Console.WriteLine($"The total Price is: {_totalPrice}");

        //}
        

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
