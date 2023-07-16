public class Activity
{
    private string _name;
    private string _date;
    private int _length;
    private int _distance= 0;
    private int _speed = 0;
    private int _pace = 0;

    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;

    }

    public virtual int GetDistance()
    {
        return _distance += 60;

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