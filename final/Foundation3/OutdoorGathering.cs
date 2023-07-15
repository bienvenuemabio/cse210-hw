public class OutdoorGathering: Event
{
    private string _weatherStatement;

    public OutdoorGathering(string weatherStatement, string type, string title, string description, string date, string time, Address address): base(type,title,description,date,time,address)
    {
        _weatherStatement= weatherStatement;
    }

    public string GetWeather()
    {
        return _weatherStatement;

    }
    
    
}