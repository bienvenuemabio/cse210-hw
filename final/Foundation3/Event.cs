public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description,string date, string time, Address address)
    {
        _title= title;
        _description= description;
        _date = date;
        _time = time;
        _address = address;

    }

    public void GenerateMsg()
    {

    }

    public void StandardDetails()
    {
        Console.WriteLine("Standard Details");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");


    }

    public void FullDetails()
    {

    }

    public void ShortDescription()
    {

    }

    public void DisplayEventInfo()
    {
        
    }
}