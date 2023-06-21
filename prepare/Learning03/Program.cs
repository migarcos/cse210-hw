using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction(); //whithout parameters
        Console.WriteLine(number.GetAsString());
        Console.WriteLine(number.GetAsFloat());

        number = new Fraction(5);   // whole parameter
        Console.WriteLine(number.GetAsString());
        Console.WriteLine(number.GetAsFloat());

        number = new Fraction(3,4);  // both parameters
        Console.WriteLine(number.GetAsString());
        Console.WriteLine(number.GetAsFloat());

        number = new Fraction(1,3);
        Console.WriteLine(number.GetAsString());
        Console.WriteLine(number.GetAsFloat());
    }
}