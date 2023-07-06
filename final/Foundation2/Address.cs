public class Address
{
    private string _addressId;
    private string _city;
    private string _province;
    private string _country;

    public class Address()
    {

    }

    public void SetAddressId()
    {
        _addressId= addressId;

    }

    public string GetAddressId()
    {
        return _addressId;
    }

    public void SetCity()
    {
        _city= city;

    }

    public string GetAddressId()
    {
        return _city;
    }

    public void SetProvince()
    {
        _province= province;

    }

    public string GetProvince()
    {
        return _province;
    }

    public void SetCountry()
    {
        _country= country;

    }

    public string GetCountry()
    {
        return _country;
    }

    public string IsUsa()
    {


    }
    public void DisplayAllField()
    {
        Console.WriteLine($"Address Number: {_ addressId}");
        Console.WriteLine($"City: {_ city}");
        Console.WriteLine($"Province: {_ Province}");
        Console.WriteLine($"Country: {_ country}");

    }
}