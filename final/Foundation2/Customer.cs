public class Customer
{
    private string _customName;
    private Address _customAddress;
    
    
    public Customer(string customName, Address customAddress)
    {
        _customName= customName;
        _customAddress= customAddress;

    }

    public void SetCustomName(string customName)
    {
        _customName= customName;

    } 
    public string GetCustomName()
    {
        return _customName;
    }

    public Address GetCustomAddress()
    {
        return _customAddress;
    } 
    //public string GetCustomAddress()
    //{
      //  return _customAddress;
    //}

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name:{_customName}");
        Console.WriteLine($"Address: {_customAddress.DisplayAllField}");


    }

}