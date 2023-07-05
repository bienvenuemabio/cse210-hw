public class Customer
{
    private string _customName;
    private string _customAddress;
    
    public Customer()
    {

    }
    public void SetCustomName(string customName)
    {
        _customName= customName;

    } 
    public string GetCustomName()
    {
        return _customName;
    }

    public void SetCustomAddress(string customAddress)
    {
        _customAddress= customAddress;

    } 
    public string GetCustomAddress()
    {
        return _customAddress;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name:{_customName}");
        Console.WriteLine($"Address: {_customAddress}");


    }

}