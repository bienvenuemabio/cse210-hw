public class Activity
{
    private string _name;
    private string _date;
    private int _length;
    private int _distance;
    private int _speed;
    private int _pace;

    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;

    }

    public virtual int GetDistance()
    {
        return _distance;

    }
    public virtual int GetSpeed()
    {
        return _speed;
    }

    public virtual int GetPace()
    {
        return _pace;
    }
    public void SetDistance(int distance)
    {
      _distance= distance;
    }
    
    public string Summary()
    {
        return $"{_date} {_name}({_length}min): Distance {_distance}km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }

    public void Getsummary()
    {

    }

}