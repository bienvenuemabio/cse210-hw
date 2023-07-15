public class Swimming: Activity
{
    private int _numberofLaps;

    public Swimming(int numberofLaps, string name, string date, int length): base(name, date, length)
    {
        _numberofLaps= numberofLaps;

    }
}