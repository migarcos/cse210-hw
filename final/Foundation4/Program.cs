using System;

class Program
{
    static void Main(string[] args)
    {
        Running rActivity = new Running("20 Jul 2023", 30, 15);
        Console.WriteLine(rActivity.GetSummary());

        Cycling cActivity = new Cycling("19 Jul 2023", 180, 40);
        Console.WriteLine(cActivity.GetSummary());

        Swimming sActivity = new Swimming("22 Jul 2022", 60, 8);
        Console.WriteLine(sActivity.GetSummary());
    }
}