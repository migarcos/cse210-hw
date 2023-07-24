using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture Event
        Address lAdrress = new Address("1451 Aunkst Road","Waterloo, New York 13165");
        Lectures lEvent = new Lectures("Faith Lectures","Church organization documents reading","July 30 2023","3:00 p.m.","Russell M. Nelson",50);
        lEvent.SetAddress(lAdrress);

        Console.WriteLine(lEvent.FullDetails());
        Console.WriteLine("-- - --- -- - -- --");
        Console.WriteLine(lEvent.StdDetails());
        Console.WriteLine("-- - --- -- - -- --");
        Console.WriteLine(lEvent.ShortDetails());

        Console.WriteLine(" * * * * * * * * * * * * * * * * ");
        // Outdoor Gathering
        Address ogAddress = new Address("2601 Sunnyside Ave S", "Salt Lake City, UT 84108");
        OutdoorGathering ogEvent = new OutdoorGathering("Pioneer Day","Pioneers Conmemoration","July 24 2023","10:00 a.m.","32°C Cloudy");
        ogEvent.SetAddress(ogAddress);

        Console.WriteLine(ogEvent.FullDetails());
        Console.WriteLine("-- - --- -- - -- --");
        Console.WriteLine(ogEvent.StdDetails());
        Console.WriteLine("-- - --- -- - -- --");
        Console.WriteLine(ogEvent.ShortDetails());

         Console.WriteLine(" * * * * * * * * * * * * * * * * ");
        // 
        Address rAddress = new Address("BYU-Idaho Center","Rexburg, ID");
        Reception rEvent = new Reception("Campus Graduation","Bachelors Degrees Ceremony","July 19 2023","8 p.m.","graduation@byui.edu");
        rEvent.SetAddress(rAddress);

        Console.WriteLine(rEvent.FullDetails());
        Console.WriteLine("-- - --- -- - -- --");
        Console.WriteLine(rEvent.StdDetails());
        Console.WriteLine("-- - --- -- - -- --");
        Console.WriteLine(rEvent.ShortDetails());
    }
}