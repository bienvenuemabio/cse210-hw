public class Address
{
    private string _addressId;
    private string _city;
    private string _province;
    private string _country;

    public Address()
    {

    }

    public void SetAddressId(string addressId)
    {
        _addressId= addressId;

    }

    public string GetAddressId()
    {
        return _addressId;
    }

    public void SetCity(string city)
    {
        _city= city;

    }

    public string GetCity()
    {
        return _city;
    }

    public void SetProvince(string province)
    {
        _province= province;

    }

    public string GetProvince()
    {
        return _province;
    }

    public void SetCountry(string country)
    {
        _country= country;

    }

    public string GetCountry()
    {
        return _country;
    }

    public void IsUsa()
    {
        if (_country== "Usa")
        {
            Console.WriteLine($"This customer is in UsA ");

        }
        else
        {
            Console.WriteLine($"This customer is not in Usa");
        }


    }
    public void DisplayAllField()
    {
        Console.WriteLine($"Address Number: {_addressId}");
        Console.WriteLine($"City: {_city}");
        Console.WriteLine($"Province: {_province}");
        Console.WriteLine($"Country: {_country}");

    }
}