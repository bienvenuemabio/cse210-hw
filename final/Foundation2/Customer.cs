public class Customer
{
    private string _customName;
    private Address _address;
    private string _addresses;
    
    
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
        _addresses= _address.DisplayAllField();
        Console.WriteLine($" \n Customer Name:{_customName} \n {_addresses}");

    }

public string Address()
{
    _addresses= _address.DisplayAllField();
    return _addresses;

}
    


}