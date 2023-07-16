public class Cycling: Activity
{
    private int _speed;

    public Cycling(int speed, string name, string date, int length): base(name,date,length)
    {
        _speed= speed;

    }

    public override int GetSpeed()
    {
        return 60 / _speed;

    }

}