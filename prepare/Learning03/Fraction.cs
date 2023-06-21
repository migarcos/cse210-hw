class Fraction
{
    private int _top, _bottom;

    // ------- CONSTRUCTORS (setters) -------
    public Fraction(int top = 1, int bottom = 1) // default values are asigned
    {
        _top = top;
        _bottom = bottom;
    }
    // public Fraction(int wholeNumber)
    // {
    //     _top = wholeNumber;
    //     _bottom = 1;
    // }

    // ------- Getters -------
    public string GetAsString()
    {
        return  $"{_top} / {_bottom}";
    }

    public double GetAsFloat()
    {
        double floatValue = (double)_top / (double)_bottom;
        return floatValue;
    }

}