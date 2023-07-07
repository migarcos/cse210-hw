public class Square: Shape
{
    private double _side;
    public Square (double side = 1, string color = "", string name = "Square"): base(name, color)
    {
        _side = side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}