public class  Rectangle: Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width):base(color)
    {
        _length= length;
        _width= width;
    }

    public double GetLength()
    {
       return  _length;

    }
    public double GetWidth()
    {
       return  _width;

    }

    public double SetLength()
    {
        _length= length;

    }
    public double SetWidth()
    {
        _width= width;

    }

    public override double GetArea()
    {
        return _length* _width;
    }


}