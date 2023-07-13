public class OutdoorGathering: Event
{
    private Boolean _coolWeather;

    public OutdoorGathering(Boolean coolWeather, string title, string description, string date, string time, Address address): base(title,description,date,time,address)
    {
        _coolWeather= coolWeather;
    }

    public void GetWeather()
    {

    }
}