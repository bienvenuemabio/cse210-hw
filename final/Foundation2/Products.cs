public class Products
{
    private string _productId;
    private string _name;
    private int _price;
    private int _quantity;

    public Products()
    {

    }

    public void SetProductId(string productId)
    {
        _productId = productId;

    }
    public string GetProductId()
    {
        return _productId;
    }

    public void SetName(string name)
    {
        _name =name;

    }
    public string GetName()
    {
        return _name;
    }

    public void SetQuantity(int quantity)
    {
        _quantity= quantity;

    }
    public int GetQuantity()
    {
        return _quantity;
    }
    
    public void SetPrice(int price)
    {
        _price = price;

    }
    public int GetPrice()
    {
        return _price;
    }

    public void PriceofProduct( int total)
    {
        int _total = _quantity * _price;
        Console.WriteLine($"The price of the product is : {_total}");
    } 
    public void ProductInfo()
    {
        Console.WriteLine($"Product Number:{_productId}");
        Console.WriteLine($"Product Name:{_name}");
        Console.WriteLine($"Quantity:{_quantity}");
        Console.WriteLine($"Price:{_price}");
    }



}