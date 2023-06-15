public class Circle: Shape
{
    private double _radius;

    private Circle(string color, double radius): base(color)
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