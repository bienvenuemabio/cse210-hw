public class Circle: shape
{
    private doudle _radius;

    private Circle(sting color, double radius): base(color)
    {
        _radius= radius;
    }

    public double SetRadius()
    {
        _radius= radius;

    }

    public void GetRadius()
    {
        return Radius;

    }
    public override double GetArea()
    {
        return 3.14*(radius*radius);
    }

}