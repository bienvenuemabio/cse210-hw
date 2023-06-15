public class Square: Shape
{
    private double _side;
    public Square(string color, double _side): base(color)
    {
        _side= side;

    }

    public double SetSide()
    {
        _side= side;

    }
    public void GetSide()
    {
        return _side;
    }
    public override double GetArea()
    {
        return _side * _side;

    }
}