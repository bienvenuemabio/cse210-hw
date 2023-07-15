public class Activity
{
    private string _name;
    private string _date;
    private int _length;

    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public void GetDistance()
    {

    }
    public void GetSpeed()
    {

    }

    public void GetPace()
    {

    }
    public string Summary()
    {
        return $"{_date} {_name}({_length}min)";
    }

    public void Getsummary()
    {

    }

}