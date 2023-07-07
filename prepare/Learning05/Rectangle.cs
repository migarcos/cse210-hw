public class Rectangle: Shape
{
    private double _lenght, _width;
    public Rectangle(double measure1, double measure2, string color = "", string name = "Rectangle"): base (name, color)
    {
        _lenght = measure2;
        _width = measure1; 
    }
    public void SetLenght(float measure1)
    {
        _lenght = measure1;
    }
    public void Setwidth(float measure2)
    {
        _width = measure2;
    }

    public override double GetArea()
    {
        return _lenght * _width / 2;
    }
}