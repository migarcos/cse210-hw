public class Circle: Shape
{
    private double _ratio;
    public Circle (double ratio = 1, string color = "", string name = "Circle"): base (name, color)
    {
        _ratio = ratio;
    }
    public override double GetArea()
    {
        return 3.1416 * _ratio * _ratio;
    }
}