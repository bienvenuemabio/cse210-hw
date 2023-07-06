public class Order
{
    private int _shippingCost =0;
    private int _totalCost =0;
    private int _totalPrice=0;
    public List<Products> _products= new List<Products>();
    public List<Customer> _customers = new List<Customer>();

    public Order()
    {

    }

    public void TotalCostOrdered()
    {
        foreach (Products product in _products)
        {
            product.PriceofProduct();
            _totalCost += _amount;
            
        }
        if () 
            {
                _shippingCost = 5;
                
            }
            else 
            {
                _shippingCost = 35;
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
