public class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _addresses;

    public Event( string type, string title, string description,string date, string time, Address address)
    {
        _type= type;
        _title= title;
        _description= description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string StandardDetails()
    {
        return $"Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address.GetAddressInfo()}";
    }

    public string FullDetails()
    {
        return $"Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address.GetAddressInfo()} \n Type: {_type} \n ";   

    }

    public string ShortDescription()
    {
        return $"Type:{_type} \n Date:{_date} \n Time: {_time}";


    }

    public void DisplayEventInfo()
    {
        
    }

    public Address GetAddress(){
        return _address;
    }

    public void GetAddresses()
    {
        _addresses= _address.GetAddressInfo();
        Console.WriteLine(_addresses);
    }
}