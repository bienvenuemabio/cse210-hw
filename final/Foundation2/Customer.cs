public class Customer
{
    private string _customName;
    private Address _address;
    
    
    public Customer(string customName, Address address)
    {
        _customName= customName;
        _address= address;

    }
    public Address GetAddress()
    {
        return _address;
    }

    public void SetCustomName(string customName)
    {
        _customName= customName;

    } 
    public string GetCustomName()
    {
        return _customName;
    } 
    

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name:{_customName}");
        Console.WriteLine($"Address: {_address.DisplayAllField}");


    }

}