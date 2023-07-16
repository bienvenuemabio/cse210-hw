public class Running: Activity
{
    private string _place;
    private int _distance;

    public Running(string place, int distance, string name, string date,int length): base(name,date,length)
    {
        _place= place;
        _distance= distance;

    }

    public override int GetPace()
    {
        return (60 / _distance);

    }

    public string GetPlace()
    {
        return _place;

    }

}