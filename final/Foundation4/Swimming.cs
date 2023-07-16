public class Swimming: Activity
{
    private int _numberofLaps;

    public Swimming(int numberofLaps, string name, string date, int length): base(name, date, length)
    {
        _numberofLaps= numberofLaps;

    }

    public int GetNumberofLaps()
    {
        return _numberofLaps;
    }
    public override int GetDistance()
    {
        return _numberofLaps * 50 / 1000;
    }


}