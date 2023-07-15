public class Running: Activity
{
    private string _place;
    private int _distance;

    public Running(string place, int distance, string name, string date,int length): base(name,date,length)
    {
        _place= place;
        _distance= distance;

    }

    public void GetPlace()
    {

    }

}