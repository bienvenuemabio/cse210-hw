public class Address
{
    private string _id;
    private string _city;
    private string _country;

    public Address(string id, string city, string country)
    {
        _id=id;
        _city=city;
        _country= country;
    }

    public string GetAddressInfo()
    {
        return $" Number:{_id} ,{_city},{_country}";
    }
}