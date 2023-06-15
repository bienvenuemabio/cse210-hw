public  abstract class Shape
{   private string _color;

    public string GetColor(){
        return _color;
    }

    public void SetColor(string color)
    {
        _color= color;

    }
    public Shape(){
        _color= color;
    }
    public double GetArea(){

    }

    public abstract double GetArea();

}