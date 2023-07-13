public class Address
{
    private string _addressId;
    private string _city;
    private string _province;
    private string _country;
    //private bool _checker;

    public Address(string addressId, string city, string province, string country)
    {
        _addressId = addressId;
        _city = city;
        _province = province;
        _country = country;
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

    public bool IsUsa(bool checker)
    {
        bool _checker;
        return _checker = _country.Contains("USA");

    }
    public void DisplayAllField()
    {
        Console.WriteLine($"Address Number: {_addressId}");
        Console.WriteLine($"City: {_city}");
        Console.WriteLine($"Province: {_province}");
        Console.WriteLine($"Country: {_country}");

    }
}